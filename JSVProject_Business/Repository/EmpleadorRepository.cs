/*
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
    public class EmpleadorRepository : IEmpleadorRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public EmpleadorRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<EmpleadorDTO> Create(EmpleadorDTO objDTO)
        {
            var obj = _mapper.Map<EmpleadorDTO, Empleador>(objDTO);
            var addedObj = _db.Empleadores.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Empleador, EmpleadorDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Empleadores.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Empleadores.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<EmpleadorDTO> Get(int id)
        {
            var obj = await _db.Empleadores.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Empleador, EmpleadorDTO>(obj);
            }
            return new EmpleadorDTO();
        }

        public async Task<IEnumerable<EmpleadorDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Empleador>, IEnumerable<EmpleadorDTO>>(_db.Empleadores);
        }

        public async Task<EmpleadorDTO> Update(EmpleadorDTO objDTO)
        {
            var objFromDb = await _db.Empleadores.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Nombre = objDTO.Nombre;
                _db.Empleadores.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Empleador, EmpleadorDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
*/