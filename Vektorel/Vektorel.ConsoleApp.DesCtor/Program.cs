using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vektorel.ConsoleApp.DesCtor
{
    class Program
    {
        static void Main(string[] args)
        {
            //X();
            //GC.Collect();
         
            int sayi = 50;
            while (sayi>=1)
            {
                new MyClass1(sayi--);
                Thread.Sleep(500);
            }
            Console.WriteLine("------------------");
            GC.Collect();
            Console.ReadLine();
        }
        static void X()
        {
            MyClass my = new MyClass();
        }

    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Nesne Üretildi");
        }
        ~MyClass()
        {
            Console.WriteLine("Nesne imha ediliyor..");
        }
    }
    class MyClass1
    {
        int no;
        public MyClass1(int no)
        {
            this.no = no;
            Console.WriteLine($"{no} nesnesi üretildi... ");
        }
        ~MyClass1()
        {
            Console.WriteLine($"{no} nesnesi imha edilmiştir... ");
        }
    }
   
}
