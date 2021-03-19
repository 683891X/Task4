using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String username = "Magic";
            String password = "Number";
            String usernameInput;
            String passwordInput;

            Console.WriteLine("Please enter your username: ");
            usernameInput = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            passwordInput = Console.ReadLine();

            if(usernameInput == username){
                if(passwordInput == password){
                    Console.WriteLine("Login successful!");
                }else{
                    Console.WriteLine("Login unsuccessful");
                }
            }else{
                Console.WriteLine("Login unsuccessful");
            }
        }
    }
}
