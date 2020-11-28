using System;
using System.IO;
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
            Console.WriteLine("Введите данные Steam для обработки");
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
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Войдите повторно в систему");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Логин :");
                String LoginPro = Console.ReadLine();
                Console.WriteLine("Пароль :");
                String PasswordPro = Console.ReadLine();
                if (Login == LoginPro & Password == PasswordPro)
                {
                    
                    Console.WriteLine("Успешный вход в систему !");
                    break;   
                }
                else
                {
                    Console.WriteLine("А хуй тебе");
                    break;
               }
                
            }
            Console.ReadKey(true);

        }

    }
}