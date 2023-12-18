using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    class Program
    {
        static void Main(string[]args)
        {
            short hdd = 120;
            Computer pc1 = new Computer("asus",hdd,0);
          

            
            pc1.ShowInf();
        }
    }
}
