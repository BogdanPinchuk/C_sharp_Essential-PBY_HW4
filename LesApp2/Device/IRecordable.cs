using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2.Device
{
    /// <summary>
    /// Записувати
    /// </summary>
    interface IRecordable
    {
        /// <summary>
        /// Запуск запису
        /// </summary>
        void Record();
        /// <summary>
        /// Пауза
        /// </summary>
        void Pause();
        /// <summary>
        /// Завершити
        /// </summary>
        void Stop();
    }
}
