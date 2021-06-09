using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public virtual void GetName() { }

        public virtual void SetName(string name) { }

    }

    public class Professor : Person
    {
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }

        public void Teach(string course, DateTime datetime) { }
        public void SetGrade(Guid studentId, Guid courseId, int grade) { }
        public override void GetName() { }
    }

    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }
        public void Attend(string course, DateTime dateTime) { }
        public void WriteExam(string course, DateTime datetime) { }

    }

    public class Institute
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        public virtual void GetName() { }

        public virtual void SetName(string name) { }
    }

    public class University : Institute
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }
        public void GetStudents() { }       
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule(Guid courseId, Guid professorId, DateTime datetime ) { }

    }

    public class Grade
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public int GradeValue { get; set; }
    }

    public class Course
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
    }

    public class Schedule
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid ProfessorId { get; set; }
        public DateTime CallendarId { get; set; }
    }
}
