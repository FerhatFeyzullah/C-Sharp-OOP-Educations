using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Interface
{
    public class Customer : Login
    {
        public int Id { get; set; }
        public string UserName { get ; set ; }
        public string Password { get ; set ; }

        public Customer(int id,string userN,string pass)
        {
            Id = id;
            UserName = userN;
            Password = pass;
        }
    }
}
