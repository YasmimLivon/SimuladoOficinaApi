using SimuladoOficinaApi.Data;
using SimuladoOficinaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimuladoOficinaApi.Models.DTOs;


namespace SimuladoOficinaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationBuilder _context;

        public AuthController(ApplicationBuilder context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody] Usuario loginRequest)
        {
            var usuario = await _context.Usuario
                .FirstDefaultAsync(u => u.Email.ToLower() == loginRequest.Email.ToLower());

            if (usuario == null || usuario.SenhaUsuario != loginRequest.SenhaUsuario)
            {
                return Unauthorized("Email ou Senha incorretos!");
            }
            return Ok(new {Nome = usuario.Nome});
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] Usuario registerRequest)
        {
            if(await _context.Usuarios.AnyAsync(u => u.Email.ToLower() == registerRequest.Email.ToLower()))
            {
                return BadRequest("Este e-mail já está sendo utilizado!");
            }

            var novoUsuario = new Usuario
            {
                Nome = registerRequest.Nome,
                Email = registerRequest.Email,
                SenhaUsuario = registerRequest.SenhaUsuario,
            };
            _context.Usuario.Add(novoUsuario);
            await _context.SaveChangeAsync();

            return CreatedAtAction(nameof(Register), new {id = novoUsuario.Id}, new {novoUsuario.Nome , novoUsuario.Email});
        }
    }
}
