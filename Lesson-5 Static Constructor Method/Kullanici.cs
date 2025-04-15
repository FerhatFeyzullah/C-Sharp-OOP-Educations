using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Static_Consctructor_Method_Usage
{
    public class Kullanici
    {
        private int ID;
        private string firstName;
        private string lastName;

        private static int maas;


        //static yapici methodlar parametre almaz.
        //herhangi bir degiskenin yada property nin icinde kullanilabilmesi icin onunda ayni sekilde static olmasi gerekir
        //static yapici method bir defa cagirilir, classtan nesne uretmek gibi herseferinde tekrar kullanilmaz. bir defa calisir.
        //erisim beliryecisi olmaz
        //bir class ta bir static yapici metod olur
        static Kullanici()
        {
            maas = 5000;
        }

        public Kullanici(int no,string isim,string surName)
        {
            ID = no;
            firstName = isim;
            lastName = surName;
        }

        public void bilgileriGoster()
        {

            Console.WriteLine("ID: " + ID + "\nFirstName: " + firstName + "\nLastName: " + lastName + "\nMaas: " + maas);
        }
        public static void ZamVakti(int miktar)
        {
            Console.WriteLine("Zam Yapildi");
            Console.WriteLine("Guncel Maas: "+(maas+miktar));
        }

    }
}
