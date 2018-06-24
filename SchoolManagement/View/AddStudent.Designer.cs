namespace SchoolManagement
{
    partial class AddStudent
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
            this.tb_Student_Name = new System.Windows.Forms.TextBox();
            this.tb_Student_Surname = new System.Windows.Forms.TextBox();
            this.tb_Student_Age = new System.Windows.Forms.TextBox();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_student_login = new System.Windows.Forms.TextBox();
            this.tb_student_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Student_Name
            // 
            this.tb_Student_Name.Location = new System.Drawing.Point(87, 30);
            this.tb_Student_Name.Name = "tb_Student_Name";
            this.tb_Student_Name.Size = new System.Drawing.Size(153, 20);
            this.tb_Student_Name.TabIndex = 0;
            // 
            // tb_Student_Surname
            // 
            this.tb_Student_Surname.Location = new System.Drawing.Point(87, 66);
            this.tb_Student_Surname.Name = "tb_Student_Surname";
            this.tb_Student_Surname.Size = new System.Drawing.Size(153, 20);
            this.tb_Student_Surname.TabIndex = 0;
            // 
            // tb_Student_Age
            // 
            this.tb_Student_Age.Location = new System.Drawing.Point(87, 102);
            this.tb_Student_Age.Name = "tb_Student_Age";
            this.tb_Student_Age.Size = new System.Drawing.Size(153, 20);
            this.tb_Student_Age.TabIndex = 0;
            // 
            // btn_add_student
            // 
            this.btn_add_student.Location = new System.Drawing.Point(165, 202);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(75, 23);
            this.btn_add_student.TabIndex = 1;
            this.btn_add_student.Text = "Add";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(87, 202);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_student_login
            // 
            this.tb_student_login.Location = new System.Drawing.Point(87, 136);
            this.tb_student_login.Name = "tb_student_login";
            this.tb_student_login.Size = new System.Drawing.Size(153, 20);
            this.tb_student_login.TabIndex = 3;
            // 
            // tb_student_password
            // 
            this.tb_student_password.Location = new System.Drawing.Point(87, 167);
            this.tb_student_password.Name = "tb_student_password";
            this.tb_student_password.Size = new System.Drawing.Size(153, 20);
            this.tb_student_password.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 254);
            this.Controls.Add(this.tb_student_password);
            this.Controls.Add(this.tb_student_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.tb_Student_Age);
            this.Controls.Add(this.tb_Student_Surname);
            this.Controls.Add(this.tb_Student_Name);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Student_Name;
        private System.Windows.Forms.TextBox tb_Student_Surname;
        private System.Windows.Forms.TextBox tb_Student_Age;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_student_login;
        private System.Windows.Forms.TextBox tb_student_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}