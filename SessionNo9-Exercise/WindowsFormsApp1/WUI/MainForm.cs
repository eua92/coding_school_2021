using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1 {

    public partial class MainForm : Form {

        private const string _JsonFile = "UniversityData.json";

        University CodingSchool = new University();

        public MainForm() {
            InitializeComponent();
        }
        private void ctrlAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        }
        private void ctrlAddStudent_Click(object sender, EventArgs e) 
        {
            AddStudent();
        }
        private void ctrlAddProfessor_Click(object sender, EventArgs e)
        {
            AddProfessor();
        }
        private void ctrlExit_Click(object sender, EventArgs e) {
            CloseApplication();
        }

        private void SerializeToJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // TODO: SERIALIZE UNIVERSITY OBJECT INSTEAD OF STUDENTS!
            string data = serializer.Serialize(CodingSchool);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);
        }

        private void DeserializeFromJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            CodingSchool = serializer.Deserialize<University>(data);
        }

        private void ctrlSerialize_Click(object sender, EventArgs e)
        {
            SerializeToJson();
        }

        private void ctrlDeserialize_Click(object sender, EventArgs e)
        {
            DeserializeFromJson();

            RefreshCourseList();
            RefreshStudentList();
            RefreshProfessorList();
        }

        private void AddCourse()
        {
            CourseForm form = new CourseForm();
            form.NewUniversity = CodingSchool;

            form.ShowDialog();

            RefreshCourseList();
        }

        private void AddStudent()
        {
            StudentForm form = new StudentForm();
            form.NewUniversity = CodingSchool;

            form.ShowDialog();

            RefreshStudentList();
        }
        
        private void AddProfessor()
        {
            ProfessorForm form = new ProfessorForm();
            form.NewUniversity = CodingSchool;

            form.ShowDialog();

            RefreshProfessorList();
        }

        private void RefreshCourseList()
        {
            ctrlCourseList.Items.Clear();
            foreach (var item in CodingSchool.Courses)
            {
                ctrlCourseList.Items.Add($"Id: {item.Id}, Code: {item.Code}, Subject: {item.Subject}");
            }
        }

        private void RefreshStudentList()
        {
            ctrlStudentList.Items.Clear();
            foreach (var item in CodingSchool.Students)
            {
                ctrlStudentList.Items.Add($"Id: {item.Id}, Name: {item.Name}, Age: {item.Age}, Registration Number: {item.RegistrationNumber}");
            }
        }

        private void RefreshProfessorList()
        {
            ctrlProfessorList.Items.Clear();
            foreach (var item in CodingSchool.Professors)
            {
                ctrlProfessorList.Items.Add($"Id: {item.Id}, Name: {item.GetName()}, Age: {item.Age}, Rank: {item.Rank}");
            }
        }

        private void CloseApplication()
        {
            Application.Exit();
        }
    }
}
