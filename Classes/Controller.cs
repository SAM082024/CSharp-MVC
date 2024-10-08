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
    
    public void Run()
    {
        bool isRunning = true;
        
        while (isRunning)
        {
            Console.WriteLine("Velkommen til Video Game Manager");
            Console.WriteLine("1. Legg til nytt spill");
            Console.WriteLine("2. Vis alle spill");
            Console.WriteLine("3. Avslutt");
            Console.Write("\nVelg et alternativ, 1-3: \n");

            string? choice = Console.ReadLine();

        }
    }
}