using System.ComponentModel.DataAnnotations;

namespace JSVProject_DataAccess
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


    }
}