using System;
using System.Collections.Generic;

namespace ZNO_ukr
{
    internal class Nagolosi
    {
        public Nagolosi()
        {
        }

        public void Start()
        {
            var nagolosiSlova = new NagolosiSlova(default, default, default);
            nagolosiSlova.SpisokSlov();
            var Slova = nagolosiSlova.Slova;
            Screen(Slova);
        }

        
        public void Screen(List<NagolosiSlova> Slova)
        {
            while (true)
            {
                var index = new Random();
                var item = Slova[index.Next(Slova.Count)];
                /*
                Console.Clear();
                Console.WriteLine(item.Slovo);
                Console.WriteLine("Enter number: ");
                int.TryParse(Console.ReadLine(), out int key);
                Console.WriteLine();
                if (item.NumberSklada == key)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
                Console.WriteLine("Answer: " + item.Otvet);
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue, Escape for exit...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    var toStartMenu = new MainMenu();
                    toStartMenu.Start();
                    return;
                }
                */
            }
        }
    }
}