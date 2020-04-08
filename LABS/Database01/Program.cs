
using System;
namespace Database01
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            string console = "";
            
            do
            {
                console = Util.GetConsole();
                Console.WriteLine(console);
                int.TryParse(Console.ReadLine(), out userChoice);
                if (userChoice == 0)
                    Util.ReconstituteDatabase();
                else if (userChoice == 1)
                {
                    Util.EnterNewUser();
                    
                }
                else if (userChoice == 2)
                    Util.AuthenticateUser();
                else if (userChoice == 3)
                    Util.ChangePassword();
                else if (userChoice == 4)
                    Util.DeleteUser();
                else if (userChoice == 5)
                    Util.DisplayUsers();
                else if (userChoice == 9)
                {
                    Environment.Exit(0);
                    
                }
                else
                    Console.WriteLine("Invalid choice, please try again."); 
               
            } while (userChoice != 9);
          
        }
    }
}
