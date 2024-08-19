using System.ComponentModel.DataAnnotations;

namespace JSVProject_DataAccess
{
    public class Provincia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
