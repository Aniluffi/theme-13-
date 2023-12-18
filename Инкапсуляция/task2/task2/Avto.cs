using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Avto
    {
        string avto;
        string color;
        int skor;

        public int Skor 
        { get
            {
               return skor;
            }
          set
            {
                if (value >= 0 & value <= 120)
              
                    skor = value;
          
                
            } 
        }

        public void ShowIfo()
        {
            Console.WriteLine($"{avto}\n" +
                $"{color}\n" +
                $"{skor}\n");
        } 
    }
}
