using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;

namespace JSVProject_Business.Repository
{
    public class PericiaRepository : IPericiaRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public PericiaRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<PericiaDTO> Create(PericiaDTO objDTO)
        {
            var obj = _mapper.Map<PericiaDTO, Pericia>(objDTO);
            var addedObj = _db.Pericias.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Pericia, PericiaDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Pericias.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Pericias.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<PericiaDTO> Get(int id)
        {
            var obj = await _db.Pericias.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Pericia, PericiaDTO>(obj);
            }
            return new PericiaDTO();
        }

        public async Task<IEnumerable<PericiaDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Pericia>, IEnumerable<PericiaDTO>>(_db.Pericias);
        }

        public async Task<PericiaDTO> Update(PericiaDTO objDTO)
        {
            var objFromDb = await _db.Pericias.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Legajo = objDTO.Legajo;
                _db.Pericias.Update(objFromDb);
                objFromDb.FechaInicioServicio = objDTO.FechaInicioServicio;
                _db.Pericias.Update(objFromDb);
                objFromDb.Fecha = objDTO.Fecha;
                _db.Pericias.Update(objFromDb);
                objFromDb.TipoPericia = objDTO.TipoPericia;
                _db.Pericias.Update(objFromDb);
                objFromDb.Cliente = objDTO.Cliente;
                _db.Pericias.Update(objFromDb);
                objFromDb.EntidadJudicial = objDTO.EntidadJudicial;
                _db.Pericias.Update(objFromDb);
                objFromDb.Localidad = objDTO.Localidad;
                _db.Pericias.Update(objFromDb);
                objFromDb.Domicilio = objDTO.Domicilio;
                _db.Pericias.Update(objFromDb);
                objFromDb.Telefono = objDTO.Telefono;
                _db.Pericias.Update(objFromDb);
                objFromDb.Email = objDTO.Email;
                _db.Pericias.Update(objFromDb);
                objFromDb.Observaciones = objDTO.Observaciones;
                _db.Pericias.Update(objFromDb);

                await _db.SaveChangesAsync();
                return _mapper.Map<Pericia, PericiaDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
