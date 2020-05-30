using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    class Demo
    {
        /*
        static void Main(string[] args)
        {
            Student model = retriveStudentFromDatabase();
            StudentView view = new StudentView();
            StudentController controller = new StudentController(model, view);

            controller.UpdateView();

            controller.StudentName = "John";

            controller.UpdateView();
            
        }
        */

        private static Student retriveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robert";
            student.RollNo = "10";
            return student;
        }
    }
}
