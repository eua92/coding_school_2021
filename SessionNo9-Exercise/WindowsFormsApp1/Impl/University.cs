using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
  
    public class University : Institute
    {
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }


        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }

        public University()
        {
            Courses = new List<Course>();
            Students = new List<Student>();
            Professors = new List<Professor>();
        }
    }
    


}
