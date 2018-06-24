namespace SchoolManagement.View
{
    partial class ShowClasses
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
            this.tb_classes_list = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back_class_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_classes_list
            // 
            this.tb_classes_list.Enabled = false;
            this.tb_classes_list.Location = new System.Drawing.Point(24, 53);
            this.tb_classes_list.Multiline = true;
            this.tb_classes_list.Name = "tb_classes_list";
            this.tb_classes_list.Size = new System.Drawing.Size(396, 156);
            this.tb_classes_list.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classes list";
            // 
            // btn_back_class_show
            // 
            this.btn_back_class_show.Location = new System.Drawing.Point(345, 215);
            this.btn_back_class_show.Name = "btn_back_class_show";
            this.btn_back_class_show.Size = new System.Drawing.Size(75, 23);
            this.btn_back_class_show.TabIndex = 4;
            this.btn_back_class_show.Text = "Back";
            this.btn_back_class_show.UseVisualStyleBackColor = true;
            this.btn_back_class_show.Click += new System.EventHandler(this.btn_back_class_show_Click);
            // 
            // ShowClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_class_show);
            this.Controls.Add(this.tb_classes_list);
            this.Controls.Add(this.label1);
            this.Name = "ShowClasses";
            this.Text = "ShowClasses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back_class_show;
        public System.Windows.Forms.TextBox tb_classes_list;
    }
}