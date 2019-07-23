using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player = LesApp2.Device.Player;
using IPlayable = LesApp2.Device.IPlayable;
using IRecordable = LesApp2.Device.IRecordable;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення програвача
            Player player = new Player();

            // Запис звуку
            //IRecordable record = (IRecordable)player;
            IRecordable record = player as IRecordable;

            Console.WriteLine(new string('-', 80));
            // спочатку записуємо щось
            record.Record();
            record.Pause();     // тимчасова зупинка
            record.Pause();     // продовження
            record.Stop();

            Console.WriteLine("\n" + new string('-', 80));
            Console.WriteLine(new string('-', 80));

            // Відтворення звуку
            //IPlayable play = (IPlayable)player;
            IPlayable play = player as IPlayable;

            // далі прослуховумо те що записали
            play.Play();
            play.Pause();     // тимчасова зупинка
            play.Pause();     // продовження
            play.Stop();

            Console.WriteLine("\n" + new string('-', 80));

            // delay
            Console.ReadKey(true);
        }
    }
}
