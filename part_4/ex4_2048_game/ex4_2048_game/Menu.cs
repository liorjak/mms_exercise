using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex4_2048_game;

namespace ex4_2048_game
{
    class Menu
    {
        public void PrintMenu()
        {
            Console.WriteLine("WELCOME!!");
            Console.WriteLine("The Option Directions..");
            Console.WriteLine("0 - Left");
            Console.WriteLine("1 - Right");
            Console.WriteLine("2 - Up");
            Console.WriteLine("3 - Down");
            Console.WriteLine("Plase select your direction: ");
        }

        public int GetUserChoice()
        {
            PrintMenu();
            int direction;
            direction = Convert.ToInt32(Console.ReadLine());
            return direction;
        }
    }
}
