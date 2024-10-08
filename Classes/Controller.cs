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

            switch (choice)
            {
                case "1":
                    Console.Write("\nSkriv inn tittel: ");
                    string title = Console.ReadLine() ?? string.Empty;

                    Console.Write("Skriv inn år: ");
                    int year = int.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Skriv inn sjanger: ");
                    string genre = Console.ReadLine() ?? string.Empty;

                    Console.Write("Skriv inn utvikler: ");
                    string developer = Console.ReadLine() ?? string.Empty;

                    AddGame(title, year, genre, developer);
                    break;
                case "2":
                    _view.displayVideoGames();
                    break;
                
                case "3":
                    isRunning = false;
                    Console.WriteLine("\nAvslutter programmet..\n");
                    break;
                
                default:
                    Console.WriteLine("\nUgyldig valg, prøv igjen\n");
                    break;
            }
        }
    }
}