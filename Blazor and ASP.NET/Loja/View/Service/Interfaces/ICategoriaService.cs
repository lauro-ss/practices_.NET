using Core;

namespace View.Service.Interfaces
{
    public interface ICategoriaService
    {
        Task<Categoria> Get(int id);
        Task<IEnumerable<Categoria>> GetAll();
        Task<Categoria> Create(Categoria categoria);
        Task<Categoria> Edit(Categoria categoria);
        Task<bool> Delete(int id);
    }
}
