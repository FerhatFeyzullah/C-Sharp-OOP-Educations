using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Inheritance___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kedi cat = new Kedi();

            cat.hayvanIsmi = "Kedi";
            cat.hayvanCinsiyet = "Disi";
            cat.hayvanYasi = 2;

            cat.bilgileriGoster();


            Hayvan hayvan = new Hayvan();
            hayvan.bilgileriGoster();
            
            //ayni fonksiyonlar cagirilip farkli islemler yaptirilmasi polymorphism
        }
    }
}
