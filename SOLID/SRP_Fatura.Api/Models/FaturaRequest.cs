namespace SRP_Fatura.Api.Models
{
    public class FaturaRequest
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
