using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoAraci
{
    public class CargoVehicle
    {
        public string Plaka;
        public byte Speed;
        public string Marka;

        public CargoVehicle(string Plaka,string Marka)
        {
            this.Plaka = Plaka;
            this.Marka = Marka;
        }

        public delegate void SpeedHandler();
        public event SpeedHandler SpeedExceeded;

        public void kargo_aracı_SpeedExceeded()
        {
            if(Speed >= 110)
            {
                Console.WriteLine("Alarm: {0} plakalı {1} marka kargo aracı hız limitini aştı. {2} anındaki hızı: {3}",
                                    Plaka, Marka, DateTime.Now, Speed);
            }
        }
    }
}
