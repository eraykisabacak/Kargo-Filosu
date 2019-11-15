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
        private byte speed;
        public string Marka;

        public CargoVehicle(string Plaka,string Marka)
        {
            this.Plaka = Plaka;
            this.Marka = Marka;
        }

        public delegate void SpeedHandler(object source, EventArgs args);
        public event SpeedHandler SpeedExceeded;

        public byte Speed
        {
            get { return speed; }
            set
            {
                speed = value;

                if (SpeedExceeded != null && speed >= 110)
                    SpeedExceeded(this, EventArgs.Empty);
            }
        }
    }
}
