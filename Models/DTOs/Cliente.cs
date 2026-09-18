namespace SimuladoOficinaApi.Models.DTOs
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    }
}