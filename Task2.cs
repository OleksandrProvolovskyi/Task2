using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomNumber;
            int chosenNumber;
            randomNumber = rand.Next(100);

            Console.WriteLine($"{randomNumber}" + " " + "- це число обрала система (показано щоб довго не вгадувати, а побачити, що програма працює)");
            Console.WriteLine("Будь ласка, введіть Ваше число:");              

            do
            {
                chosenNumber = Convert.ToInt32(Console.ReadLine());   //перетворюємо вибране число в Integer
                if (randomNumber == chosenNumber)
                {
                    Console.WriteLine("Ви вгадали число!");
                }
                else if (randomNumber > chosenNumber)
                {
                    Console.WriteLine("Ваше число менше, оберіть нове");
                }

                else if (randomNumber < chosenNumber)
                {
                    Console.WriteLine("Ваше число більше, оберіть нове");
                }
            }
            while (true);
        }
    }
}
