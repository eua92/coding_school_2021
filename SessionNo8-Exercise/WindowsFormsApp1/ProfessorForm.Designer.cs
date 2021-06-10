
namespace WindowsFormsApp1
{
    partial class ProfessorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rank";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(126, 94);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 20);
            this.txtAge.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(259, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbRank
            // 
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Items.AddRange(new object[] {
            "Full",
            "Associate ",
            "Assistant"});
            this.cmbRank.Location = new System.Drawing.Point(126, 127);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(121, 21);
            this.cmbRank.TabIndex = 3;
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbRank;
    }
}