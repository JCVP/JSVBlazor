using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface ISiniestroRepository
    {
        public Task<SiniestroDTO> Create(SiniestroDTO objDTO);
        public Task<SiniestroDTO> Update(SiniestroDTO objDTO);
        public Task<int> Delete(int id);
        public Task<SiniestroDTO> Get(int id);
        public Task<IEnumerable<SiniestroDTO>> GetAll();
    }
}
