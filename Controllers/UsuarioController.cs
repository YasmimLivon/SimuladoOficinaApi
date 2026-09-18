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
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<UsuarioDto>>> GetAll()
        {
            var usuarios = await _context.Usuarios
                .Select(a => new UsuarioDto
                {
                    Nome = a.Nome,
                    Id = a.Id,
                })
                .ToListAsync();

            return Ok(usuarios);
        }

        [HttpPost]

        public async Task<IActionResult> CreateUsuario(CriarUsuarioDto usuarios)
        {
            var novousuario = new Usuario
            {
            Nome = usuarios.Nome,
            Email = usuarios.Email,
            SenhaUsuario = usuarios.SenhaUsuario,
            Telefone = usuarios.Telefone,
            };
            _context.Usuarios.Add(novousuario);
            await _context.SaveChangesAsync();
            return Ok("Usuário criado com sucesso");
        }
    }
}
