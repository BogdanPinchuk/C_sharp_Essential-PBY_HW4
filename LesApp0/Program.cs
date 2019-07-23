using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document = LesApp0.Documents.Document;
using Title = LesApp0.Documents.Parts.Title;
using Body = LesApp0.Documents.Parts.Body;
using Footer = LesApp0.Documents.Parts.Footer;
using APart = LesApp0.Documents.Parts.APart;
using IPart = LesApp0.Documents.Parts.IPart;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Підклчюення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // структура документа
            //IPart[] parts = new IPart[]
            APart[] parts = new APart[]
            {
                 new Title
                 {
                     Content = "Контракт"
                 },
                 new Body
                 {
                    Content = "...\n\n...\n\n...\n\n" +
                    "Тело контракта" +
                    "\n\n...\n\n...\n\n..."
                 },
                 new Footer
                 {
                     Content = "Директор: Пінчук Б. Ю."
                 }
            };

            // створення документа
            Document document = new Document(parts);

            // виведення інформації
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
