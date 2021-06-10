using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {

    public class Person
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }
        public virtual string GetName() {
            return Name;
        }
        public virtual void SetName(string name) { }

    }
    public class Professor : Person
    {
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }

        public Professor()
        {

        }
        public void Teach(Course course, DateTime datetime) { }
        public void SetGrade(Guid studentId, Guid courseId, Grade grade) { }
        public override string GetName() {
            return $"Dr {Name}";
        }
    }
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
    public class Course
    {
        public Guid Id { get; }
        public string Code { get; set; }
        public string Subject { get; set; }
       
        public Course()
        {
            Id = Guid.NewGuid();
        }

    } 
    public class Grade
    {
        public Guid Id { get; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int Value { get; set; }

        public Grade()
        {
            Id = Guid.NewGuid();
        }
    }


}
