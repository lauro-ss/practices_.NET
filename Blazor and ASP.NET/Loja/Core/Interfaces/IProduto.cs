using Core.DTOs;

namespace Core.Interfaces
{
    public interface IProduto
    {
        Task<Produto> Get(int id);
        Task<IEnumerable<Produto>> GetAll();
        Task<IEnumerable<ProdutoDTO>> GetAllDTO();
        Task<Produto> Create(Produto produto);
        Task<Produto> Edit(Produto produto, int id);
        Task<bool> Delete(int id);
    }
}
