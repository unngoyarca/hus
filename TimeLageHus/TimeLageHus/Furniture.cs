using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLageHus
{
    internal class Furniture
    {
        public string MøblerNavn { get; set; }

        public Furniture(string møblerNavn)
        {
            MøblerNavn = møblerNavn;
        }
    }
}
