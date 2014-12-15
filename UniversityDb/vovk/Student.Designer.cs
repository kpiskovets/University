namespace vovk
{
    partial class Student
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_entry_year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_studing_form = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(177, 310);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(110, 310);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(43, 310);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Рік вступу";
            // 
            // textBox_entry_year
            // 
            this.textBox_entry_year.Location = new System.Drawing.Point(138, 279);
            this.textBox_entry_year.Name = "textBox_entry_year";
            this.textBox_entry_year.Size = new System.Drawing.Size(100, 20);
            this.textBox_entry_year.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Форма навчання";
            // 
            // textBox_studing_form
            // 
            this.textBox_studing_form.Location = new System.Drawing.Point(138, 253);
            this.textBox_studing_form.Name = "textBox_studing_form";
            this.textBox_studing_form.Size = new System.Drawing.Size(100, 20);
            this.textBox_studing_form.TabIndex = 28;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_entry_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_studing_form);
            this.Name = "Student";
            this.Text = "Student";
            this.Controls.SetChildIndex(this.button_Apply, 0);
            this.Controls.SetChildIndex(this.textBox_Unique_number, 0);
            this.Controls.SetChildIndex(this.textBox_Name, 0);
            this.Controls.SetChildIndex(this.textBox_Major, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.textBox_Class, 0);
            this.Controls.SetChildIndex(this.textBox_studing_form, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox_entry_year, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_entry_year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_studing_form;
    }
}