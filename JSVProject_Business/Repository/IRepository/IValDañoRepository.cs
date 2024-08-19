using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface IValDañoRepository
    {
        public Task<ValDañoDTO> Create(ValDañoDTO objDTO);
        public Task<ValDañoDTO> Update(ValDañoDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ValDañoDTO> Get(int id);
        public Task<IEnumerable<ValDañoDTO>> GetAll();
    }
}
