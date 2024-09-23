namespace ApiTaller.Models
{
    public class Cita
    {
        public long Id { get; set; }
        public long? ClienteId { get; set; }
        public long? VehiculoId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }

        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
