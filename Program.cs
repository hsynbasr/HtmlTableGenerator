
using System.Text;
using System.Text.Json;

Setup();

var movie = Setup();




string HtmlTabloOlustur(Movie movie)
{
    var sb = new StringBuilder();


    return "s";
}

static List<Movie> Setup()
{


    using var JsonFileReader = File.OpenText("movies.json");
    var result = JsonSerializer.Deserialize<List<Movie>>(JsonFileReader.ReadToEnd(), new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });
    return result;
}