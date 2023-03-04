using System.Text.Json;

Setup();









void Setup()
{
    using var JsonFileReader = File.OpenText("movies.json");
    var result = JsonSerializer.Deserialize<Movie[]>(JsonFileReader.ReadToEnd(), new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });


    foreach (var item in result)
    {
        System.Console.WriteLine(item.Title);
    }
}