namespace SRP_Fatura.Api.Models
{
    public class Fatura
    {
        public string NomeCliente { get; set; }
        public decimal Valor { get; set; }

        public Fatura(string nomeCliente, decimal valor)
        {
            NomeCliente = nomeCliente;
            Valor = valor;
        }

        public class FaturaRequest
        {
            public string Nome { get; set; }
            public decimal Valor { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
        }
    }
}
