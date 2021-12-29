using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Iphone13 : AIkıllıTelefon, ITelefon
    {
        public override string Arama()
        {
            return "Ip Arama";
        }

        public override string Mesaj()
        {
            return "Ip Arama";
        }
    }
}
