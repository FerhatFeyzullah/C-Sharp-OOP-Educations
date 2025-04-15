using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Static_Consctructor_Method_Usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanici K1 = new Kullanici(54,"Ferhat","Feyzullah");

            K1.bilgileriGoster();
            Kullanici.ZamVakti(2340);



        }
    }
}
