using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Student
        {
            public string name, lastname, id, faculty;
            public double gpa;

            public Student(string name, string lastname, string id, string faculty, double gpa)
                {
                    this.name = name;
                    this.lastname = lastname;
                    this.id = id;
                    this.faculty = faculty;
                    this.gpa = gpa;
                }

        public override string ToString()
            {
                return name + " " + lastname + " " + id + " " + faculty + " " + gpa;
            }
        }

    class Program
        {
             static void Main(string[] args)
                {
                Student student1 = new Student("Aigerim", "Seiilbekova", "15BD02050", "FIT", 2.6);
                Console.WriteLine(student1);
                Console.ReadKey();
        }
    }
}
