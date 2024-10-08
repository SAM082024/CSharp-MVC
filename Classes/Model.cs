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
            new() { Title = "Halo", Year = 2001, Genre = "First-Person-Shooter", Developer = "Bungie Studios"},
            new() { Title = "Assassin's Creed", Year = 2007, Genre = "Open World, Action", Developer = "Ubisoft Montreal"},
            new() { Title = "Quake", Year = 1996, Genre = "First-Person-Shooter, Action", Developer = "id Software"},
        };
    }
    public void AddGame(string title, int year, string genre, string developer)
    {
        Games.Add(new VideoGame { Title = title, Year = year, Genre = genre, Developer = developer});
    }
}