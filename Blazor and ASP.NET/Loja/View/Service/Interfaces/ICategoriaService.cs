using Core;

namespace View.Service.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> Get();
    }
}
