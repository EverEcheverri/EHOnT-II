using Employees.Repository.Extensions;
using Employees.Repository.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Employees.Repository.Services
{
    internal class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _client;
        public HttpClientService()
        {
            _client = new HttpClient();
        }
        public async Task<T> GetAsync<T>(string url)
        {
            var response = await _client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            return json.FromJson<T>();
        }
    }
}
