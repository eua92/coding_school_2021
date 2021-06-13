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
    public partial class CourseForm : Form
    {
        public University NewUniversity { get; set; }

        public CourseForm()
        {
            InitializeComponent();
        }

        private void ctrlOK_Click(object sender, EventArgs e)
        {
            AddNewCourse();
        }

        private void ctrlCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        } 
        
        private void AddNewCourse()
        {
            Course newCourse = new Course();

            if (ctrlCode.EditValue.ToString().Length > 0 && ctrlSubject.EditValue.ToString().Length > 0)
            {
                newCourse.Code = Convert.ToString(ctrlCode.EditValue);
                newCourse.Subject = Convert.ToString(ctrlSubject.EditValue);
                NewUniversity.Courses.Add(newCourse);
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
