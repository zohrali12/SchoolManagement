namespace SchoolManagement.View
{
    partial class TeacherProfile
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
            this.btn_teacherProfile_back = new System.Windows.Forms.Button();
            this.lb_teacher_profil_age = new System.Windows.Forms.Label();
            this.lb_teacher_profil_surname = new System.Windows.Forms.Label();
            this.lb_teacher_profil_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_teacherProfile_back
            // 
            this.btn_teacherProfile_back.Location = new System.Drawing.Point(42, 109);
            this.btn_teacherProfile_back.Name = "btn_teacherProfile_back";
            this.btn_teacherProfile_back.Size = new System.Drawing.Size(75, 23);
            this.btn_teacherProfile_back.TabIndex = 8;
            this.btn_teacherProfile_back.Text = "Back";
            this.btn_teacherProfile_back.UseVisualStyleBackColor = true;
            this.btn_teacherProfile_back.Click += new System.EventHandler(this.btn_teacherProfile_back_Click);
            // 
            // lb_teacher_profil_age
            // 
            this.lb_teacher_profil_age.AutoSize = true;
            this.lb_teacher_profil_age.Location = new System.Drawing.Point(82, 55);
            this.lb_teacher_profil_age.Name = "lb_teacher_profil_age";
            this.lb_teacher_profil_age.Size = new System.Drawing.Size(28, 13);
            this.lb_teacher_profil_age.TabIndex = 2;
            this.lb_teacher_profil_age.Text = "-------";
            // 
            // lb_teacher_profil_surname
            // 
            this.lb_teacher_profil_surname.AutoSize = true;
            this.lb_teacher_profil_surname.Location = new System.Drawing.Point(82, 32);
            this.lb_teacher_profil_surname.Name = "lb_teacher_profil_surname";
            this.lb_teacher_profil_surname.Size = new System.Drawing.Size(28, 13);
            this.lb_teacher_profil_surname.TabIndex = 3;
            this.lb_teacher_profil_surname.Text = "-------";
            // 
            // lb_teacher_profil_name
            // 
            this.lb_teacher_profil_name.AutoSize = true;
            this.lb_teacher_profil_name.Location = new System.Drawing.Point(82, 9);
            this.lb_teacher_profil_name.Name = "lb_teacher_profil_name";
            this.lb_teacher_profil_name.Size = new System.Drawing.Size(28, 13);
            this.lb_teacher_profil_name.TabIndex = 4;
            this.lb_teacher_profil_name.Text = "-------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // TeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_teacherProfile_back);
            this.Controls.Add(this.lb_teacher_profil_age);
            this.Controls.Add(this.lb_teacher_profil_surname);
            this.Controls.Add(this.lb_teacher_profil_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherProfile";
            this.Text = "TeacherProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_teacherProfile_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_teacher_profil_name;
        public System.Windows.Forms.Label lb_teacher_profil_surname;
        public System.Windows.Forms.Label lb_teacher_profil_age;
    }
}