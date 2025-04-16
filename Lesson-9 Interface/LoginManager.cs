using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Interface
{
    public class LoginManager
    {
        public void Eylem(Login login)
        {
            Console.WriteLine(login.UserName+" "+login.Password);
        }

    }
}
