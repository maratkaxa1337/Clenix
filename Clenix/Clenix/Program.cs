﻿using System;
using System.Threading;

namespace Clenix
{
    class Program
    {
        public static void Main(string[] args)
        { 
            // Обычный диолог с пользователем
            Console.WriteLine("Привет пользователь нашего Clenix.com");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Введите свои стим данные");
            Console.WriteLine();
            Console.Write("Логин : ");
            String Login = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Пароль : ");
            String Password = Console.ReadLine();
            Console.WriteLine("Идет Обработка данных ");
            //Тут включается таймер которые делает фейковые загрузку
            //С помощью Thread.Sleep(тут скорость) 
            var thread = new Thread(() =>
            {
                
                for (int i = 0; i <= 100; i++)
                {
                    Console.SetCursorPosition(50, 50);
                    Console.WriteLine("Выполнено {0}%", i);
                    Thread.Sleep(50);
                }
            });
            thread.Start();
            thread.Join();
            Console.Clear();
            Console.SetCursorPosition(50, 50);
            Console.WriteLine("Обработка успешно прошла");
            Console.ReadKey();
            
        }

    }
}