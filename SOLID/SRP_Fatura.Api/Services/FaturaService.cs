using SRP_Fatura.Api.Models;
using SRP_Fatura.Api.Repositorys;

namespace SRP_Fatura.Api.Services
{
    // Responsável apenas por criar faturas
    public class FaturaService
    {
        private readonly FaturaRepository _faturaRepository;
        private readonly NotificationService _notificationService;

        public FaturaService(FaturaRepository faturaRepository, NotificationService notificationService)
        {
            _faturaRepository = faturaRepository;
            _notificationService = notificationService;
        }

        public void ProcessarFatura(string nome, decimal valor, string email, string telefone)
        {
            var fatura = new Fatura(nome, valor);
            _faturaRepository.Salvar(fatura);
            _notificationService.Notificar(email, telefone, "Sua fatura foi gerada com sucesso!");
        }
    }
}
