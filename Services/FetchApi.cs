using System.Text.Json;

namespace wikiapp.Services
{
    public class FetchApi
    {
        public FetchApi() { }
        public async Task<Attributes> fetchAsync()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://dogapi.dog/api/v2/breeds");
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonSerializer.Deserialize<DataJson>(responseBody);
                    var responseData = new Attributes();
                    if (jsonObject != null && jsonObject.data != null)
                    {
                        responseData = jsonObject.data.FirstOrDefault().attributes;
                        return responseData;
                    }
                }
                catch (HttpRequestException e)
                {
                   
                }
            }
            return null;
        }
       
    }
}
