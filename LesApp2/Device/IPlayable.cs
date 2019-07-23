using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2.Device
{
    /// <summary>
    /// Грати
    /// </summary>
    interface IPlayable
    {
        /// <summary>
        /// Запуск відтворення
        /// </summary>
        void Play();
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
