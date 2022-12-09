namespace Core.Interfaces
{
    public interface ICategoria
    {
        Task<Categoria> Get(int id);
        Task<IEnumerable<Categoria>> GetAll();
        Task<Categoria> Create(Categoria categoria);
        Task<Categoria> Edit(Categoria categoria, int id);
        Task<bool> Delete(int id);

    }
}
