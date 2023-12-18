using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Student
    {
    private string name;
    private string fam;
    private string age;
    private byte kurs;
    private int id = 300;

    public string Fam 
    {
        get
        {
            return fam == "" ? "неизвестный" : fam;
        }    
 
        
        set
        {
            fam = value;
            fam = fam.ToUpper();
        } 
    }
    public byte Kurs 
    { 
        get
        {
            
          return  kurs = kurs == 1 || kurs == 4 ? Convert.ToByte(0) : kurs; 
          
        } 
        set
        {
              if (value <= 4)
            {
                kurs = value;
            }  
        } 
    }

    public int Id { get { return id++; }   }

    public Student ()
    {

    }

    public Student(string fam,byte kurs)
    {
        Convert.ToByte(kurs);
        this.Fam = fam;
        this.Kurs = kurs;
    }

   

    public void ShowInfo ()
        {
            Console.WriteLine($"id {Id} \n" +
                $"Фамилия студента {Fam}\n" +
                $"{name}\n" +
                $"курс обучения {Kurs}\n" +
                $"{age}\n");
        }
    }

