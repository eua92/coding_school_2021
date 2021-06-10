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
    public partial class StudentForm : Form
    {
        public Student Student { get; set; }

        public StudentForm()
        {
            InitializeComponent( );
           
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //todo: MODIFY THE OBJECT STUDENT --CLOSE THE FORM!
            int age;
            if ( !string.IsNullOrEmpty(txtName.Text) && int.TryParse(txtAge.Text, out age) )
            {
                Student.Name = txtName.Text;
                Student.Age = age;
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
