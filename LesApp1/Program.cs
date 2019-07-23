using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document = LesApp1.Document;
using AHandler = LesApp1.Handler.AbstractHandler;
using IHandler = LesApp1.Handler.IHandler;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Чистка консолі
            Console.Clear();

            // Введення інформації
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tВведіть назву файлу: ");
            Console.ResetColor();
            // назва файлу
            string fileName;
#if false    // якщо треба було ввести вручну
            string fileName = Console.ReadLine();
#endif
            // файл май бути в папці з програмою
            //fileName = "Noname.txt";
            //fileName = "Noname.xml";
            //fileName = "Noname.doc";
            fileName = "Noname.docx";
            Console.WriteLine(fileName);

            // а так як нычого не сказано про те, що користучай має
            // вводити якісь дані, то маємо право вручну продемонструвати
            // один із форматів

            // Передача імені в клас "документ" для аналізу
            AHandler instance = new Document(fileName).AnalyzeFile();
            IHandler ihandler = new Document(fileName).IAnalyzeFile();

            // виконання дій над файлом
#if false
            if (instance != null)
            {
                instance.Open();
                instance.Create();
                instance.Change();
                instance.Save();
                instance.Delete();
            }
#endif

            // Букви кольоровим  виводяться, так як це підтягується з абстрактного класу
            // в такому випадку абстрактний клас краще від інтерфесу, так як дозволяє
            // реалізувати і сховати спільну для всіх реалізацію
            if (ihandler != null)
            {
                ihandler.Open();
                ihandler.Create();
                ihandler.Change();
                ihandler.Save();
                ihandler.Delete();
            }
            //delay, якщо б було сказано, що користувач має керувати в процесі
            // то можна зациклити по аналогу методу Дейкстри
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
