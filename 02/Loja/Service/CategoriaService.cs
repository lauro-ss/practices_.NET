using Core;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class CategoriaService : ICategoria
    {

        private readonly LojaContext _dbContext;

        public CategoriaService(LojaContext lojaContext)
        {
            _dbContext = lojaContext;
        }
        public async Task<Categoria> Create(Categoria categoria)
        {
            await _dbContext.Categoria.AddAsync(categoria);
            await _dbContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<bool> Delete(int id)
        {
            Categoria categoria = await Get(id);
            _dbContext.Categoria.Remove(categoria);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Categoria> Edit(Categoria categoria, int id)
        {
            Categoria getedCategoria = await Get(id);
            getedCategoria = categoria;

            _dbContext.Categoria.Update(getedCategoria);
            await _dbContext.SaveChangesAsync();
            return getedCategoria;
        }

        public async Task<Categoria> Get(int id)
        {
            Categoria? categoria = await _dbContext.Categoria.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (categoria == null)
                throw new Exception($"Não existe categoria correspondente ao ID: {id}");

            return categoria;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _dbContext.Categoria.AsNoTracking().ToListAsync();
        }
    }
}
