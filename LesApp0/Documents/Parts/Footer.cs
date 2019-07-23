using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Documents.Parts
{
    /// <summary>
    /// Колонтікул
    /// </summary>
    class Footer : APart, IPart
    {
        /// <summary>
        /// Вміст
        /// </summary>
        private string content;

        /// <summary>
        /// Вміст
        /// </summary>
        public override string Content
        {
            get { return content ?? "Нижній колонтикул відсутній."; }
            set { content = value; }
        }

        /// <summary>
        /// Виведення в консоль інформації
        /// </summary>
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
