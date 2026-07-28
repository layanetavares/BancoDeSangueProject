using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BancoDeSangue.API.Data;
using BancoDeSangue.API.Models;

namespace BancoDeSangue.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BolsasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BolsasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("estoque")]
        public async Task<IActionResult> GetEstoque()
        {
            var resumo = await _context.Exames
                .GroupBy(e => e.ResultadoGlobal)
                .Select(g => new 
                { 
                    Resultado = g.Key, 
                    Quantidade = g.Count() 
                })
                .ToListAsync();

            return Ok(resumo);
        }
    }
}