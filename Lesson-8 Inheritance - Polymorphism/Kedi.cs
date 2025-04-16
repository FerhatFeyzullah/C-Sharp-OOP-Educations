using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Inheritance___Polymorphism
{
    public class Kedi : Hayvan
    {
        //Inheritance sayesinde Hayvan classindan miras alarak burayi bos birakiyorum

        public override void bilgileriGoster()
        {
            hayvanRenk = "Turuncu";
            Console.WriteLine("BUrasi Kedi Class");
            Console.WriteLine(hayvanRenk);
        }
    }
}
