using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }
        public Student()
        {

        }
        public void Attend(Course course, DateTime dateTime) { }
        public void WriteExam(Course course, DateTime datetime) { }
    }
}
