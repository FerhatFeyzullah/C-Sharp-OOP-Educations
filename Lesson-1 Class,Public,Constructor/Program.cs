using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Class_Public_Constructor
{
    internal class Program
    {
        
          static void Main(string[] args)
            {
                int number;

                Student ogrenci1 = new Student(54, "Ferhat", "Feyzullah", 60, 70, 80, "Anadolu Universitesi");
                Console.WriteLine("\n1-Ogrenci Bigilerini Goster\n2-Ogrenci Ortalamasi Goster\n3-Ogrenci Okulunu Goster\n4-Cikis Yap\n\n\n");
                Console.WriteLine("Lutfen Bir Sayi Giriniz:");
                number = Convert.ToInt32(Console.ReadLine());


                switch (number)
                {
                    case 1:
                        ogrenci1.ogrenciBilgileriGoster();
                        return;
                    case 2:
                        ogrenci1.ogrenciOrtalamaBul();
                        break;
                    case 3:
                        ogrenci1.okulIsmiGetir();
                        break;
                    case 4:
                        ogrenci1.cikisYap();
                        break;
                    default:
                        ogrenci1.cikisYap();
                        break;


                }

            }
        

    }
}
