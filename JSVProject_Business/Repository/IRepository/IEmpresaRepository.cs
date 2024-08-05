using JSVProject_Models;

namespace JSVProject_Business.Repository.IRepository
{
    public interface IEmpresaRepository
    {
        public Task<EmpresaDTO> Create(EmpresaDTO objDTO);
        public Task<EmpresaDTO> Update(EmpresaDTO objDTO);
        public Task<int> Delete(int id);
        public Task<EmpresaDTO> Get(int id);
        public Task<IEnumerable<EmpresaDTO>> GetAll();
    }
}
