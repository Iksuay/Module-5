/*
using System;

namespace Module_5
{
    internal class Application_5_2_2
    {
        public static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);


            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine("Ваши любимые цвета:");
            foreach (var Color in favcolors)
            {
                Console.WriteLine(Color);
            }

            static string ShowColor(string username, int userage)
            {

                Console.WriteLine("{0}, {1}, \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
                var colors = Console.ReadLine();

                switch (colors)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                return colors;
            }
        }
    }
}
*/