using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.InterF
{
   abstract class AIkıllıTelefon:ITelefon
    {
        public int Kamera { get; set; }
        public bool Dokunmatik { get; set; }
        public string IsletimSistemi { get; set; }
        public abstract string Arama();
        public abstract string Mesaj();
       
    }
}
