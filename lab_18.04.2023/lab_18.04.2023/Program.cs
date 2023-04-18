using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        public static void MyThread(object x)
        {
            if(x is List<Person>)
            {
                foreach (var element in (List<Person>)x) Console.WriteLine(element);

            }
        }

        class Person
         {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            Thread tr1 = new Thread(new ParameterizedThreadStart(MyThread));

            List<Person> people = new List<Person>(new Person("Vlad", "Karl", 19));
        }
    }
}
