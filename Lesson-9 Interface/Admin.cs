using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Interface
{
    public class Admin : Login
    {

         public int Level { get; set; }
         public string UserName { get; set; }
         public string Password { get; set; }

        public Admin(int Seviye, string userN, string pass)
        {
            Level = Seviye;
            UserName = userN;
            Password = pass;
        }

    }
}
