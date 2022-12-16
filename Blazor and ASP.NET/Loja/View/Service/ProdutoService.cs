using Core;
using System.Net.Http.Json;
using View.Service.Interfaces;

namespace View.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly HttpClient _httpClient;

        public ProdutoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Produto> Create(Produto produto)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/produto/", produto);
            return await response.Content.ReadFromJsonAsync<Produto>();
        }

        public async Task<bool> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/produto/{id}");
            return await response.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<Produto> Edit(Produto produto)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/produto/{produto.Id}", produto);
            return await response.Content.ReadFromJsonAsync<Produto>();
        }

        public async Task<Produto> Get(int id)
        {
            return await _httpClient.GetFromJsonAsync<Produto>($"/api/produto/{id}");
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Produto>>("/api/produto");
        }
    }
}
