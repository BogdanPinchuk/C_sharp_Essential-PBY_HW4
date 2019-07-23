using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://metanit.com/sharp/tutorial/3.26.php

namespace LesApp0.Documents.Parts
{
    /// <summary>
    /// Заголовок
    /// </summary>
    class Title : APart, IPart
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
            get { return content ?? "Заголовок відсутній"; }
            set { content = value; }
        }

        /// <summary>
        /// Виведення в консоль інформації
        /// </summary>
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
