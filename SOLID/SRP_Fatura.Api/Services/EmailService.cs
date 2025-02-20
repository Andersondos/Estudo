namespace SRP_Fatura.Api.Services
{
    // Responsável apenas por enviar e-mail
    public class EmailService
    {
        public void Enviar(string email, string mensagem)
        {
            Console.WriteLine(@$"Enviando e-mail para {email} 
                                 Mensagem: {mensagem}");
        }
    }
}
