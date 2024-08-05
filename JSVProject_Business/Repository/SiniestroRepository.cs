using AutoMapper;
using JSVProject_Business.Repository.IRepository;
using JSVProject_DataAccess;
using JSVProject_DataAccess.Data;
using JSVProject_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVProject_Business.Repository
{
    public class SiniestroRepository : ISiniestroRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public SiniestroRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<SiniestroDTO> Create(SiniestroDTO objDTO)
        {
            var obj = _mapper.Map<SiniestroDTO, Siniestro>(objDTO);
            var addedObj = _db.Siniestros.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Siniestro, SiniestroDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Siniestros.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Siniestros.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<SiniestroDTO> Get(int id)
        {
            var obj = await _db.Siniestros.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Siniestro, SiniestroDTO>(obj);
            }
            return new SiniestroDTO();
        }

        public async Task<IEnumerable<SiniestroDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Siniestro>, IEnumerable<SiniestroDTO>>(_db.Siniestros);
        }

        public async Task<SiniestroDTO> Update(SiniestroDTO objDTO)
        {
            var objFromDb = await _db.Siniestros.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Numero = objDTO.Numero;
                _db.Siniestros.Update(objFromDb);
                objFromDb.FechaDerivado = objDTO.FechaDerivado;
                _db.Siniestros.Update(objFromDb);
                objFromDb.FechaSiniestro = objDTO.FechaSiniestro;
                _db.Siniestros.Update(objFromDb);
                objFromDb.Nombre = objDTO.Nombre;
                _db.Siniestros.Update(objFromDb);
                objFromDb.DNI = objDTO.DNI;
                _db.Siniestros.Update(objFromDb);
                objFromDb.Domicilio = objDTO.Domicilio;
                _db.Siniestros.Update(objFromDb);
                objFromDb.Telefono = objDTO.Telefono;
                _db.Siniestros.Update(objFromDb);
                objFromDb.Email = objDTO.Email;
                _db.Siniestros.Update(objFromDb);
                objFromDb.Obs = objDTO.Obs;
                _db.Siniestros.Update(objFromDb);

                await _db.SaveChangesAsync();
                return _mapper.Map<Siniestro, SiniestroDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
