using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOef
{
    class Persoon
    {
        public string VoorNaam { get; set; }
        public string Achternaam { get; set; }
        public override string ToString()
        {
            return VoorNaam + " " + Achternaam;
        }
    }
}
