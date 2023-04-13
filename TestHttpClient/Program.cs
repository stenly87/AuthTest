using System.Net;

public class Test
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        // после Bearer должен добавляться длинный ключ, ниже пример
        client.DefaultRequestHeaders.
            Add("Authorization",
            "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiMTQ4OCIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvdXNlcmRhdGEiOiIxMTU1MiIsImV4cCI6MTY3MzQwNTMwOSwiaXNzIjoiU2VydmVyIiwiYXVkIjoiVXNlciJ9.eQEd_9A5jOz7zktyJUmIfrEyblzxrW94B-zCUvarpZU");

        var test = await client.GetStringAsync("http://localhost:5263/api/Users");
        Console.Write(test); // it alive
    }
}