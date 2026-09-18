using System.Reflection.Metadata.Ecma335;

namespace SimuladoOficinaApi.Models.DTOs
{
    public class VeiculoDto
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }
}
