using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JSVProject_Models
{
    public class ValDañoDTO
    {
        public int Id { get; set; }
        
        public DateTime FechaDerivado { get; set; }

        public string EstadoGestion { get; set; }

        //  public int? ProvinciaId { get; set; }
        // public virtual ProvinciaDTO Provincia { get; set; }

        public int? LocalidadId { get; set; }

        public virtual LocalidadDTO Localidad { get; set; }

        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string TipoVh { get; set; }
        public string Dominio { get; set; }
        public string Nvin { get; set; }

        public string GestorEIR { get; set; }
        public string Obs { get; set; }
        //public string UbicacionPC { get; set; } //
    }
}






