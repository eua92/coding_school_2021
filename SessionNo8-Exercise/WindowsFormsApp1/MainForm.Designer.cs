
namespace WindowsFormsApp1 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lstProfessors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(566, 658);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(69, 70);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(109, 82);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "Add Course...";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(217, 70);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(109, 82);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Add Student...";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Location = new System.Drawing.Point(363, 70);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(109, 82);
            this.btnAddProfessor.TabIndex = 9;
            this.btnAddProfessor.Text = "Add Professor...";
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.HorizontalScrollbar = true;
            this.lstStudents.Location = new System.Drawing.Point(69, 360);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(500, 95);
            this.lstStudents.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Professors";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.HorizontalScrollbar = true;
            this.lstCourses.Location = new System.Drawing.Point(69, 207);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(500, 95);
            this.lstCourses.TabIndex = 14;
            // 
            // lstProfessors
            // 
            this.lstProfessors.FormattingEnabled = true;
            this.lstProfessors.HorizontalScrollbar = true;
            this.lstProfessors.Location = new System.Drawing.Point(69, 512);
            this.lstProfessors.Name = "lstProfessors";
            this.lstProfessors.Size = new System.Drawing.Size(500, 95);
            this.lstProfessors.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 709);
            this.Controls.Add(this.lstProfessors);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnAddProfessor);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.ListBox lstProfessors;
    }
}

