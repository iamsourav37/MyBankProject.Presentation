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
        Console.WriteLine("Username: ");
        username = Console.ReadLine();

        if (!string.IsNullOrEmpty(username))
        {
            Console.WriteLine("Password: ");
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
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountMenu();
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
                        Console.WriteLine("Wrong Choice");
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

    /// <summary>
    /// This method is for Customer Menu
    /// </summary>
    static void CustomersMenu()
    {
        // declare a variable for choice
        int customersMenuChoice = -1;

        do
        {

            Console.WriteLine("\n::Customers Menu::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Update Customer");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. View Customer");
            Console.WriteLine("0. Back to main menu");

            Console.WriteLine("Enter Choice : ");
            customersMenuChoice = int.Parse(Console.ReadLine());

            switch (customersMenuChoice)
            {
                case 1: // Todo: add the customer
                    break;
                case 2: // Todo: update the customer
                    break;
                case 3: //Todo: delete the customer
                    break;
                case 4: //Todo: view customer
                    break;

            }

        } while (customersMenuChoice != 0);
    }

    static void AccountMenu()
    {
        Console.WriteLine("\n::Account Menu::");
        int accountMenuChoice = -1;

        do
        {
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Update Account");
            Console.WriteLine("3. Delete Account");
            Console.WriteLine("4. View Account");
            Console.WriteLine("0. Back to main menu");


            Console.WriteLine("Enter choice : ");
            accountMenuChoice = int.Parse(Console.ReadLine());

            switch (accountMenuChoice)
            {

            }

        } while (accountMenuChoice != 0);
    }
}