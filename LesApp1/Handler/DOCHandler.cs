using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.Handler
{
    /// <summary>
    /// DOC обробка (untill 2007)
    /// </summary>
    class DOCHandler : AbstractHandler, IHandler
    {
        /// <summary>
        /// Відкнити файл
        /// </summary>
        public override void Open()
        {
            FileInfo file = new FileInfo(FileName);
            Console.WriteLine("\n\tВідкриття файлу:");
            ShowInfo("Directory: ", file.Directory.ToString());
            ShowInfo("Name: ", file.Name.Replace(file.Extension, ""));
            ShowInfo("Format of file: ", file.Extension);
            ShowInfo("Size of file: ", file.Length.ToString());
            ShowInfo("Date of create: ", file.CreationTime.ToString());
            ShowInfo("Class: ", this.ToString());
            Console.WriteLine();

        }
        /// <summary>
        /// Створити файл
        /// </summary>
        public override void Create()
        {
            Console.Write($"\n\tФайл {FileName} створено в форматі *.txt.");
            ShowInfo("Class: ", this.ToString());
        }
        /// <summary>
        /// Редагувати файл
        /// </summary>
        public override void Change()
        {
            Console.Write($"\n\tФайл {FileName} відредаговано.");
            ShowInfo("Class: ", this.ToString());
        }
        /// <summary>
        /// Зберегти файл
        /// </summary>
        public override void Save()
        {
            Console.Write($"\n\tФайл {FileName} збережено в форматі *.txt.");
            ShowInfo("Class: ", this.ToString());
        }
        /// <summary>
        /// Видалити файл
        /// </summary>
        public override void Delete()
        {
            Console.Write($"\n\tФайл {FileName} видалено.");
            ShowInfo("Class: ", this.ToString());
        }
    }
}
