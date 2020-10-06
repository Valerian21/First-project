using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace температура
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою температуру");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 37)
            {
                Console.WriteLine($"{name}, вам стоит сесть на больничный !!! ");
                Console.WriteLine("Введите число от 1 до 3, что бы узнать ваш диагноз.");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine(" Это всего лишь ОРВИ, вам повезло!");
                        break;
                    case 2:
                        Console.WriteLine("у вас ЗППП, очень жаль...");
                        break;
                    case 3:
                        Console.WriteLine("Coronavirus, здоровья погибшим!!!");
                        break;

                }

            }
            else
            {
                Console.WriteLine($"{name}, вы можете посещать занятия! ");
            }
            Console.ReadLine();

        }
    }
}
