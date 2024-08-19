using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface IEmpleadoRepository
    {
        public Task<EmpleadoDTO> Create(EmpleadoDTO objDTO);
        public Task<EmpleadoDTO> Update(EmpleadoDTO objDTO);
        public Task<int> Delete(int id);
        public Task<EmpleadoDTO> Get(int id);
        public Task<IEnumerable<EmpleadoDTO>> GetAll();
    }
}
