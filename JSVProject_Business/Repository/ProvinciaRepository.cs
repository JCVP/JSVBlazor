using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_Business.Repository
{
    public class ProvinciaRepository : IProvinciaRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProvinciaRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProvinciaDTO> Create(ProvinciaDTO objDTO)
        {
            var obj = _mapper.Map<ProvinciaDTO, Provincia>(objDTO);
            //  obj.CreatedDate = DateTime.Now;
            var addedObj = _db.Provincias.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Provincia, ProvinciaDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Provincias.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Provincias.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ProvinciaDTO> Get(int id)
        {
            var obj = await _db.Provincias.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Provincia, ProvinciaDTO>(obj);
            }
            return new ProvinciaDTO();
        }

        public async Task<IEnumerable<ProvinciaDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Provincia>, IEnumerable<ProvinciaDTO>>(_db.Provincias);
        }

        public async Task<ProvinciaDTO> Update(ProvinciaDTO objDTO)
        {
            var objFromDb = await _db.Provincias.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Descripcion = objDTO.Descripcion;
                _db.Provincias.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Provincia, ProvinciaDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}

