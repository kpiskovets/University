﻿namespace vovk
{
    partial class Deanery
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_assistant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(180, 267);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(113, 267);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(35, 267);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Асистенти";
            // 
            // textBox_assistant
            // 
            this.textBox_assistant.Location = new System.Drawing.Point(141, 226);
            this.textBox_assistant.Name = "textBox_assistant";
            this.textBox_assistant.Size = new System.Drawing.Size(100, 20);
            this.textBox_assistant.TabIndex = 26;
            // 
            // Деканат
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_assistant);
            this.Name = "Деканат";
            this.Text = "Deanery";
            this.Controls.SetChildIndex(this.button_Apply, 0);
            this.Controls.SetChildIndex(this.textBox_Unique_number, 0);
            this.Controls.SetChildIndex(this.textBox_Name, 0);
            this.Controls.SetChildIndex(this.textBox_Major, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.textBox_Class, 0);
            this.Controls.SetChildIndex(this.textBox_assistant, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_assistant;
    }
}