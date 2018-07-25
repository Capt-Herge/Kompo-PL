using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic.Support
{
    public class Part
    {
        public int PkID { get; set; }
        public string Name { get; set; }
        public string Hersteller { get; set; }
        public string PN { get; set; }
        public string Beschreibung { get; set; }
        public double Preis { get; set; }
        public int Anzahl { get; set; }

    }
}
