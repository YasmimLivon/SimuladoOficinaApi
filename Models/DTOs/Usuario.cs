namespace SimuladoOficinaApi.Models.DTOs
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int SenhaUsuario { get; set; }

        public List<OrdemServicoDto> ServicosRealizados { get; set; }
    }
}
