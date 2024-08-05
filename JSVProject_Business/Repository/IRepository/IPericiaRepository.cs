using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface IPericiaRepository
    {
        public Task<PericiaDTO> Create(PericiaDTO objDTO);
        public Task<PericiaDTO> Update(PericiaDTO objDTO);
        public Task<int> Delete(int id);
        public Task<PericiaDTO> Get(int id);
        public Task<IEnumerable<PericiaDTO>> GetAll();
    }
}
