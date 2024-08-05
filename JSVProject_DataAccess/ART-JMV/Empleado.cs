using System.ComponentModel.DataAnnotations;

namespace JSVProject_DataAccess
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


    }
}