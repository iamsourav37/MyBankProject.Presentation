using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        // display title
        System.Console.WriteLine("*********My Bank*********");
        System.Console.WriteLine("::Login Page::");

        // declaring the variable
        string username = null;
        string password = null;


        // read username and password from keyboard
        Console.WriteLine("Username:");
        username = Console.ReadLine();

        if (!string.IsNullOrEmpty(username))
        {
            password = Console.ReadLine();
        }

        if (username == "system" && password == "manager")
        {
            // declare a variable to store menu choice
            int mainMenuChoice = -1;
            do
            {

                Console.WriteLine("\n::Main Menu::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Account");
                Console.WriteLine("3. Fund Transfer");
                Console.WriteLine("4. Fund Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter Choice : ");
                //mainMenuChoice = Convert.ToInt32(Console.ReadLine()); // another way to convert to int
                mainMenuChoice = int.Parse(Console.ReadLine());


                // switch-case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1: // Todo: show customer menu
                        break;
                    case 2: // Todo: show account menu
                        break;
                    case 3: //Todo: show fund transfer menu
                        break;
                    case 4: // Todo: show fund transfer statement menu
                        break;
                    case 5: // Todo: show account statement menu
                        break;
                    case 0: // Todo : exit
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            } while (mainMenuChoice != 0);

        }
        else
        {
            Console.WriteLine("Invalid username and password.");
        }

        Console.WriteLine("Thank You. Visit Again.");
    }
}