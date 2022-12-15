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
            /*var options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                PropertyNameCaseInsensitive = true
            };*/

            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Categoria>>("/api/categoria");

            return result;
        }
    }
}
