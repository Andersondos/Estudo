// Classe que representa a Fatura (Modelo)
public class Fatura
{
    public string NomeCliente { get; set; }
    public decimal Valor { get; set; }

    public Fatura(string nomeCliente, decimal valor)
    {
        NomeCliente = nomeCliente;
        Valor = valor;
    }
}

// Responsável apenas por salvar no banco
public class FaturaRepository
{
    public void SalvarFatura(Fatura fatura)
    {
        Console.WriteLine("Salvando no banco de dados...");
    }
}

// Interface para notificações
public interface INotificacaoService
{
    void Enviar(string destino, string mensagem);
}

// Implementação para e-mail
public class EmailService : INotificacaoService
{
    public void Enviar(string destino, string mensagem)
    {
        Console.WriteLine($"Enviando e-mail para {destino}: {mensagem}");
    }
}
// Responsável apenas por criar faturas
public class FaturaService
{
    public Fatura CriarFatura(string nome, decimal valor)
    {
        Console.WriteLine("Gerando Fatura...");
        return new Fatura(nome, valor);
    }
}

// Implementação para SMS
public class SmsService : INotificacaoService
{
    public void Enviar(string destino, string mensagem)
    {
        Console.WriteLine($"Enviando SMS para {destino}: {mensagem}");
    }
}

// Serviço que gerencia todas as notificações
public class NotificationService
{
    private readonly List<INotificacaoService> _notificacoes;

    public NotificationService()
    {
        _notificacoes = new List<INotificacaoService>
        {
            new EmailService(),
            new SmsService()
        };
    }

    public void Notificar(string email, string telefone, string mensagem)
    {
        if (!string.IsNullOrEmpty(email))
            _notificacoes[0].Enviar(email, mensagem);

        if (!string.IsNullOrEmpty(telefone))
            _notificacoes[1].Enviar(telefone, mensagem);
    }
}

// Controller que gerencia o processo da fatura
public class FaturaController
{
    private readonly FaturaService _faturaService;
    private readonly FaturaRepository _faturaRepository;
    private readonly NotificationService _notificationService;

    public FaturaController()
    {
        _faturaService = new FaturaService();
        _faturaRepository = new FaturaRepository();
        _notificationService = new NotificationService();
    }

    public void ProcessarFatura(string nome, decimal valor, string email, string telefone)
    {
        var fatura = _faturaService.CriarFatura(nome, valor);
        _faturaRepository.SalvarFatura(fatura);
        _notificationService.Notificar(email, telefone, "Sua fatura foi gerada com sucesso!");
    }
}

// Teste
class Program
{
    static void Main()
    {
        var controller = new FaturaController();
        controller.ProcessarFatura("João", 100.50m, "joao@email.com", "11999999999");
    }
}
