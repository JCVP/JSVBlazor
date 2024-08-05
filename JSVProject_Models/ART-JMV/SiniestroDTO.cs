
using System.ComponentModel.DataAnnotations;


namespace JSVProject_Models
{
    public class SiniestroDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo {0} debe ser una cadena con una longitud máxima de {1}.")]
        [Display(Name = "Número")]
        public string Numero { get; set; }
        [Display(Name = "Fecha Derivado")]
        public DateTime? FechaDerivado { get; set; }
        [Display(Name = "Fecha Siniestro")]
        public DateTime FechaSiniestro { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name = "Provincia")]
        public int ProvinciaId { get; set; }
        public virtual ProvinciaDTO Provincia { get; set; }
        public string Empresa { get; set; }
        public string Nombre { get; set; }
        public string? DNI { get; set; }
        [StringLength(80, ErrorMessage = "El campo {0} debe ser una cadena con una longitud máxima de {1}.")]
        public string? Domicilio { get; set; }
        [Display(Name = "Teléfono")]
        [StringLength(50, ErrorMessage = "El campo {0} debe ser una cadena con una longitud máxima de {1}.")]
        public string? Telefono { get; set; }
        [StringLength(80, ErrorMessage = "El campo {0} debe ser una cadena con una longitud máxima de {1}.", MinimumLength = 3)]
        [EmailAddress(ErrorMessage = "Email Invalido")]
        public string? Email { get; set; }
        [Display(Name = "Observaciones")]
        [StringLength(256, ErrorMessage = "El campo {0} debe ser una cadena con una longitud máxima de {1}.")]
        public string? Obs { get; set; }
    }
}









