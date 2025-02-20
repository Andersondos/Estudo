namespace SRP_Fatura.Api.Services
{
    public class SmsService
    {
        public void Enviar(string numero, string mensagem)
        {
            Console.WriteLine(@$"Enviando SMS para {numero}. 
                                 Mensagem: {mensagem}");
        }
    }
}
