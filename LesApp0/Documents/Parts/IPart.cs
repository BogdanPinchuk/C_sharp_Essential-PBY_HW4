using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Documents.Parts
{
    /// <summary>
    /// Інтерфейс частин документа
    /// </summary>
    interface IPart
    {
        /// <summary>
        /// Вміст
        /// </summary>
        string Content { get; set; }

        /// <summary>
        /// Відобразити
        /// </summary>
        void Show();
    }
}
