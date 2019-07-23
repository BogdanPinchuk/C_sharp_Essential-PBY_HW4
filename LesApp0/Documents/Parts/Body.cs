using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Documents.Parts
{
    /// <summary>
    /// Тіло документа
    /// </summary>
    class Body : APart, IPart
    {
        /// <summary>
        /// Вміст
        /// </summary>
        string content;

        /// <summary>
        /// Вміст
        /// </summary>
        public override string Content
        {
            get { return content ?? "Тіло документа відсутнє."; }
            set { content = value; }
        }

        /// <summary>
        /// Виведення в консоль інформації
        /// </summary>
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
