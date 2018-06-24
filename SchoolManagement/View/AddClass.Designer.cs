namespace SchoolManagement
{
    partial class AddClass
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
            this.tb_class_name = new System.Windows.Forms.TextBox();
            this.btn_add_class = new System.Windows.Forms.Button();
            this.btn_back_class = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // tb_class_name
            // 
            this.tb_class_name.Location = new System.Drawing.Point(90, 44);
            this.tb_class_name.Name = "tb_class_name";
            this.tb_class_name.Size = new System.Drawing.Size(153, 20);
            this.tb_class_name.TabIndex = 10;
            // 
            // btn_add_class
            // 
            this.btn_add_class.Location = new System.Drawing.Point(168, 83);
            this.btn_add_class.Name = "btn_add_class";
            this.btn_add_class.Size = new System.Drawing.Size(75, 23);
            this.btn_add_class.TabIndex = 12;
            this.btn_add_class.Text = "Add";
            this.btn_add_class.UseVisualStyleBackColor = true;
            this.btn_add_class.Click += new System.EventHandler(this.btn_add_class_Click);
            // 
            // btn_back_class
            // 
            this.btn_back_class.Location = new System.Drawing.Point(90, 84);
            this.btn_back_class.Name = "btn_back_class";
            this.btn_back_class.Size = new System.Drawing.Size(72, 22);
            this.btn_back_class.TabIndex = 13;
            this.btn_back_class.Text = "Back";
            this.btn_back_class.UseVisualStyleBackColor = true;
            this.btn_back_class.Click += new System.EventHandler(this.btn_back_class_Click);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_class);
            this.Controls.Add(this.btn_add_class);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_class_name);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_class_name;
        private System.Windows.Forms.Button btn_add_class;
        private System.Windows.Forms.Button btn_back_class;
    }
}