using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personapp

{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Address = "piippukatu 2";
            teacher.Age = 39;
            teacher.FirstName = "Kirsi";
            teacher.LastName = "Kernel";
            Console.WriteLine(teacher.ToString());





            Student student = new Student("matti","mallikas","H9123");
            student.Address = "pajuköysi 12";
            student.Age = 23;
            student.PhoneNumber = "040-8827382";
            Console.WriteLine(student.ToString());


            teacher.TeacherMethod();
            student.StudentMethod();




        }
    }
}
