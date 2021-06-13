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
    public partial class ProfessorForm : Form
    {
        public University NewUniversity { get; set; }

        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void ctrlOK_Click(object sender, EventArgs e)
        {
            AddNewProfessor();             
        }

        private void ctrlCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void AddNewProfessor()
        {
            Professor newProfessor = new Professor();

            int age;
            if (ctrlName.EditValue.ToString().Length > 0 && int.TryParse(ctrlAge.EditValue.ToString(), out age) && ctrlRank.SelectedIndex != -1)
            {
                newProfessor.Name = Convert.ToString(ctrlName.EditValue);
                newProfessor.Age = age;
                newProfessor.Rank = Convert.ToString(ctrlRank.SelectedItem);
                NewUniversity.Professors.Add(newProfessor);
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
