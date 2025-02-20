using Microsoft.AspNetCore.Mvc;
using SRP_Fatura.Api.Models;
using SRP_Fatura.Api.Services;

namespace SRP_Fatura.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaturaController : ControllerBase
    {
        private readonly FaturaService _faturaService;

        public FaturaController(FaturaService faturaService)
        {
            _faturaService = faturaService;
        }

        [HttpPost("processar")]
        public IActionResult ProcessarFatura([FromBody] FaturaRequest request)
        {
            _faturaService.ProcessarFatura(request.Nome, request.Valor, request.Email, request.Telefone);
            return Ok("Fatura processada com sucesso!");
        }
    }
}
