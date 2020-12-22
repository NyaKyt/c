using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class DiskPhone
    {
          public string number;
          
         public virtual void disk()
        {
            string chars = " 0 1 2 3 4 5 6 7 8 9 0";
            Console.WriteLine("Input phone number using {0} :", chars);
            number = Console.ReadLine();
        }
    }
}
