using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_Business.Repository
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public VehiculoRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<VehiculoDTO> Create(VehiculoDTO objDTO)
        {
            var obj = _mapper.Map<VehiculoDTO, Vehiculo>(objDTO);
            var addedObj = _db.Vehiculos.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Vehiculo, VehiculoDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Vehiculos.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Vehiculos.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<VehiculoDTO> Get(int id)
        {
            var obj = await _db.Vehiculos.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Vehiculo, VehiculoDTO>(obj);
            }
            return new VehiculoDTO();
        }

        public async Task<IEnumerable<VehiculoDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Vehiculo>, IEnumerable<VehiculoDTO>>(_db.Vehiculos);
        }

        public async Task<VehiculoDTO> Update(VehiculoDTO objDTO)
        {
            var objFromDb = await _db.Vehiculos.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Tipo = objDTO.Tipo;
                _db.Vehiculos.Update(objFromDb);
                objFromDb.Dominio = objDTO.Dominio;
                _db.Vehiculos.Update(objFromDb);
                objFromDb.Nvin = objDTO.Nvin;
                _db.Vehiculos.Update(objFromDb);
                objFromDb.Marca = objDTO.Marca;
                _db.Vehiculos.Update(objFromDb);


                await _db.SaveChangesAsync();
                return _mapper.Map<Vehiculo, VehiculoDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
