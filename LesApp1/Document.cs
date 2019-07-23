using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHandler = LesApp1.Handler.AbstractHandler;
using XML = LesApp1.Handler.XMLHandler;
using TXT = LesApp1.Handler.TXTHandler;
using DOC = LesApp1.Handler.DOCHandler;
using DOCX = LesApp1.Handler.DOCXHandler;
using IHandler = LesApp1.Handler.IHandler;

namespace LesApp1
{
    /// <summary>
    /// Відкриває файл і визначає формат
    /// </summary>
    class Document
    {
        /// <summary>
        /// Ім'я документа
        /// </summary>
        private string FileName { get; set; } = string.Empty;

        /// <summary>
        /// Передача назви файлу
        /// </summary>
        /// <param name="fileName"></param>
        public Document(string fileName)
        {
            FileName = fileName;
        }

        /// <summary>
        /// Відкриття і аналіз файлу через абстрактний клас
        /// </summary>
        /// <returns></returns>
        public AHandler AnalyzeFile()
        {
            // https://metanit.com/sharp/tutorial/5.3.php
            // https://metanit.com/sharp/tutorial/5.4.php
            // збір інформації про файл
            FileInfo fileInfo = new FileInfo(FileName);

            // створення змінної для екземпляру
            AHandler handler;

            // створюєсо екземпляр відповідно до формату
            switch (fileInfo.Extension.Replace(".", "").ToLower())
            {
                case "xml":
                    handler = new XML();
                    break;
                case "txt":
                    handler = new TXT();
                    break;
                case "doc":
                    handler = new DOC();
                    break;
                case "docx":
                    handler = new DOCX();
                    break;
                default:
                    handler = null;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tНевідомий формат файла.");
                    Console.ResetColor();
                    break;
            }

            // передаємо назву файлу
            if (handler != null)
            {
                handler.FileName = FileName;
            }

            return handler;
        }
        /// <summary>
        /// Відкриття і аналіз файлу через інтерфейс
        /// </summary>
        /// <returns></returns>
        public IHandler IAnalyzeFile()
        {
            // збір інформації про файл
            FileInfo fileInfo = new FileInfo(FileName);

            // створення змінної для екземпляру
            IHandler handler;

            // створюєсо екземпляр відповідно до формату
            switch (fileInfo.Extension.Replace(".", "").ToLower())
            {
                case "xml":
                    handler = new XML();
                    break;
                case "txt":
                    handler = new TXT();
                    break;
                case "doc":
                    handler = new DOC();
                    break;
                case "docx":
                    handler = new DOCX();
                    break;
                default:
                    handler = null;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tНевідомий формат файла.");
                    Console.ResetColor();
                    break;
            }

            // передаємо назву файлу
            if (handler != null)
            {
                handler.FileName = FileName;
            }

            return handler;
        }

    }
}
/*
 * // відкриття файлу
            // перевірка наявності файлу
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Open))
                {
                    // можна було корегувати файл

                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\tФайл {FileName} не знайдено.");
                Console.ResetColor();
                return null;
            }
 * 
 * 
*/
