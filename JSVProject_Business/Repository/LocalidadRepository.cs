
using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_Business.Repository
{
    public class LocalidadRepository : ILocalidadRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public LocalidadRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<LocalidadDTO> Create(LocalidadDTO objDTO)
        {
            var obj = _mapper.Map<LocalidadDTO, Localidad>(objDTO);
            //  obj.CreatedDate = DateTime.Now;
            var addedObj = _db.Localidades.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Localidad, LocalidadDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Localidades.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Localidades.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<LocalidadDTO> Get(int id)
        {
            var obj = await _db.Localidades.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Localidad, LocalidadDTO>(obj);
            }
            return new LocalidadDTO();
        }

        public async Task<IEnumerable<LocalidadDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Localidad>, IEnumerable<LocalidadDTO>>(_db.Localidades);
        }

        public async Task<LocalidadDTO> Update(LocalidadDTO objDTO)
        {
            var objFromDb = await _db.Localidades.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Descripcion = objDTO.Descripcion;
                _db.Localidades.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Localidad, LocalidadDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}

