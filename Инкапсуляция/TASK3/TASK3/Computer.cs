using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    class Computer
    {
        string model;
        short hdd;
        byte ozy;

        public short Hdd 
        {
            get => hdd;
            set
            {
                if (value >= 200 & value <= 2000) hdd = value;
                else if (value != 0 & value > 0) 
                {
                    hdd = value;
                    Console.WriteLine("Cслишком мало памяти на диске(");
                }
                   
                else Console.WriteLine("Диск не вставлен");
            }
        }
        public byte Ozy
        { get => ozy;
            set
            {
                if (value >= 2 & value <= 32) ozy = value;
                else if (value != 0 & value > 0)
                {
                    ozy = value;
                    Console.WriteLine("Cслишком мало памяти ОЗУ(");
                } 
                else Console.WriteLine("OЗУ не вставлена");
            }
        }

       public Computer()
        {

        }

        public Computer(string model,short hdd,byte ozy)
        {
            this.model = model;
            this.Hdd = hdd;
            this.Ozy = ozy;
        }

        public void ShowInf()
        {
            Console.WriteLine($"модель ПК - {model}\n" +
                $"Обьем ОЗУ - {Ozy}\n" +
                $"Обьем диска - {Hdd}\n");
        }
    }
}
