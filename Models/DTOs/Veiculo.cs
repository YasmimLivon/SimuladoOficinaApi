namespace SimuladoOficinaApi.Models.DTOs
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}