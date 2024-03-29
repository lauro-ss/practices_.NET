﻿using Core;
using Core.DTOs;

namespace View.Service.Interfaces
{
    public interface IProdutoService
    {
        Task<Produto> Get(int id);
        Task<IEnumerable<Produto>> GetAll();
        Task<IEnumerable<ProdutoDTO>> GetAllDTO();
        Task<Produto> Create(Produto produto);
        Task<Produto> Edit(Produto produto);
        Task<bool> Delete(int id);
    }
}
