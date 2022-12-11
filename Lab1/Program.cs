using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Generator generator;
            Random random;

            Console.WriteLine("Игра 'Угадай число'!");
            while (true) 
            {
                Console.Write("Введите максимальное число: ");
                if (int.TryParse(Console.ReadLine(), out int max))
                {
                   
                    random = new Random();
                    var genNumber = random.Next(1, max);
                    generator = new Generator(genNumber); 
                }
                else
                {
                    throw new Exception("Некоректное число!");
                }

                for (int i = 0; i < 6; i++)
                {
                    Console.Write("Введите число: ");
                    if (int.TryParse(Console.ReadLine(), out int userInput))
                    {
                        generator.UserUpdate(userInput);
                        Console.WriteLine(generator.ReturnResult());
                        if (generator.GetSuccess())
                        {
                            Console.WriteLine("Угадал!");
                            break;
                        }
                    }
                }
            }

        }
    }
}
