namespace SchoolManagement
{
    partial class AdminPanel
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
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.btn_add_teacher = new System.Windows.Forms.Button();
            this.btn_add_class = new System.Windows.Forms.Button();
            this.btn_show_student = new System.Windows.Forms.Button();
            this.btn_show_teacher = new System.Windows.Forms.Button();
            this.btn_show_class = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Location = new System.Drawing.Point(33, 32);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(127, 42);
            this.btn_AddStudent.TabIndex = 0;
            this.btn_AddStudent.Text = "ADD STUDENT";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // btn_add_teacher
            // 
            this.btn_add_teacher.Location = new System.Drawing.Point(166, 32);
            this.btn_add_teacher.Name = "btn_add_teacher";
            this.btn_add_teacher.Size = new System.Drawing.Size(127, 42);
            this.btn_add_teacher.TabIndex = 0;
            this.btn_add_teacher.Text = "ADD TEACHER";
            this.btn_add_teacher.UseVisualStyleBackColor = true;
            this.btn_add_teacher.Click += new System.EventHandler(this.btn_add_teacher_Click);
            // 
            // btn_add_class
            // 
            this.btn_add_class.Location = new System.Drawing.Point(299, 32);
            this.btn_add_class.Name = "btn_add_class";
            this.btn_add_class.Size = new System.Drawing.Size(127, 42);
            this.btn_add_class.TabIndex = 0;
            this.btn_add_class.Text = "ADD CLASS";
            this.btn_add_class.UseVisualStyleBackColor = true;
            this.btn_add_class.Click += new System.EventHandler(this.btn_add_class_Click);
            // 
            // btn_show_student
            // 
            this.btn_show_student.Location = new System.Drawing.Point(33, 102);
            this.btn_show_student.Name = "btn_show_student";
            this.btn_show_student.Size = new System.Drawing.Size(127, 42);
            this.btn_show_student.TabIndex = 0;
            this.btn_show_student.Text = "SHOW STUDENT";
            this.btn_show_student.UseVisualStyleBackColor = true;
            this.btn_show_student.Click += new System.EventHandler(this.btn_show_student_Click);
            // 
            // btn_show_teacher
            // 
            this.btn_show_teacher.Location = new System.Drawing.Point(166, 102);
            this.btn_show_teacher.Name = "btn_show_teacher";
            this.btn_show_teacher.Size = new System.Drawing.Size(127, 42);
            this.btn_show_teacher.TabIndex = 0;
            this.btn_show_teacher.Text = "SHOW TEACHER";
            this.btn_show_teacher.UseVisualStyleBackColor = true;
            this.btn_show_teacher.Click += new System.EventHandler(this.btn_show_teacher_Click);
            // 
            // btn_show_class
            // 
            this.btn_show_class.Location = new System.Drawing.Point(299, 102);
            this.btn_show_class.Name = "btn_show_class";
            this.btn_show_class.Size = new System.Drawing.Size(127, 42);
            this.btn_show_class.TabIndex = 0;
            this.btn_show_class.Text = "SHOW CLASS";
            this.btn_show_class.UseVisualStyleBackColor = true;
            this.btn_show_class.Click += new System.EventHandler(this.btn_show_class_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(299, 176);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(127, 42);
            this.Home.TabIndex = 0;
            this.Home.Text = "HOME";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click_1);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 250);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btn_show_class);
            this.Controls.Add(this.btn_add_class);
            this.Controls.Add(this.btn_show_teacher);
            this.Controls.Add(this.btn_add_teacher);
            this.Controls.Add(this.btn_show_student);
            this.Controls.Add(this.btn_AddStudent);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_add_teacher;
        private System.Windows.Forms.Button btn_add_class;
        private System.Windows.Forms.Button btn_show_student;
        private System.Windows.Forms.Button btn_show_teacher;
        private System.Windows.Forms.Button btn_show_class;
        private System.Windows.Forms.Button Home;
    }
}