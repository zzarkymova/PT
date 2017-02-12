using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_LabWork1_T2_student
{
    public class student
    {
        public string name;
        public string surname;
        public double gpa;
        public student()
        {
            name = "Zere";
            surname = "Zarkymova";
            gpa = 3.5;

        }
        public student(string a, string b, double c)
        {
            this.name = a;
            this.surname = b;
            this.gpa = c;

        }
        public override string ToString()
        {
            return this.name + " " + surname + " " + gpa;
        }
    }
    
   
    class Program
    {
         static void Main(string[] args)
        {
            student a = new student ("Altynay", "Yerkassym", 3.6);
            student b = new student ("Tima", "Yerikuly", 3.0);
            student c = new student ("Zhanym", "Kuatkalieva", 3.4);
            student d = new student ("Zhangul", "Demeuova", 3.4);
            student e = new student ("Aru", "Bektemirova", 3.8);

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(e.ToString());

            Console.ReadKey();

        }
    }
}
