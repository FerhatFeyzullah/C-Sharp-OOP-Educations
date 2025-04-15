using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personal personal1 = new Personal();



            personal1.id = "12345678900";
            Console.WriteLine(personal1.id);
        }
    }
}
