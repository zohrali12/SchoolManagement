namespace SchoolManagement.View
{
    partial class ShowTeachers
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
            this.tb_teachers_list = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back_teacher_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_teachers_list
            // 
            this.tb_teachers_list.Enabled = false;
            this.tb_teachers_list.Location = new System.Drawing.Point(37, 71);
            this.tb_teachers_list.Multiline = true;
            this.tb_teachers_list.Name = "tb_teachers_list";
            this.tb_teachers_list.Size = new System.Drawing.Size(396, 145);
            this.tb_teachers_list.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teachers list";
            // 
            // btn_back_teacher_show
            // 
            this.btn_back_teacher_show.Location = new System.Drawing.Point(358, 235);
            this.btn_back_teacher_show.Name = "btn_back_teacher_show";
            this.btn_back_teacher_show.Size = new System.Drawing.Size(75, 23);
            this.btn_back_teacher_show.TabIndex = 4;
            this.btn_back_teacher_show.Text = "Back";
            this.btn_back_teacher_show.UseVisualStyleBackColor = true;
            this.btn_back_teacher_show.Click += new System.EventHandler(this.btn_back_teacher_show_Click);
            // 
            // ShowTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_teacher_show);
            this.Controls.Add(this.tb_teachers_list);
            this.Controls.Add(this.label1);
            this.Name = "ShowTeachers";
            this.Text = "ShowTeachers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back_teacher_show;
        public System.Windows.Forms.TextBox tb_teachers_list;
    }
}