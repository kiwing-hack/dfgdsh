using System;

namespace sgktrash1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор V159.3");

            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какое действие вы хотите выполнить сэр?");
            var enter = Console.ReadKey();
            char enter_key = enter.KeyChar;
            Console.WriteLine("");


            if (enter_key == '+')
            {
                Console.WriteLine(a + b);
            }
            else if (enter_key == '-')
            {
                Console.WriteLine(a - b);
            }
            else if (enter_key == '*')
            {
                Console.WriteLine(a * b);
            }
            else if (enter_key == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("ti idiot? vvedi drugoe 4islo");
                }
                else
                {
                    Console.WriteLine(a / b);
                }
            }
            else
            {
                Console.WriteLine("Неверно выбрано действие");

            }
        }
    }
}
