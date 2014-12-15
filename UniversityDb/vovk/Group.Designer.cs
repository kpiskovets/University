namespace vovk
{
    partial class Group
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
            this.textBox_curator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(194, 298);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(127, 298);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(49, 298);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Куратор";
            // 
            // textBox_curator
            // 
            this.textBox_curator.Location = new System.Drawing.Point(141, 252);
            this.textBox_curator.Name = "textBox_curator";
            this.textBox_curator.Size = new System.Drawing.Size(100, 20);
            this.textBox_curator.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Кількість студентів";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(141, 226);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount.TabIndex = 26;
            // 
            // Група
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_curator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_amount);
            this.Name = "Група";
            this.Text = "Group";
            this.Controls.SetChildIndex(this.button_Apply, 0);
            this.Controls.SetChildIndex(this.textBox_Unique_number, 0);
            this.Controls.SetChildIndex(this.textBox_Name, 0);
            this.Controls.SetChildIndex(this.textBox_Major, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.textBox_Class, 0);
            this.Controls.SetChildIndex(this.textBox_amount, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_curator, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_curator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_amount;
    }
}