using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.Clear();
            Console.WriteLine("Student:");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
        }

        public void PrintStudentDetails(Student student)
        {
            PrintStudentDetails(student.Name, student.RollNo);
        }
    }
}
