using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Person
    {
        public int Id { get; set; }
    }

    public class PersonGeneric<T> //id yi sayı da alabileyim string de duruma göre o yüzden generic yaptım. T:Type(standartlaşmış)
    {
        public T Id { get; set; }
    }
}
