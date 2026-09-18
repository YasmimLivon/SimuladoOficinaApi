namespace SimuladoOficinaApi.Models.DTOs
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public string Status { get; set; } // "Aguardando", "Em Análise", "Concluído"
    }
}