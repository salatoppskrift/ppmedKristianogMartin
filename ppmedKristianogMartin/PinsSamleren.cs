using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppmedKristianogMartin
{
    internal class PinsSamleren
    {
        public string Name { get; set; }
        public double Wallet { get; set; }
        public int CarFuel { get; set; }
        public string BonusItem { get; set; }

        public List<Pins>Pins { get; set; }

        public PinsSamleren(string name, double wallet, int carFuel, string bonusItem, List<Pins> pins=null)
        {
            Name = name;
            Wallet = 0;    
            CarFuel = 500;
            BonusItem = bonusItem;
            this.Pins = pins ?? new List<Pins>();

        }

        


        






    }
}
