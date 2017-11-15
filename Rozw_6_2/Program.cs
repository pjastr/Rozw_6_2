using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student("Jan", "Kowalski", 1, 2, 34567);
            Console.WriteLine(student1.ToString());


            Console.ReadKey();
        }
    }
}
