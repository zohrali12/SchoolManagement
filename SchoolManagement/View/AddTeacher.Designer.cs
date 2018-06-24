namespace SchoolManagement
{
    partial class AddTeacher
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_teacher = new System.Windows.Forms.Button();
            this.tb_teacher_age = new System.Windows.Forms.TextBox();
            this.tb_teacher_surname = new System.Windows.Forms.TextBox();
            this.tb_teacher_name = new System.Windows.Forms.TextBox();
            this.btn_back_teacher = new System.Windows.Forms.Button();
            this.tb_teacher_password = new System.Windows.Forms.TextBox();
            this.tb_teacher_login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // btn_add_teacher
            // 
            this.btn_add_teacher.Location = new System.Drawing.Point(161, 212);
            this.btn_add_teacher.Name = "btn_add_teacher";
            this.btn_add_teacher.Size = new System.Drawing.Size(75, 23);
            this.btn_add_teacher.TabIndex = 6;
            this.btn_add_teacher.Text = "Add";
            this.btn_add_teacher.UseVisualStyleBackColor = true;
            this.btn_add_teacher.Click += new System.EventHandler(this.btn_add_teacher_Click);
            // 
            // tb_teacher_age
            // 
            this.tb_teacher_age.Location = new System.Drawing.Point(83, 108);
            this.tb_teacher_age.Name = "tb_teacher_age";
            this.tb_teacher_age.Size = new System.Drawing.Size(153, 20);
            this.tb_teacher_age.TabIndex = 3;
            // 
            // tb_teacher_surname
            // 
            this.tb_teacher_surname.Location = new System.Drawing.Point(83, 72);
            this.tb_teacher_surname.Name = "tb_teacher_surname";
            this.tb_teacher_surname.Size = new System.Drawing.Size(153, 20);
            this.tb_teacher_surname.TabIndex = 4;
            // 
            // tb_teacher_name
            // 
            this.tb_teacher_name.Location = new System.Drawing.Point(83, 36);
            this.tb_teacher_name.Name = "tb_teacher_name";
            this.tb_teacher_name.Size = new System.Drawing.Size(153, 20);
            this.tb_teacher_name.TabIndex = 5;
            // 
            // btn_back_teacher
            // 
            this.btn_back_teacher.Location = new System.Drawing.Point(83, 213);
            this.btn_back_teacher.Name = "btn_back_teacher";
            this.btn_back_teacher.Size = new System.Drawing.Size(72, 22);
            this.btn_back_teacher.TabIndex = 10;
            this.btn_back_teacher.Text = "Back";
            this.btn_back_teacher.UseVisualStyleBackColor = true;
            this.btn_back_teacher.Click += new System.EventHandler(this.btn_back_teacher_Click);
            // 
            // tb_teacher_password
            // 
            this.tb_teacher_password.Location = new System.Drawing.Point(83, 171);
            this.tb_teacher_password.Name = "tb_teacher_password";
            this.tb_teacher_password.Size = new System.Drawing.Size(153, 20);
            this.tb_teacher_password.TabIndex = 13;
            // 
            // tb_teacher_login
            // 
            this.tb_teacher_login.Location = new System.Drawing.Point(83, 140);
            this.tb_teacher_login.Name = "tb_teacher_login";
            this.tb_teacher_login.Size = new System.Drawing.Size(153, 20);
            this.tb_teacher_login.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Login";
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_teacher_password);
            this.Controls.Add(this.tb_teacher_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_back_teacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_teacher);
            this.Controls.Add(this.tb_teacher_age);
            this.Controls.Add(this.tb_teacher_surname);
            this.Controls.Add(this.tb_teacher_name);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_teacher;
        private System.Windows.Forms.TextBox tb_teacher_age;
        private System.Windows.Forms.TextBox tb_teacher_surname;
        private System.Windows.Forms.TextBox tb_teacher_name;
        private System.Windows.Forms.Button btn_back_teacher;
        private System.Windows.Forms.TextBox tb_teacher_password;
        private System.Windows.Forms.TextBox tb_teacher_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}