using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10__Abstract_Class
{
    public class Sql:Database
    {
        public override void delete()
        {
            Console.WriteLine("Deleted by Sql");
        }

    }
}
