using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Static_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Metot static olarak belirlendiginde bulundugu class tan nesne olusturmaya gerek kalmadan
            direkt metot cagrisi yapilabilir
            */
            Personal.Hesapla(54, 61);

        }
    }
}
