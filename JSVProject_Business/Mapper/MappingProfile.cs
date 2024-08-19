using AutoMapper;
using JSVProject_DataAccess;
using JSVProject_Models;

namespace JSVProject_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /* CreateMap<Empleador, EmpleadorDTO>().ReverseMap();*/
            CreateMap<Empresa, EmpresaDTO>().ReverseMap();
            CreateMap<Empleado, EmpleadoDTO>().ReverseMap();
            CreateMap<Siniestro, SiniestroDTO>().ReverseMap();
            CreateMap<Pericia, PericiaDTO>().ReverseMap();
            CreateMap<Provincia, ProvinciaDTO>().ReverseMap();
            CreateMap<Localidad, LocalidadDTO>().ReverseMap();
            CreateMap<Vehiculo, VehiculoDTO>().ReverseMap();
            CreateMap<ValDaño, ValDañoDTO>().ReverseMap();
        }
    }

}