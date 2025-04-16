using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10__Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //abstract class newlenmez varisi uzerinden nesne uretilebilir.
            
            Database database = new Sql();
            database.Add();
            database.delete();
            Database database2 = new Oracle();
            database2.Add();
            database2.delete();



        }

        

    }
}
