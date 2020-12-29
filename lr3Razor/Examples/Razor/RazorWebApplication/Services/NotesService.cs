using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using RazorWebApplication.Models;

namespace RazorWebApplication.Services
{
    public class NotesService : INotesService
    {
        private HttpClient HttpClient { get; }
        
        public NotesService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Notes>> GetNotes()
        {
            using var response = await this.HttpClient.GetAsync("Notes");

            response.EnsureSuccessStatusCode();
            
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<IEnumerable<Notes>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}