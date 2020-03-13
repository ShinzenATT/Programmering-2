using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    public class StudentController
    {
        private Student model;
        private StudentView view;

        public string StudentName { 
            get { return model.Name; }
            set { model.Name = value; }
        }

        public string StudentRollNo
        {
            get { return model.RollNo; }
            set { model.RollNo = value; }
        }

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void UpdateView()
        {
            view.PrintStudentDetails(StudentName, StudentRollNo);
        }
    }
}
