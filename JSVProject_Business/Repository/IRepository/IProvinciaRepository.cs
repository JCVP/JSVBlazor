using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface IProvinciaRepository
    {
        public Task<ProvinciaDTO> Create(ProvinciaDTO objDTO);
        public Task<ProvinciaDTO> Update(ProvinciaDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ProvinciaDTO> Get(int id);
        public Task<IEnumerable<ProvinciaDTO>> GetAll();
    }
}