using MauiRider.Shared.Interfaces;
using MauiRider.Shared.Models;
using Newtonsoft.Json;

namespace MauiRider.Shared.Services;

public class TodoLoader : ITodoLoader
{
    private readonly IHttpClientFactory _http;

    public TodoLoader(IHttpClientFactory http)
    {
        _http = http;
    }
    public async Task<List<Todo>> GetTodos()
    {
        var client = _http.CreateClient("Data");
        var response = await client.GetAsync("todos");
        if (response.IsSuccessStatusCode)
        {
            var raw = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<Todo>>(await response.Content.ReadAsStringAsync());
            if (data.Any())
            {
                return data;
            }
           
        }

        return new List<Todo>();

    }
}