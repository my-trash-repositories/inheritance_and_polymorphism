using System;

namespace UserNameSpace
{
    class Program
    {
        private static Administrator admin;

        static void Main(string[] args)
        {
            welcome();
        }

        private static void welcome()
        {
            Console.WriteLine("\nWELCOME! WHAT WOULD YOU LIKE TO DO?\n");

            if (admin != null)
            {
                Console.WriteLine("1: Update Admin name");
                Console.WriteLine("2: Update Password");
                Console.WriteLine("3: Show Admin Details");
                Console.WriteLine("4: Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        updateAdminName();
                        break;
                    case "2":
                        updatePassword();
                        break;
                    case "3":
                        admin.showDetails();
                        welcome();
                        break;
                    case "4":
                        Console.WriteLine("BYE!\n\n");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        welcome();
                        break;
                }
            }
            else
            {
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1: create admin");
                Console.WriteLine("2: Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        createAdmin();
                        break;
                    case "2":
                        Console.WriteLine("BYE!\n\n");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        welcome();
                        break;
                }
            }

        }

        private static void createAdmin()
        {
            Console.WriteLine("Enter Admin name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Admin password");
            string password = Console.ReadLine();

            Console.WriteLine("Creating Admin");
            admin = new Administrator(name, "1", password);

            welcome();
        }

        private static void updatePassword()
        {
            Console.WriteLine("\nUPDATE PASSWORD");
            Console.WriteLine("Enter new password");
            string newPassword = Console.ReadLine();
            admin.updatePassword(newPassword);

            welcome();
        }

        private static void updateAdminName()
        {
            Console.WriteLine("\nUPDATE ADMIN NAME");
            Console.WriteLine("Enter new Name");
            string newAdminName = Console.ReadLine();
            admin.updateAdminName(newAdminName);

            welcome();
        }
    }
}
