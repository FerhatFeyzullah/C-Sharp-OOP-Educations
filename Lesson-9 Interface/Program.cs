using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer C1 = new Customer(54,"Customer","custompass123");
            Admin admin = new Admin(3,"admin","admin123");

            LoginManager loginManager = new LoginManager();

            loginManager.Eylem(C1);
            loginManager.Eylem(admin);


        }
    }
}
