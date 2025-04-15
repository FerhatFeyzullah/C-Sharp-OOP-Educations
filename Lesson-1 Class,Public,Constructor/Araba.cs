using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Class_Public_Constructor
{
    internal class Araba
    {
        public int kapiSayisi;
        public string Renk;
        public string modeli;


        public Araba(int doorCount, string color, string model)
        {
            kapiSayisi = doorCount;
            modeli = model;
            Renk = color;
        }


        public void motoruCalisti()
        {
            Console.WriteLine("Motor Calisti");
        }

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapilar Kilitlendi");
        }

    }
}
