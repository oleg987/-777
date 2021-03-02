using System;

namespace Казино_777
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дабро пожаловать в Казино 777)");
            Console.WriteLine("\nНапишите ваше Имя");
            string ima = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Напишите возраст");

            int a;

            a = int.Parse(Console.ReadLine());
            Console.Clear();

            if (a < 18)
            {
                Console.WriteLine("Лица до 18 лет к игре не допускаются!");
            }
            else
            {
                Console.WriteLine("Введите размер ставки(от 1 до 1000)");
            }
            
            int c;
            c = int.Parse(Console.ReadLine());

            Random r = new Random();
            if (c < 500)
            {
                int num = r.Next(1500);
                Console.Clear();

                if (num == 100)
                {
                    Console.WriteLine($"111\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 200)
                {
                    Console.WriteLine($"222\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 300)
                {
                    Console.WriteLine($"333\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 400)
                {
                    Console.WriteLine($"444\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 500)
                {
                    Console.WriteLine($"555\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 600)
                {
                    Console.WriteLine($"666\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 1500)
                {
                    Console.WriteLine($"777\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 800)
                {
                    Console.WriteLine($"888\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else if (num == 900)
                {
                    Console.WriteLine($"999\n\nУху! {ima} Вы выйграли!!!!!!");
                }
                else
                {
                    Console.WriteLine("К сожелению вы проиграли!");
                }
            }
            else if (c > 500)
            {
                int num = r.Next(150);
                Console.Clear();

                if (num == 10)
                {
                    Console.WriteLine($"011\nУху!");
                }
                else if (num == 20)
                {
                    Console.WriteLine($"822\nУху!");
                }
                else if (num == 30)
                {
                    Console.WriteLine($"334\nУху!");
                }
                else if (num == 40)
                {
                    Console.WriteLine($"044\nУху!");
                }
                else if (num == 50)
                {
                    Console.WriteLine($"044\nУху!");
                }
                else if (num == 60)
                {
                    Console.WriteLine($"044\nУху!");
                }
                else if (num == 150)
                {
                    Console.WriteLine($"044\nУху!");
                }
                else if (num == 80)
                {
                    Console.WriteLine($"044\nУху!");
                }
                else if (num == 90)
                {
                    Console.WriteLine($"044\nУху!");
                }
                else
                {
                    Console.WriteLine("К сожелению вы проиграли!");
                }
            }




        }
    }
}
