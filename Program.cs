
using System.Text;
using System.Text.Json;

Setup();

var movie = Setup();
var s = HtmlTabloOlustur(movie);

File.WriteAllText("output.html", s.ToString());

StringBuilder HtmlTabloOlustur(List<Movie> movie)
{
    var htmlNesne = new StringBuilder();
    htmlNesne.Append("<table>\n");
    htmlNesne.Append("\t<th>\n");
    htmlNesne.Append("\t\t<tr>\n");
    htmlNesne.Append("\t\t\t<td>id</td>\n");
    htmlNesne.Append("\t\t\t<td>title</td>\n");
    htmlNesne.Append("\t\t\t<td>rating</td>\n");
    htmlNesne.Append("\t\t\t<td>genre</td>\n");
    htmlNesne.Append("\t\t\t<td>duration</td>\n");
    htmlNesne.Append("\t\t<tr>\n");
    htmlNesne.Append("\t<th>\n");
    htmlNesne.Append("\t<tbody>\n");
    foreach (var item in movie)
    {
        htmlNesne.Append("\t\t<tr>\n");
        htmlNesne.Append($"\t\t\t<td>{item.Id}</td>\n");
        htmlNesne.Append($"\t\t\t<td>{item.Title}</td>\n");
        htmlNesne.Append($"\t\t\t<td>{item.Rating}</td>\n");
        htmlNesne.Append($"\t\t\t<td>{item.Genre}</td>\n");
        htmlNesne.Append($"\t\t\t<td>{item.Duration}</td>\n");
        htmlNesne.Append("\t\t<tr>\n");
    }
    htmlNesne.Append("\t<tbody>\n");
    htmlNesne.Append("<table>");
    return htmlNesne;
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