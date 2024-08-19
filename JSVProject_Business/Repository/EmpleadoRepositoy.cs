using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_Business.Repository
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public EmpleadoRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<EmpleadoDTO> Create(EmpleadoDTO objDTO)
        {
            var obj = _mapper.Map<EmpleadoDTO, Empleado>(objDTO);
            var addedObj = _db.Empleados.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Empleado, EmpleadoDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Empleados.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Empleados.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<EmpleadoDTO> Get(int id)
        {
            var obj = await _db.Empleados.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Empleado, EmpleadoDTO>(obj);
            }
            return new EmpleadoDTO();
        }

        public async Task<IEnumerable<EmpleadoDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Empleado>, IEnumerable<EmpleadoDTO>>(_db.Empleados);
        }

        public async Task<EmpleadoDTO> Update(EmpleadoDTO objDTO)
        {
            var objFromDb = await _db.Empleados.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Nombre = objDTO.Nombre;
                _db.Empleados.Update(objFromDb);
                objFromDb.DNI = objDTO.DNI;
                _db.Empleados.Update(objFromDb);
                objFromDb.Domicilio = objDTO.Domicilio;
                _db.Empleados.Update(objFromDb);
                objFromDb.Telefono = objDTO.Telefono;
                _db.Empleados.Update(objFromDb);
                objFromDb.Email = objDTO.Email;
                _db.Empleados.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Empleado, EmpleadoDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
