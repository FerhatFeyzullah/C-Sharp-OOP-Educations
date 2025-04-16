using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Inheritance___Polymorphism
{
    public class Hayvan
    {
        public string hayvanIsmi;
        public string hayvanCinsiyet;
        public int hayvanYasi;
        public string hayvanRenk;

        // virtual eklemesi ile varis class bu metotu kendine gore degistirebilir olur
        public virtual void bilgileriGoster()
        {
            Console.WriteLine("Burasi Hayvan Class: ");
            Console.WriteLine("Hayvan Ismi: "+hayvanIsmi);
            Console.WriteLine("Hayvan Cinsiyeti: "+hayvanCinsiyet);
            Console.WriteLine("Hayvan Yasi: "+hayvanYasi);

        }


    }
}
