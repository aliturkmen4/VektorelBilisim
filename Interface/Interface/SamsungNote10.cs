using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class SamsungNote10 : AIkıllıTelefon, ITelefon //önce kalıtım yaptığın class'ı sonra interface'i yaz!
    {
        public override string Arama()
        {
            return "Sam Arama";
        }

        public override string Mesaj()
        {
            return "Sam Mesaj";
        }
    }
}
