using Core;
using System.Net.Http.Json;
using View.Service.Interfaces;

namespace View.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClient _httpClient;

        public CategoriaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Categoria> Create(Categoria categoria)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/categoria/", categoria);
            return await response.Content.ReadFromJsonAsync<Categoria>();
        }

        public async Task<bool> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/categoria/{id}");
            return await response.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<Categoria> Edit(Categoria categoria)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/categoria/{categoria.Id}", categoria);
            return await response.Content.ReadFromJsonAsync<Categoria>();
        }

        public async Task<Categoria> Get(int id)
        {
            return await _httpClient.GetFromJsonAsync<Categoria>($"/api/categoria/{id}");
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Categoria>>("/api/categoria");
        }
    }
}
