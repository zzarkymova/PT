using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_LabWork1_T2_student
{
    public class student   // we create a class called student, which is accessible (public)
    {
        public string name;  // we add some fields, like name, surname, gpa
        public string surname;
        public double gpa;
        public student()   // we put as a default data, which is Zeree Zarkymova with gpa 3.5
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
        public override string ToString()   // we write method ToString, which will return data as a line 
        {
            return this.name + " " + surname + " " + gpa;
        }
    }
    
   
    class Program
    {
         static void Main(string[] args)
        {
            student a = new student ("Altynay", "Yerkassym", 3.6);    // we create some students
            student b = new student ("Tima", "Yerikuly", 3.0);
            student c = new student ("Zhanym", "Kuatkalieva", 3.4);
            student d = new student ("Zhangul", "Demeuova", 3.4);
            student e = new student ("Aru", "Bektemirova", 3.8);

            Console.WriteLine(a.ToString());    // we print to the console these students by using the method ToString
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(e.ToString());

            Console.ReadKey();   

        }
    }
}
