using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Static_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personal p1 = new Personal();
            Console.WriteLine("Personal ID: "+p1.Id+ "\nPersonal Name: "+p1.firstName+"\nPersonal Surname: "+Personal.lastName);
            //son degiskeni static olarak belirledigim icin personal classindan nesne olusturmadan da 
            //kendisine ulasabildim.


        }
    }
}
