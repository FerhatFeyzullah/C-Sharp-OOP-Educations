using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    public static class Musteri
    {
        //Static Classlardan Nesne Olusturulmaz.
        //Static classlarin icinde static olmayan bir sey tanimlanmaz



        
        public static int id;
        public static string name;

        static Musteri()
        {
            id = 54;
            name = "Ferhat";
        }

        public static void huhu()
        {
            Console.WriteLine("The Name Is: "+name+"\nHis ID: "+id);
        }


    }
}
