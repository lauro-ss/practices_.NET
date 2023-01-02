using Core;
using Core.DTOs;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class ProdutoService : IProduto
    {
        private readonly LojaContext _dbContext;
        public ProdutoService(LojaContext lojaContext)
        {
            _dbContext = lojaContext;
        }

        public async Task<Produto> Create(Produto produto)
        {
            await _dbContext.Produto.AddAsync(produto);
            await _dbContext.SaveChangesAsync();
            return produto;
        }

        public async Task<bool> Delete(int id)
        {
            Produto produto = await Get(id);
            _dbContext.Produto.Remove(produto);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Produto> Edit(Produto produto, int id)
        {
            Produto getedProduto = await Get(id);
            getedProduto = produto;

            _dbContext.Produto.Update(getedProduto);
            await _dbContext.SaveChangesAsync();
            return getedProduto;
        }

        public async Task<Produto> Get(int id)
        {
            Produto? produto = await _dbContext.Produto.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (produto == null)
                throw new Exception($"Não existe produto correspondente ao ID: {id}");

            return produto;
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _dbContext.Produto.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ProdutoDTO>> GetAllDTO()
        {
            var query = from produto in _dbContext.Produto
                        select new ProdutoDTO
                        {
                            Id = produto.Id,
                            Nome = produto.Nome,
                            Valor = produto.Valor,
                            Status = produto.Status,
                            Quantidade = produto.Quantidade,
                            Categoria = produto.Categoria.Nome,
                            Subcategoria = produto.Subcategoria
                        };
            return await query.AsNoTracking().ToListAsync();
        }
    }
}
