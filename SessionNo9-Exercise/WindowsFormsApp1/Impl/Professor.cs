using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl
{
    public class Professor : Person
    {
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }

        public Professor()
        {

        }
        public void Teach(Course course, DateTime datetime) { }
        public void SetGrade(Guid studentId, Guid courseId, Grade grade) { }
        public override string GetName()
        {
            return $"Dr {Name}";
        }
    }
}
