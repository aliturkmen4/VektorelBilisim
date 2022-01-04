using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Konuanlatimi
            //int[] dizi = new int[3];
            //dizi[0] = 5;
            //dizi[1] = 15;
            //dizi[2] = 25;
            ////Diziler aynı tip verileri bir arada tutar.Koleksiyonalar farklı tipleri içinde barındırabilir.
            ////.Net Framework çatısı içinde kullandıkları kütüphaneler ---> using System.Collections.Generic & using System.Collections
            ////Collectionslar içine her tipi alabilidiği için tip güvenli değildir! 
            #endregion

            #region ArrayList
            //ArrayList arraylist = new  ArrayList();
            //arraylist.Add(5);
            //arraylist.Add("5");
            //arraylist.Add('5');
            //int toplam = 0;
            //foreach (var item in arraylist) //ArrayList verirsem muhakkak object döndüreceği için var veriyoruz(kendince ver dedik)!
            //{            
            //    toplam += Convert.ToInt32(item); //itemların tipleri farklı olduğu için toplayamam diye hata aldım!(o yüzden convert yap!)
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(toplam);
            //Console.WriteLine("-------------------");
            //ArrayList array = new ArrayList();
            //array.Add("Ali");
            //array.Add("Emin");
            //array.Add("Resul");
            //array.Add("Sinem");
            //array.Add("Şerif");
            //array.Add("Osman");
            //array.Add("Erdem");
            //Console.WriteLine(array[2]);
            //array.Remove("Ali");
            //Console.WriteLine(array[2]);
            //array.Remove("Sinem");
            //Console.WriteLine("-------------------");
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Hashtable
            //Hashtable has = new Hashtable();
            //has.Add(6, "Ankara"); //sol taraf key sağ taraf value
            //has.Add(7, "Antalya");
            //has.Add(26, "Eskişehir");
            //Console.WriteLine(has[26]); //kullanıcı soruyormuşcasına 26 nerenin plakası diye düşünür ve ekrana eskişehiri getirir.
            //Console.WriteLine("---------------");
            //foreach (DictionaryEntry item in has)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}
            //has.Remove(26); //key'i 26 olanı kaldırdı!
            //Console.WriteLine("---------------");
            //foreach (DictionaryEntry item in has)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //} 
            #endregion

            #region Queue
            //Queue queue = new Queue(); //ilk giren ilk çıkar
            //queue.Enqueue("ali"); //ekleme
            //queue.Enqueue("emin");
            //queue.Enqueue("resul");
            //queue.Enqueue("osman");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------");
            //queue.Dequeue(); //çıkarma(parametre almaz)
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------");
            //var a = queue.Peek();//ilk sıradakini gösterir
            //Console.WriteLine(a);
            //Console.WriteLine("---------------");
            //queue.Dequeue(); //çıkarma(parametre almaz)
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------");
            //var a1 = queue.Peek();//ilk sıradakini gösterir
            //Console.WriteLine(a1); 
            #endregion

            #region Stack
            //Stack stck = new Stack(); //son giren ilk çıkar
            //stck.Push(1); //ekleme
            //stck.Push(2);
            //stck.Push(3);
            //stck.Push(4);
            //foreach (var item in stck)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------");
            //stck.Pop();//silme
            //foreach (var item in stck)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------");
            //var a = stck.Peek(); //en baştakini verecek!
            //Console.WriteLine(a);
            //Console.WriteLine("--------------");
            //stck.Pop();//silme
            //foreach (var item in stck)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region SortedList
            //SortedList sd = new SortedList();
            //sd.Add(1, "Trabzonspor");//ekleme
            //sd.Add(2, "Konyaspor");
            //sd.Add(3, "Galatasaray");
            //sd.Add(4, "Fenerbahçe");
            //foreach (DictionaryEntry item in sd)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}
            //Console.WriteLine("-----------------");
            //sd.Remove(4);//key value'ya göre silme
            //foreach (DictionaryEntry item in sd)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            //Console.WriteLine("-----------------");
            //sd.RemoveAt(2);//indexe göre silme
            //foreach (DictionaryEntry item in sd)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //} 
            #endregion

            #region Yapıyatipzorunluluğuverme
            //Queue<int> qu = new Queue<int>(); //yapıya tip zorunluluğu getirdim! Aşağıda artık sadece int verebilirsin! (güvenlik açısından önemli!)
            //qu.Enqueue(54);
            //Stack<string> st = new Stack<string>(); //artık içine sadece string verebilirim!
            //st.Push("ali");
            //SortedList<int, string> stl = new SortedList<int, string>();
            //stl.Add(5, "ali"); 
            #endregion

            Person person = new Person();
            person.Id = 5;
            PersonGeneric<string> person1 = new PersonGeneric<string>(); //artık içine sadece string yazabiliyorum!
            //stringi istediğim türle değiştirip o türde değer verebilirim!
            person1.Id = "8";

            Console.WriteLine(person1.Id);
            Console.ReadLine();

        }
    }
}
