namespace SimuladoOficinaApi.Models.DTOs
{
    public class OrdemServicoDto
    {
        public int Id { get; set; }
        public string PlacaVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string DescricaoUsuario { get; set; }
        public string DiagnosticoTecnico { get; set; }

        public int UsuarioId { get; set; }
        public UsuarioDto Usuario { get; set; }
        public string Status { get; set; }
    }
}
