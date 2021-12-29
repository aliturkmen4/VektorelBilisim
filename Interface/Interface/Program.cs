using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //intarface tamamen soyut bir yapıdır.(içerisinde metot gövdesi olmayan)
            //nesnesini oluşturamazsın!
            //bir sınıf birden fazla interface kullanabilir!
            //interface kalıtılmaz uygulanır!
            //interface uygulayan sınıf interface içindeki yapıları içerisinde barındırmak zorundadır!
            Iphone13 ip = new Iphone13();
            SamsungNote10 sam = new SamsungNote10();
            
            ITelefon[] telefon = new ITelefon[2];
            telefon[0] = ip;
            telefon[1] = sam;
            foreach (ITelefon item in telefon)
            {
                Console.WriteLine(item.Arama());
                
            }
            Console.ReadLine();

        }
    }
}
