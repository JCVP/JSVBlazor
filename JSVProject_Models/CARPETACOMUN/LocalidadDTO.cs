using System.ComponentModel.DataAnnotations;

namespace JSVProject_Models
{
    public class LocalidadDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El campo {0} debe ser una cadena con una longitud máxima de {1}.")]
        public string Descripcion { get; set; }

        [Display(Name = "Provincia")]
        public int ProvinciaId { get; set; }

        public virtual ProvinciaDTO Provincia { get; set; }
    }
}
