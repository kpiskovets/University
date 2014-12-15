namespace vovk
{
    partial class Working
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_experience = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(176, 293);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(109, 293);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(42, 293);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Зарплата";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(139, 247);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_salary.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Досвід";
            // 
            // textBox_experience
            // 
            this.textBox_experience.Location = new System.Drawing.Point(139, 221);
            this.textBox_experience.Name = "textBox_experience";
            this.textBox_experience.Size = new System.Drawing.Size(100, 20);
            this.textBox_experience.TabIndex = 22;
            // 
            // Працює
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_experience);
            this.Name = "Працює";
            this.Text = "Working";
            this.Controls.SetChildIndex(this.button_Apply, 0);
            this.Controls.SetChildIndex(this.textBox_Unique_number, 0);
            this.Controls.SetChildIndex(this.textBox_Name, 0);
            this.Controls.SetChildIndex(this.textBox_Major, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.textBox_Class, 0);
            this.Controls.SetChildIndex(this.textBox_experience, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_salary, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_experience;
    }
}