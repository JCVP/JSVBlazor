using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JSVProject_DataAccess
{
    public class Siniestro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]

        public string Numero { get; set; }
        [Required]
        public DateTime? FechaDerivado { get; set; }

        public DateTime FechaSiniestro { get; set; }

        public int? ProvinciaId { get; set; }
        [ForeignKey("ProvinciaId")]
        public virtual Provincia Provincia { get; set; }
        public string Empresa { get; set; }
        public string Nombre { get; set; }
        public string? DNI { get; set; }
        [StringLength(80)]
        public string? Domicilio { get; set; }
        [StringLength(50)]
        public string? Telefono { get; set; }
        [StringLength(80)]
        public string? Email { get; set; }
        [StringLength(256)]
        public string? Obs { get; set; }


    }
}

