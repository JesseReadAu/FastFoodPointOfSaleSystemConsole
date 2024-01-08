namespace Program;

internal class Program
{
    private static string companyName = "Null Company";
    public static string input = "";

    public static void Main(string[] args)
    {
        MainMenu();

        
    }

    private static void MainMenu()
    {

        Title("Main Menu");
        Console.WriteLine("1. Sales Menu\n" +
            "2. Sales Options\n" +
            "3. Employee Options\n" +
            "4. Reports\n" +
            "5. Administration\n" +
            "9. Exit Application\n");

        input = Console.ReadLine();
        Console.Clear();

        if (ValidateMenuInput(input)) //Method used over Parse in case verification is expanded on in future.
        {

            //Switch
            switch(int.Parse(input))
            {
                case(1):
                    SalesSelection();
                    return;
                case(2):
                    Console.WriteLine("ss");
                    return;
                case(3):
                    Console.WriteLine("ss");
                    return;
                case(4):
                    Console.WriteLine("ss");
                    return;
                case(5):
                    Console.WriteLine("ss");
                    return;
                case(9):
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine($"{input} is an invalid number selection, please choose again.\n");
                    MainMenu();
                    break;
            }
        }
        else
        {
            Console.WriteLine($"{input} is an invalid selection, please select a valid number.\n");
            MainMenu();
        }

    }
    
    // Create Dashes equal to length of string
    private static string WriteDashes(string textToDash)
    {
        string dashes = "";

        for (int i = 0; i < textToDash.Length; i++)
            dashes += "-";

        return dashes;
    }

    public static bool ValidateMenuInput(string input)
    {
        try
        {
            int.Parse(input);
            return true;
        }
        catch(Exception ex)
        {
            return false; 
        }
    }

    public static void Title(string pageTitle)
    {
        string title = $"{pageTitle} - {companyName}";
        Console.WriteLine($"{title}\n" + WriteDashes(title));
    }

    public static void SalesSelection()
    {
        Console.Clear();
        Console.WriteLine("Sales Selection Screen");
    }
}