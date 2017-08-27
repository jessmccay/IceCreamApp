using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ice cream app!");
            Console.WriteLine("Would you like to make an ice cream?");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.Write("What flavor of ice cream would you like?");
                string userColor = Console.ReadLine();
                IceCream usersIceCream = new IceCream(userColor);
                Console.WriteLine($"You created a {userColor} ice cream!");
                Console.Read();
            }
           
        }
    }
}
