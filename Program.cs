using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpringProgram1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student aStudent1 = new Student();
            Student aStudent2 = new Student();
            Student aStudent3 = new Student();
            Student aStudent4 = new Student(4, "Qasai", "Mohammed", "", "MSIT");
            Student aStudent5 = new Student(5, "Jane", "Stevenson", "Patricia", "Dental Hygiene");

            aStudent1.StudentId = 1;
            aStudent1.FirstName = "Anna";
            aStudent1.LastName = "Romanov";
            aStudent1.MiddleName = "Marie";
            aStudent1.Major = "Biology";

            aStudent2.StudentId = 2;
            aStudent2.FirstName = "Steven";
            aStudent2.LastName = "Trotter";
            aStudent2.MiddleName = "";
            aStudent2.Major = "French";

            aStudent3.StudentId = 3;
            aStudent3.FirstName = "Omar";
            aStudent3.LastName = "Mohanned";
            aStudent3.MiddleName = "Qasai";
            aStudent3.Major = "Computer";

            List<Student> aListOfStudents = new List<Student>();
            aListOfStudents.Add(aStudent1);
            aListOfStudents.Add(aStudent2);
            aListOfStudents.Add(aStudent3);
            aListOfStudents.Add(aStudent4);
            aListOfStudents.Add(aStudent5);

            /*
            Console.WriteLine(aStudent1);
            Console.WriteLine(aStudent2);
            Console.WriteLine(aStudent3);
            Console.WriteLine(aStudent4);
            Console.WriteLine(aStudent5);
            */


            foreach (Student aStudent in aListOfStudents)
            {
                Console.WriteLine(aStudent.ToString());
            }    
        }
    }
}
