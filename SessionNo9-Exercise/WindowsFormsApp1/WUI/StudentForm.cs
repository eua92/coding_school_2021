using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        public University NewUniversity { get; set; }

        public StudentForm()
        {
            InitializeComponent( );
           
        }
        private void ctrlOK_Click(object sender, EventArgs e)
        {
            AddNewStudent();          
        }

        private void ctrlCancel_Click(object sender, EventArgs e)
        {
            Close();  
        } 
        
        private void AddNewStudent()
        {
            Student newStudent = new Student();

            int age;
            if (ctrlName.EditValue.ToString().Length > 0 && int.TryParse(ctrlAge.EditValue.ToString(), out age))
            {
                newStudent.Name = Convert.ToString(ctrlName.EditValue);
                newStudent.Age = age;
                newStudent.RegistrationNumber = NewUniversity.Students.Count + 1;
                NewUniversity.Students.Add(newStudent);
                Close();
            }
            else
            {
                MessageBox.Show("Enter the correct values");
            }
        }

        private void CloseForm()
        {
            Close();
        }
    }
}
