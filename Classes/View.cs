public class View
{
    private Model myModel;

    public View(Model model)
    {
        myModel = model;
    }

    public void displayVideoGames()
    {
        Console.WriteLine("Video-Games in the model:\n");

        foreach (var VideoGame in myModel.Games)
        {
            Console.WriteLine($"Title: {VideoGame.Title}\n");
            Console.WriteLine($"Year: {VideoGame.Year}\n");
            Console.WriteLine($"Genre: {VideoGame.Genre}\n");
            Console.WriteLine($"Developers: {VideoGame.Developer}\n");
        }
    }
}