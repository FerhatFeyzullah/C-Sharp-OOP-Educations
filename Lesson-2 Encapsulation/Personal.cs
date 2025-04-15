using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Encapsulation
{
    public class Personal
    {

        private string tc;

        public string id {


            get {
                return tc.Substring(0, 5)+"******";

            }


            set 
            {
                bool kontrol = false;
                if (value.Length == 11)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                        bool hata = char.IsNumber(value[i]);

                        if (hata)
                        {
                            //No Problem
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Girmis oldugunuz TC kimlik numarasinda gecersiz karakter algilandi.");
                    }
                    else
                    {
                        tc = value;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Girdiginiz TC Kimlik Numarasi 11 Haneli Degildi.");
                }
            }
        }
    }
}
