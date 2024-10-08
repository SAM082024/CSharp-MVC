using System.Reflection;

public class VideoGame
{
    public string? Title { get; set; }
    public int Year { get; set; }
    public string? Genre { get; set; }
    public string? Developer { get; set; }
}

public class Model
{
    public List<VideoGame> Games { get; set; }

    public Model()
    {
        Games = new List<VideoGame>
        {
            new() { Title = "gameTitle", Year = 2000, Genre = "First-Person-Shooter", Developer = "gameDev"},
            new() { Title = "gameTitle", Year = 2000, Genre = "First-Person-Shooter", Developer = "gameDev"},
            new() { Title = "gameTitle", Year = 2000, Genre = "First-Person-Shooter", Developer = "gameDev"},
        };
    }
}