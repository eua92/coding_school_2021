
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
            this.ctrlExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlAddCourse = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.ctrlAddProfessor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlSerialize = new System.Windows.Forms.Button();
            this.ctrlStudentList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlCourseList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlProfessorList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlDeserialize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(566, 658);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(143, 32);
            this.ctrlExit.TabIndex = 2;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
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
            // ctrlAddCourse
            // 
            this.ctrlAddCourse.Location = new System.Drawing.Point(69, 70);
            this.ctrlAddCourse.Name = "ctrlAddCourse";
            this.ctrlAddCourse.Size = new System.Drawing.Size(109, 82);
            this.ctrlAddCourse.TabIndex = 7;
            this.ctrlAddCourse.Text = "Add Course...";
            this.ctrlAddCourse.UseVisualStyleBackColor = true;
            this.ctrlAddCourse.Click += new System.EventHandler(this.ctrlAddCourse_Click);
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Location = new System.Drawing.Point(217, 70);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(109, 82);
            this.ctrlAddStudent.TabIndex = 8;
            this.ctrlAddStudent.Text = "Add Student...";
            this.ctrlAddStudent.UseVisualStyleBackColor = true;
            this.ctrlAddStudent.Click += new System.EventHandler(this.ctrlAddStudent_Click);
            // 
            // ctrlAddProfessor
            // 
            this.ctrlAddProfessor.Location = new System.Drawing.Point(363, 70);
            this.ctrlAddProfessor.Name = "ctrlAddProfessor";
            this.ctrlAddProfessor.Size = new System.Drawing.Size(109, 82);
            this.ctrlAddProfessor.TabIndex = 9;
            this.ctrlAddProfessor.Text = "Add Professor...";
            this.ctrlAddProfessor.UseVisualStyleBackColor = true;
            this.ctrlAddProfessor.Click += new System.EventHandler(this.ctrlAddProfessor_Click);
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
            // ctrlSerialize
            // 
            this.ctrlSerialize.Location = new System.Drawing.Point(69, 658);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(159, 32);
            this.ctrlSerialize.TabIndex = 16;
            this.ctrlSerialize.Text = "Serialize";
            this.ctrlSerialize.UseVisualStyleBackColor = true;
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // ctrlStudentList
            // 
            this.ctrlStudentList.HorizontalScrollbar = true;
            this.ctrlStudentList.Location = new System.Drawing.Point(69, 360);
            this.ctrlStudentList.Name = "ctrlStudentList";
            this.ctrlStudentList.Size = new System.Drawing.Size(446, 95);
            this.ctrlStudentList.TabIndex = 17;
            // 
            // ctrlCourseList
            // 
            this.ctrlCourseList.HorizontalScrollbar = true;
            this.ctrlCourseList.Location = new System.Drawing.Point(69, 207);
            this.ctrlCourseList.Name = "ctrlCourseList";
            this.ctrlCourseList.Size = new System.Drawing.Size(446, 95);
            this.ctrlCourseList.TabIndex = 18;
            // 
            // ctrlProfessorList
            // 
            this.ctrlProfessorList.HorizontalScrollbar = true;
            this.ctrlProfessorList.Location = new System.Drawing.Point(69, 512);
            this.ctrlProfessorList.Name = "ctrlProfessorList";
            this.ctrlProfessorList.Size = new System.Drawing.Size(446, 95);
            this.ctrlProfessorList.TabIndex = 19;
            // 
            // ctrlDeserialize
            // 
            this.ctrlDeserialize.Location = new System.Drawing.Point(245, 658);
            this.ctrlDeserialize.Name = "ctrlDeserialize";
            this.ctrlDeserialize.Size = new System.Drawing.Size(159, 32);
            this.ctrlDeserialize.TabIndex = 20;
            this.ctrlDeserialize.Text = "Deserialize";
            this.ctrlDeserialize.UseVisualStyleBackColor = true;
            this.ctrlDeserialize.Click += new System.EventHandler(this.ctrlDeserialize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 709);
            this.Controls.Add(this.ctrlDeserialize);
            this.Controls.Add(this.ctrlProfessorList);
            this.Controls.Add(this.ctrlCourseList);
            this.Controls.Add(this.ctrlStudentList);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlAddProfessor);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.ctrlAddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlExit);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ctrlExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctrlAddCourse;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button ctrlAddProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ctrlSerialize;
        private DevExpress.XtraEditors.ListBoxControl ctrlStudentList;
        private DevExpress.XtraEditors.ListBoxControl ctrlCourseList;
        private DevExpress.XtraEditors.ListBoxControl ctrlProfessorList;
        private System.Windows.Forms.Button ctrlDeserialize;
    }
}

