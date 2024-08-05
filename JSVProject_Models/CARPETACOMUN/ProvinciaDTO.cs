using System.ComponentModel.DataAnnotations;

namespace JSVProject_Models
{
    public class ProvinciaDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El campo {0} debe ser una cadena con una longitud máxima de {1}.")]
        public string Descripcion { get; set; }
    }
}
