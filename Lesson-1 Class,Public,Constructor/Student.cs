using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Class_Public_Constructor
{
    

    public class Student
    {
        private int studentNo;
        private string name;
        private string lastName;
        private int vize_1;
        private int vize_2;
        private int final;
        private string schoolName;
        private int ortalama;

        public Student(int no, string isim, string soyIsim, int sinav_1, int sinav_2, int finaSinav, string okulIsim)
        {
            studentNo = no;
            name = isim;
            lastName = soyIsim;
            vize_1 = sinav_1;
            vize_2 = sinav_2;
            final = finaSinav;
            schoolName = okulIsim;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Ogrenci No: " + studentNo + "\nOgrenci Ismi: " + name + "\nOgrenci Soyismi: " + lastName);

        }
        public void ogrenciOrtalamaBul()
        {
            Console.WriteLine("Vize 1 Notu: " + vize_1 + "\nVize 2 Notu: " + vize_2 + "\nFinal Notu: " + final);
            ortalama = (vize_1 * 20 / 100) + (vize_2 * 20 / 100) + (final * 60 / 100);
            Console.WriteLine("Ogrencinin Not Ortalamasi: " + ortalama);
        }

        public void okulIsmiGetir()
        {
            Console.WriteLine("Ogrencini Okulunun Ismi: " + schoolName);
        }
        public void cikisYap()
        {
            Console.WriteLine("Cikis Yapildi");
        }


    }
}

