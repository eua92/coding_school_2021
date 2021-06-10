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
    public partial class ProfessorForm : Form
    {
        public Professor Professor { get; set; }
        public ProfessorForm()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int age;
            if (!string.IsNullOrEmpty(txtName.Text) && int.TryParse(txtAge.Text, out age) && cmbRank.SelectedIndex != -1)
            {
                Professor.Name = txtName.Text;
                Professor.Age = Convert.ToInt32(txtAge.Text);
                Professor.Rank = cmbRank.SelectedItem.ToString();
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
