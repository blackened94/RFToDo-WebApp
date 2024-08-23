using RFToDo.Models;
using System.Net.Http.Json;

namespace RFToDo.Services
{
    public class MetaService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<List<Meta>> ObtenerMetas()
        {
             return await _httpClient.GetFromJsonAsync<List<Meta>>("Metas/ObtenerMetas") ?? [];
        }

        public async Task<HttpResponseMessage> GuardarMeta(Meta nuevaMeta)
        {
            var result = await _httpClient.PostAsJsonAsync("Metas/GuardarMeta", nuevaMeta);
            return result;
        }

        public async Task<HttpResponseMessage> EditarMeta(Meta meta)
        {
            return await _httpClient.PutAsJsonAsync($"Metas/EditarMeta/{meta.Id}", meta);
        }

        public async Task<HttpResponseMessage> EliminarMeta(int id)
        {
            return await _httpClient.DeleteAsync($"Metas/EliminarMeta/{id}");
        }
    }
}
