using Microsoft.EntityFrameworkCore;
using SimuladoOficinaApi.Models.DTOs;

namespace SimuladoOficinaApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<OrdemServicoDto> OrdemServico { get; set; }
    }
}
