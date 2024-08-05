using System.ComponentModel.DataAnnotations;


namespace JSVProject_Models
{
    public class EmpresaDTO
    {
        public int Id { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }




        /*
                public EmpresaDTO() { }

                public List<EmpresaDTO> ListaEmpresas = new List<EmpresaDTO>();
                public void AgregarAtributo(string RazonSocial)
                {
                    ListaEmpresas.Add(new EmpresaDTO
                    {
                        RazonSocial = RazonSocial,

                    });
                }
        */
    }



}



