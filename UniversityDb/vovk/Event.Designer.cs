namespace vovk
{
    partial class Event
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
            this.textBox_place_action = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_date_action = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Org = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(180, 286);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(113, 286);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(35, 286);
            // 
            // textBox_place_action
            // 
            this.textBox_place_action.Location = new System.Drawing.Point(141, 194);
            this.textBox_place_action.Name = "textBox_place_action";
            this.textBox_place_action.Size = new System.Drawing.Size(100, 20);
            this.textBox_place_action.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Місце проведення";
            // 
            // textBox_date_action
            // 
            this.textBox_date_action.Location = new System.Drawing.Point(141, 168);
            this.textBox_date_action.Name = "textBox_date_action";
            this.textBox_date_action.Size = new System.Drawing.Size(100, 20);
            this.textBox_date_action.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Дата проведення";
            // 
            // textBox_Org
            // 
            this.textBox_Org.Location = new System.Drawing.Point(141, 221);
            this.textBox_Org.Name = "textBox_Org";
            this.textBox_Org.Size = new System.Drawing.Size(100, 20);
            this.textBox_Org.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Організатор";
            // 
            // Подія
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Org);
            this.Controls.Add(this.textBox_place_action);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_date_action);
            this.Controls.Add(this.label2);
            this.Name = "Подія";
            this.Text = "Event";
            this.Controls.SetChildIndex(this.button_Apply, 0);
            this.Controls.SetChildIndex(this.textBox_Unique_number, 0);
            this.Controls.SetChildIndex(this.textBox_Name, 0);
            this.Controls.SetChildIndex(this.textBox_Major, 0);
            this.Controls.SetChildIndex(this.button_OK, 0);
            this.Controls.SetChildIndex(this.button_Cancel, 0);
            this.Controls.SetChildIndex(this.textBox_Class, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox_date_action, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_place_action, 0);
            this.Controls.SetChildIndex(this.textBox_Org, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_place_action;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_date_action;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Org;
        private System.Windows.Forms.Label label1;
    }
}