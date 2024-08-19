using System.ComponentModel.DataAnnotations;

namespace JSVProject_Models
{
    public class VehiculoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }
        public string Dominio { get; set; }
        public string Nvin { get; set; }
        public string Marca { get; set; }
    }
}

