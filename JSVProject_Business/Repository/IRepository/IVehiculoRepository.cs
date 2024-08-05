using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface IVehiculoRepository
    {
        public Task<VehiculoDTO> Create(VehiculoDTO objDTO);
        public Task<VehiculoDTO> Update(VehiculoDTO objDTO);
        public Task<int> Delete(int id);
        public Task<VehiculoDTO> Get(int id);
        public Task<IEnumerable<VehiculoDTO>> GetAll();
    }
}
