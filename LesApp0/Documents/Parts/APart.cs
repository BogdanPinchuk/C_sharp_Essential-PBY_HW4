using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Documents.Parts
{
    /// <summary>
    /// Частина документа
    /// </summary>
    abstract class APart
    {
        /// <summary>
        /// Вміст
        /// </summary>
        public abstract string Content { get; set; }

        /// <summary>
        /// Відобразити
        /// </summary>
        public abstract void Show();
    }
}
