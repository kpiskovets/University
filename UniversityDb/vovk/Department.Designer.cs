namespace vovk
{
    partial class Department
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
            this.textBox_employees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_specialization = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(180, 287);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(113, 287);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(35, 287);
            // 
            // textBox_employees
            // 
            this.textBox_employees.Location = new System.Drawing.Point(141, 252);
            this.textBox_employees.Name = "textBox_employees";
            this.textBox_employees.Size = new System.Drawing.Size(100, 20);
            this.textBox_employees.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Кількість працівників";
            // 
            // textBox_specialization
            // 
            this.textBox_specialization.Location = new System.Drawing.Point(141, 226);
            this.textBox_specialization.Name = "textBox_specialization";
            this.textBox_specialization.Size = new System.Drawing.Size(100, 20);
            this.textBox_specialization.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Спеціалізація";
            // 
            // Кафедра
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.textBox_employees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_specialization);
            this.Controls.Add(this.label3);
            this.Name = "Кафедра";
            this.Text = "Department";
            this.Controls.SetChildIndex(this.button_Apply, 0);
            this.Controls.SetChildIndex(this.textBox_Unique_number, 0);
            this.Controls.SetChildIndex(this.textBox_Name, 0);
            this.Controls.SetChildIndex(this.textBox_Major, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.textBox_Class, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_specialization, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox_employees, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_employees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_specialization;
        private System.Windows.Forms.Label label3;
    }
}