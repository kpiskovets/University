﻿namespace vovk
{
    partial class Faculty
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
            this.textBox_amount_groups = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_amount_cathedr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(180, 321);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(113, 321);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(35, 321);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Кількусть груп";
            // 
            // textBox_amount_groups
            // 
            this.textBox_amount_groups.Location = new System.Drawing.Point(141, 252);
            this.textBox_amount_groups.Name = "textBox_amount_groups";
            this.textBox_amount_groups.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount_groups.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Кількість кафедр";
            // 
            // textBox_amount_cathedr
            // 
            this.textBox_amount_cathedr.Location = new System.Drawing.Point(141, 226);
            this.textBox_amount_cathedr.Name = "textBox_amount_cathedr";
            this.textBox_amount_cathedr.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount_cathedr.TabIndex = 26;
            // 
            // Факультет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_amount_groups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_amount_cathedr);
            this.Name = "Факультет";
            this.Text = "Faculty";
            this.Controls.SetChildIndex(this.button_Apply, 0);
            this.Controls.SetChildIndex(this.textBox_Unique_number, 0);
            this.Controls.SetChildIndex(this.textBox_Name, 0);
            this.Controls.SetChildIndex(this.textBox_Major, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.textBox_Class, 0);
            this.Controls.SetChildIndex(this.textBox_amount_cathedr, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_amount_groups, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_amount_groups;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_amount_cathedr;
    }
}