using SRP_Fatura.Api.Models;

namespace SRP_Fatura.Api.Repositorys
{
    // Responsável apenas por salvar no banco
    public class FaturaRepository
    {
        public void Salvar(Fatura fatura)
        {
            Console.WriteLine("Fatura salva no banco de dados!");
            // Aqui poderia ter um _dbContext.SaveChanges() se fosse um Entity Framework, por exemplo
        }
    }
}
