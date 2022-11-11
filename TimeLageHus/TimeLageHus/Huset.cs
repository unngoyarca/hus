using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeLageHus;

namespace TimeLageHus
{
    internal class Huset
    {
        public LivingRom Livingrom { get; set; }
        //public Kitchen Kitchen { get; set; }
        //public BedRom BedRom { get; set; }
        //public BadRom BadRom { get; set; }
        //public HobbyRom HobbyRom { get; set; }

        public Huset()
        {
            Livingrom = new LivingRom(20, 4);
            //Kitchen = kitchen;
            //BedRom = bedRom;
            //BadRom = badRom;
            //HobbyRom = hobbyRom;

        }

        public void doorOpen()
        {
            Console.Write("Welcome to my house!");
            Console.WriteLine("This is my livingroom ");
            Console.WriteLine(Livingrom.Areal);
            Console.WriteLine("My living room have " + Livingrom.AntallVindu + " windows!");
            //Console.WriteLine("In my livingroom i have " + );


            var stue = new LivingRom(20, 4);
            var isAdding = true;

            while (isAdding)
            {
                Console.WriteLine("Do you want to add new Furnitures? Y/N");
                var response = Console.ReadLine();
                if (response.ToLower() == "n") isAdding = false;

                Console.WriteLine("Add new furniture: ");
                var furnitureName = Console.ReadLine();

                stue.AddNewForniture(furnitureName);
                stue.ListAllForniture();
                
                
            }
            
        }


    }
}
