using ControleFinanceiro.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DespesasController : ControllerBase
    {
        private readonly ControleContext _dbContext;

        public DespesasController(ControleContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetDespesas()
        {
            try
            {
                var list = _dbContext.Despesas.ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }
    }
}