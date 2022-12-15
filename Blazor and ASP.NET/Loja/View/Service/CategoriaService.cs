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

        public async Task<IEnumerable<Categoria>> Get()
        {
            var result = await _httpClient.GetFromJsonAsync<Categoria[]>("/api/categoria");
            return result;
        }
    }
}
