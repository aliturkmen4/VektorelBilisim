using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.InterF
{
    class Nokia3310 : ITelefon,ITelefonProp
    {
        public int Agırlık { get; set; }
        public int Boyu { get; set; }
        public string Renk { get; set; }
        public string Arama()
        {
           return "Nok Arama";
        }

        public string Mesaj()
        {
            return "Nok Mesaj";
        }
    }
}
