public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void AddGame(string title, int year, string genre, string developer)
    {
        _model.AddGame(title, year, genre, developer);
        Console.WriteLine("Game added successfully!");
    }
}