using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_Business.Repository
{
    public class ValDañoRepository : IValDañoRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ValDañoRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<ValDañoDTO> Create(ValDañoDTO objDTO)
        {
            var obj = _mapper.Map<ValDañoDTO, ValDaño>(objDTO);
            var addedObj = _db.ValDaños.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<ValDaño, ValDañoDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.ValDaños.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.ValDaños.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ValDañoDTO> Get(int id)
        {
            var obj = await _db.ValDaños.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<ValDaño, ValDañoDTO>(obj);
            }
            return new ValDañoDTO();
        }

        public async Task<IEnumerable<ValDañoDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<ValDaño>, IEnumerable<ValDañoDTO>>(_db.ValDaños);
        }

        public async Task<ValDañoDTO> Update(ValDañoDTO objDTO)
        {
            var objFromDb = await _db.ValDaños.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.TipoVh = objDTO.TipoVh;              
                objFromDb.Dominio = objDTO.Dominio;                
                objFromDb.Nvin = objDTO.Nvin;

                _db.ValDaños.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<ValDaño, ValDañoDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
