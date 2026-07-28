using Microsoft.AspNetCore.Mvc;
using BancoDeSangue.Shared.Models;

namespace BancoDeSangue.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TriagemController : ControllerBase
{
    [HttpPost]
    public IActionResult ProcessarTriagem([FromBody] Doador doador)
    {
        return Ok(new { Mensagem = "Triagem realizada com sucesso!", Doador = doador });
    }
}