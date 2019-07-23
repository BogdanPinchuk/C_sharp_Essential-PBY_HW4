using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2.Device
{
    /// <summary>
    /// Програвач/плеєр
    /// </summary>
    class Player : IPlayable, IRecordable
    {
        /// <summary>
        /// прапор для відтворення
        /// </summary>
        private bool play = true;
        /// <summary>
        /// прапор для запису
        /// </summary>
        private bool record = true;

        #region Грати
        /// <summary>
        /// Запуск відтворення
        /// </summary>
        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tНа програвачі почалося відтворення музики.");
            Console.ResetColor();
        }
        /// <summary>
        /// Пауза
        /// </summary>
        void IPlayable.Pause()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (play)
            {
                Console.WriteLine("\n\tПрогравач поставлено на паузу при відтворенні музики.");
            }
            else
            {
                Console.WriteLine("\n\tПрогравач знято з паузи для відтворення музики.");
            }
            Console.ResetColor();
            play = !play;
        }
        /// <summary>
        /// Зупинка
        /// </summary>
        void IPlayable.Stop()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tПрогравач завершив відтворенні музики.");
            Console.ResetColor();
        }
        #endregion

        #region Запис
        /// <summary>
        /// Запуск запису
        /// </summary>
        public void Record()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tНа програвачі почався запис музики.");
            Console.ResetColor();
        }
        /// <summary>
        /// Пауза
        /// </summary>
        void IRecordable.Pause()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (record)
            {
                Console.WriteLine("\n\tПрогравач поставлено на паузу при записі музики.");
            }
            else
            {
                Console.WriteLine("\n\tПрогравач знято з паузи для запису музики.");
            }
            Console.ResetColor();
            record = !record;
        }
        /// <summary>
        /// Зупинка
        /// </summary>
        void IRecordable.Stop()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tПрогравач завершив запис музики.");
            Console.ResetColor();
        }

        #endregion
    }
}
