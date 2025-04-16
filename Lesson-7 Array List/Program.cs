using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();

            list.Add(54);
            list.Add("Ferhat");
            list.Add("Feyzullah");

            //list.Reverse();
            //list.Clear();
            //list.Contains(54);
            //int a = list.Count;
            //list.Insert(0, "HUHU");
            //int b = list.IndexOf(54);
            //list.Sort();
            //list.RemoveAt(0);
            //list.Remove(54);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
