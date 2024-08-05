
using System.ComponentModel.DataAnnotations;


namespace JSVProject_Models
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


    }
}
