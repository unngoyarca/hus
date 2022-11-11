using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLageHus
{
    internal class LivingRom
    {
        public double Areal { get; set; }
        public int AntallVindu { get; set; }
        public List<Furniture> Furnitures { get; set; }

        public LivingRom(double areal, int antallVindu)
        {
            Areal = 20;
            AntallVindu = 4;
            Furnitures = new List<Furniture>();

        }

        public void AddNewForniture(string møblerNavn)
        {
            Furnitures.Add(new Furniture(møblerNavn));
        }
        public void ListAllForniture()
        {
            foreach(var furnit in Furnitures)
            {
                Console.WriteLine(furnit.MøblerNavn);
            }
        }
    }
}
