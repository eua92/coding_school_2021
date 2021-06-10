using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class MainForm : Form {

        List<Course> Courses = new List<Course>();
        List<Student> Students = new List<Student>();
        List<Professor> Professors = new List<Professor>();
        public MainForm() {
            InitializeComponent();
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();

            CourseForm form = new CourseForm();
            form.Course = course;
            form.ShowDialog();

            if (course.Code != null)
            {
                Courses.Add(course);
            }
            lstCourses.Items.Clear();
            foreach (var item in Courses)
            {
                lstCourses.Items.Add($"Id: {item.Id}, Code: {item.Code}, Subject: {item.Subject}");
            }
        }
        private void btnAddStudent_Click(object sender, EventArgs e) {

            Student student = new Student();

            StudentForm form = new StudentForm();
            form.Student = student;
            form.ShowDialog();

            student.RegistrationNumber = Students.Count+1;

            if (student.Name != null)
            {
                Students.Add(student);
            }
            lstStudents.Items.Clear();
            foreach (var item in Students)
            {
                lstStudents.Items.Add($"Id: {item.Id}, Name: {item.Name}, Age: {item.Age}, Registration Number: {item.RegistrationNumber}");
            }
        }
        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
           
            ProfessorForm form = new ProfessorForm();
            form.Professor = professor;
            form.ShowDialog();

            if (professor.Age != 0)
            {
                Professors.Add(professor);
            }       
            lstProfessors.Items.Clear();
            foreach (var item in Professors)
            {
                lstProfessors.Items.Add($"Id: {item.Id}, Name: {item.GetName()}, Age: {item.Age}, Rank: {item.Rank}");
            }
        }
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
