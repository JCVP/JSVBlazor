using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_Business.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public EmpresaRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<EmpresaDTO> Create(EmpresaDTO objDTO)
        {
            var obj = _mapper.Map<EmpresaDTO, Empresa>(objDTO);
            var addedObj = _db.Empresas.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Empresa, EmpresaDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Empresas.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Empresas.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<EmpresaDTO> Get(int id)
        {
            var obj = await _db.Empresas.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Empresa, EmpresaDTO>(obj);
            }
            return new EmpresaDTO();
        }

        public async Task<IEnumerable<EmpresaDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaDTO>>(_db.Empresas);
        }

        public async Task<EmpresaDTO> Update(EmpresaDTO objDTO)
        {
            var objFromDb = await _db.Empresas.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.RazonSocial = objDTO.RazonSocial;
                _db.Empresas.Update(objFromDb);
                objFromDb.Cuit = objDTO.Cuit;
                _db.Empresas.Update(objFromDb);
                objFromDb.Domicilio = objDTO.Domicilio;
                _db.Empresas.Update(objFromDb);
                objFromDb.Telefono = objDTO.Telefono;
                _db.Empresas.Update(objFromDb);
                objFromDb.Email = objDTO.Email;
                _db.Empresas.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Empresa, EmpresaDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
