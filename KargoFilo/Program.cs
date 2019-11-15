using KargoAraci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KargoFilo
{
    class Program
    {
        static void Main(string[] args)
        {
            CargoVehicle kargo_araci1 = new CargoVehicle("42SU1975","Fiat");
            kargo_araci1.SpeedExceeded += new CargoVehicle.SpeedHandler(kargo_araci_SpeedExceeded);

            CargoVehicle kargo_araci2 = new CargoVehicle("37AEK37","BMW");
            kargo_araci2.SpeedExceeded += new CargoVehicle.SpeedHandler(kargo_araci_SpeedExceeded);
            byte j = 5;

            for (byte i = 80; i < 130; i += 5)
            {
                kargo_araci1.Speed = i;
                kargo_araci2.Speed = (byte)(i + j);
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine(kargo_araci1.Plaka + " plakalı aracın hızı = " + kargo_araci1.Speed);
                Console.WriteLine(kargo_araci2.Plaka + " plakalı aracın hızı = " + kargo_araci2.Speed + "\n");
                Thread.Sleep(1000);
            }

            void kargo_araci_SpeedExceeded(object source, EventArgs e)
            {
                CargoVehicle cargoVehicle = (CargoVehicle)source;
                Console.WriteLine("***************SpeedExceeded***************");
                Console.WriteLine("Alarm: \n" + cargoVehicle.Plaka + " Plakalı " + cargoVehicle.Marka + " Marka kargo aracı hız limitini aştı. \n" + DateTime.Now.ToString() + " anındaki hızı: " + cargoVehicle.Speed + "\n");
            }

            Console.ReadLine();
        }
    }
}
