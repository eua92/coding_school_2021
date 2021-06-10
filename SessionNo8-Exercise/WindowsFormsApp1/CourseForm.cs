using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CourseForm : Form
    {
        public Course Course { get; set; }
        public CourseForm()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtSubject.Text))
            {
                Course.Code = txtCode.Text;
                Course.Subject = txtSubject.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter the correct values");
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
