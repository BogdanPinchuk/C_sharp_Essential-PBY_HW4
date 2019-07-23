using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Title = LesApp0.Documents.Parts.Title;
using Body = LesApp0.Documents.Parts.Body;
using Footer = LesApp0.Documents.Parts.Footer;
using APart = LesApp0.Documents.Parts.APart;
using IPart = LesApp0.Documents.Parts.IPart;

namespace LesApp0.Documents
{
    /// <summary>
    /// Документ
    /// </summary>
    class Document
    {
        readonly APart[] parts;
        readonly IPart[] iparts;

        public Document(params APart[] parts)
        {
            this.parts = parts;
            #region Old version
            // чомусь не працює
            //part = { title, body, footer };
            // парцює тільки так
            //part[0] = title;
            //part[1] = body;
            //part[2] = footer; 
            #endregion
        }

        public Document(params IPart[] iparts)
        {
            this.iparts = iparts;
        }

        /// <summary>
        /// Відображення інформації
        /// </summary>
        public void Show()
        {
            if (parts != null)
            {
                foreach (APart i in parts)
                {
                    i.Show();
                    Console.WriteLine();
                }
            }

            if (iparts != null)
            {
                foreach (IPart i in iparts)
                {
                    i.Show();
                    Console.WriteLine();
                }
            }
        }
    }
}
