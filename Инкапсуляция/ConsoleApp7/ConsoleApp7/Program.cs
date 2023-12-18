using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
     static void Main(string[] args)
     {
            Student st1 = new Student();
            st1.Fam = "Ivanov";
            st1.Kurs = 1;

        st1.ShowInfo();

        Student st2 = new Student();
        st2.Fam = "";
        st2.Kurs = 3;
        st2.Kurs = 10;// изначально нельзя вставить -7 т,к изпользую тип byte
        st2.ShowInfo();

        Student st3 = new Student("Badigin",5);
        st3.Kurs = 3;
        st3.Kurs = 5;
        st3.ShowInfo();
    }
}

