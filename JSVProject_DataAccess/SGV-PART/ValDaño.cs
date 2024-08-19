
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JSVProject_DataAccess;

public class ValDaño
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime FechaDerivado { get; set; }
    public string EstadoGestion { get; set; }
    //public int? ProvinciaId { get; set; }
    //[ForeignKey("ProvinciaId")]
    //  public virtual Provincia Provincia { get; set; }
    public int? LocalidadId { get; set; }
    [ForeignKey("LocalidadId")]
    public virtual Localidad Localidad { get; set; }
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




    // public string UbicacionPC { get; set; }
}






