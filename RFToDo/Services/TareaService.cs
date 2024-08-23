using RFToDo.Models;
using System.Net.Http.Json;

namespace RFToDo.Services
{
    public class TareaService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<List<Tarea>> ObtenerTareasPorMeta(int id)
        {
            return await _httpClient.GetFromJsonAsync<List<Tarea>>($"Tareas/ObtenerTareasPorMeta/{id}") ?? [];
        }
        public async Task<HttpResponseMessage> GuardarTarea(Tarea nuevaTarea)
        {
            var result = await _httpClient.PostAsJsonAsync("Tareas/GuardarTarea", nuevaTarea);
            return result;
        }

        public async Task<HttpResponseMessage> EditarTarea(Tarea tarea)
        {
            return await _httpClient.PutAsJsonAsync($"Tareas/EditarTarea/{tarea.Id}", tarea);
        }

        public async Task<HttpResponseMessage> EliminarTareas(List<Tarea> tareas)
        {
            return await _httpClient.PostAsJsonAsync($"Tareas/EliminarTareas", tareas);
        }

        public async Task<HttpResponseMessage> CompletarTareas(List<Tarea> tareas)
        {
            return await _httpClient.PostAsJsonAsync($"Tareas/CompletarTareas", tareas);
        }
    }
}
