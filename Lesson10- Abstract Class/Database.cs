using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10__Abstract_Class
{
    public abstract class Database
    {

        //Kendisini cagiran herkese ayni sekilde doner
        public void Add()
        {
            Console.WriteLine("Added by default.");
        }


        //abstract class lar ise cagiran kendine gore dondurur.
        //kendisini cagiricak class a mirasci olmasi gerekir
        public abstract void delete();
        

        

    }
}
