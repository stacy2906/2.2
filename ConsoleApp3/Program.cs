using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. создать объект базового класса и обратиться к методу вывода состояния объекта базового класса;
            Press press = new Press(1000, "Phantom of the opera", 5000);
            press.Output();

            // 2. создать объект производного класса и обратиться к методу вывода информации о сотруднике производного класса;
             Magazine magazine = new Magazine(500, "It", "high", 3000);
            magazine.Output();
            Console.WriteLine($"Cost: {magazine.Cost()}");

            // 3. создать ссылку типа базового класса на объект производного класса и обратиться к методу вывода состояния объекта базового класса
            Press magazineAsPress = new Magazine(800, "Death Note", "low", 3040);
            magazineAsPress.Output();
            Console.ReadKey();
        }
    }
}
