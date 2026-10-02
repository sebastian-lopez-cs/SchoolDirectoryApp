using SchoolDirectoryApp.Models;
using System.Net.Http.Json;

namespace SchoolDirectoryApp.Services
{
    public class SchoolService
    {
        private readonly HttpClient _httpClient;

        public SchoolService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<School>> GetSchoolsAsync()
        {
            var schools = await _httpClient.GetFromJsonAsync<List<School>>(
                "https://edutots.net/api/school");

            return schools ?? new List<School>();
        }
    }
}