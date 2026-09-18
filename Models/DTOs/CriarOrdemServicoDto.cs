namespace SimuladoOficinaApi.Models.DTOs
{
    public class CriarOrdemServicoDto
    {
        public string PlacaVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string DescricaoUsuario { get; set; }
        public string DiagnosticoTecnico { get; set; }
        public int UsuarioId { get; set; }

    }
}
