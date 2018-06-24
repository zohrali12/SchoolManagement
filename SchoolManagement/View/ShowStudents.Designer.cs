namespace SchoolManagement.View
{
    partial class ShowStudents
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
            this.tb_students_list = new System.Windows.Forms.TextBox();
            this.btn_back_student_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students list";
            // 
            // tb_students_list
            // 
            this.tb_students_list.Enabled = false;
            this.tb_students_list.Location = new System.Drawing.Point(34, 57);
            this.tb_students_list.Multiline = true;
            this.tb_students_list.Name = "tb_students_list";
            this.tb_students_list.Size = new System.Drawing.Size(396, 145);
            this.tb_students_list.TabIndex = 1;
            // 
            // btn_back_student_show
            // 
            this.btn_back_student_show.Location = new System.Drawing.Point(355, 217);
            this.btn_back_student_show.Name = "btn_back_student_show";
            this.btn_back_student_show.Size = new System.Drawing.Size(75, 23);
            this.btn_back_student_show.TabIndex = 2;
            this.btn_back_student_show.Text = "Back";
            this.btn_back_student_show.UseVisualStyleBackColor = true;
            this.btn_back_student_show.Click += new System.EventHandler(this.btn_back_student_show_Click);
            // 
            // ShowStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_student_show);
            this.Controls.Add(this.tb_students_list);
            this.Controls.Add(this.label1);
            this.Name = "ShowStudents";
            this.Text = "ShowStudents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back_student_show;
        public System.Windows.Forms.TextBox tb_students_list;
    }
}