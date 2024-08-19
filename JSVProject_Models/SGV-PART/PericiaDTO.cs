using System.ComponentModel.DataAnnotations;


namespace JSVProject_Models
{
    public class PericiaDTO
    {
        public int Id { get; set; }
        [Required]
        public string Legajo { get; set; }
        public string FechaInicioServicio { get; set; }
        public string Fecha { get; set; }
        public string TipoPericia { get; set; }
        public string Cliente { get; set; }
        public string EntidadJudicial { get; set; }
        public string Localidad { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
    }
}






