using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface ILocalidadRepository
    {
        public Task<LocalidadDTO> Create(LocalidadDTO objDTO);
        public Task<LocalidadDTO> Update(LocalidadDTO objDTO);
        public Task<int> Delete(int id);
        public Task<LocalidadDTO> Get(int id);
        public Task<IEnumerable<LocalidadDTO>> GetAll();
    }
}
