using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.Handler
{
    /// <summary>
    /// Абстрактний клас обробника
    /// </summary>
    abstract class AbstractHandler
    {
        /// <summary>
        /// Ім'я файлу
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Відкнити файл
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// Створити файл
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Редагувати файл
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Зберегти файл
        /// </summary>
        public abstract void Save();
        /// <summary>
        /// Видалити файл
        /// </summary>
        public abstract void Delete();

        /// <summary>
        /// Форматований вивід інформації
        /// </summary>
        /// <param name="property">Характеристика</param>
        /// <param name="res">Значення</param>
        public void ShowInfo(string property, string res)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\t" + property);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(res);
            Console.ResetColor();
        }

    }
}
