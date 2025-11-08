using System.Net.Http;

namespace SerialifColorApi
{
    public class SerialifColor
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://color.serialif.com";
        public SerialifColor()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetColor(string query)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{query}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
