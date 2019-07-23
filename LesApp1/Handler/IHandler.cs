using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1.Handler
{
    /// <summary>
    /// Інтерфейс обробника
    /// </summary>
    interface IHandler
    {
        /// <summary>
        /// Ім'я файлу
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// Відкнити файл
        /// </summary>
        void Open();
        /// <summary>
        /// Створити файл
        /// </summary>
        void Create();
        /// <summary>
        /// Редагувати файл
        /// </summary>
        void Change();
        /// <summary>
        /// Зберегти файл
        /// </summary>
        void Save();
        /// <summary>
        /// Видалити файл
        /// </summary>
        void Delete();
    }
}
