using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimuladoOficinaApi.Data;
using SimuladoOficinaApi.Models;
using SimuladoOficinaApi.Models.DTOs;

namespace SimuladoOficinaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdemServicoController : Controller
    {
            private readonly AppDbContext _context;

            public OrdemServicoController(AppDbContext context) 
            { 
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Usuario>>> Get()
            {
                var ordemservico = await _context.OrdemServico
                    .Select(a => new OrdemServico
                    { 
                        VeiculoId = a.Id,
                    })
                    .ToListAsync();
                return Ok(ordemservico);
            }

            [HttpPost]
            public async Task<IActionResult> CreateOrdemServico(CriarOrdemServicoDto ordemServico)
            {
                var novaOrdemServico = new OrdemServicoDto
                {
                    PlacaVeiculo = ordemServico.PlacaVeiculo,
                    ModeloVeiculo = ordemServico.ModeloVeiculo,
                    DescricaoUsuario = ordemServico.DescricaoUsuario,
                    UsuarioId = ordemServico.UsuarioId,
                    Status = "Aberto",
                };

                _context.OrdemServico.Add(novaOrdemServico);
                await _context.SaveChangesAsync();
                return Ok(ordemServico);
        }
    }
}
