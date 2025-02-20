namespace SRP_Fatura.Api.Services
{
    public class NotificationService
    {
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;

        public NotificationService(EmailService emailService, SmsService smsService)
        {
            _emailService = emailService;
            _smsService = smsService;
        }

        public void Notificar(string email, string telefone, string mensagem)
        {
            if (!string.IsNullOrEmpty(email))
                _emailService.Enviar(email, mensagem);

            if (!string.IsNullOrEmpty(telefone))
                _smsService.Enviar(telefone, mensagem);
        }
    }
}
