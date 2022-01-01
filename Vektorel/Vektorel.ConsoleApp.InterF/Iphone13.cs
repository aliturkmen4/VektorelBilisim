using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.InterF
{
    class Iphone13 : AIkıllıTelefon, ITelefon
       
    {
       
        public override string Arama()
        {
            Grup165.Marka = "Iphone";
            return "İphone Arama";
           
        }

        public override string Mesaj()
        {
            return "İphone Mesaj";
        }
    }
}
