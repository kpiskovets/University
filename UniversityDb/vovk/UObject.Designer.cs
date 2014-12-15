namespace vovk
{
    partial class UObject
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
            this.textBox_Class = new System.Windows.Forms.TextBox();
            this.label_Class = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Major = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Unique_number = new System.Windows.Forms.TextBox();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Unique_number = new System.Windows.Forms.Label();
            this.button_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Class
            // 
            this.textBox_Class.Location = new System.Drawing.Point(141, 142);
            this.textBox_Class.Name = "textBox_Class";
            this.textBox_Class.ReadOnly = true;
            this.textBox_Class.Size = new System.Drawing.Size(100, 20);
            this.textBox_Class.TabIndex = 20;
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Location = new System.Drawing.Point(43, 145);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(35, 13);
            this.label_Class.TabIndex = 21;
            this.label_Class.Text = "Клас:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(180, 185);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(69, 23);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Відмінити";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Visible = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Location = new System.Drawing.Point(113, 185);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(61, 23);
            this.button_OK.TabIndex = 11;
            this.button_OK.Text = "ok";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Visible = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_Major
            // 
            this.textBox_Major.Location = new System.Drawing.Point(141, 112);
            this.textBox_Major.Name = "textBox_Major";
            this.textBox_Major.ReadOnly = true;
            this.textBox_Major.Size = new System.Drawing.Size(100, 20);
            this.textBox_Major.TabIndex = 19;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(141, 82);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 18;
            // 
            // textBox_Unique_number
            // 
            this.textBox_Unique_number.Location = new System.Drawing.Point(141, 52);
            this.textBox_Unique_number.Name = "textBox_Unique_number";
            this.textBox_Unique_number.ReadOnly = true;
            this.textBox_Unique_number.Size = new System.Drawing.Size(100, 20);
            this.textBox_Unique_number.TabIndex = 17;
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(43, 115);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(58, 13);
            this.label_Major.TabIndex = 16;
            this.label_Major.Text = "Головний:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(43, 85);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(42, 13);
            this.label_Name.TabIndex = 15;
            this.label_Name.Text = "Назва:";
            // 
            // label_Unique_number
            // 
            this.label_Unique_number.AutoSize = true;
            this.label_Unique_number.Location = new System.Drawing.Point(43, 55);
            this.label_Unique_number.Name = "label_Unique_number";
            this.label_Unique_number.Size = new System.Drawing.Size(18, 13);
            this.label_Unique_number.TabIndex = 14;
            this.label_Unique_number.Text = "id:";
            // 
            // button_Apply
            // 
            this.button_Apply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Apply.Location = new System.Drawing.Point(35, 185);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(72, 23);
            this.button_Apply.TabIndex = 12;
            this.button_Apply.Text = "Прийняти";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Visible = false;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // UObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_Class);
            this.Controls.Add(this.label_Class);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_Major);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Unique_number);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Unique_number);
            this.Controls.Add(this.button_Apply);
            this.Name = "UObject";
            this.Text = "UObject";
            this.Load += new System.EventHandler(this.Objects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_Class;
        private System.Windows.Forms.Label label_Class;
        protected System.Windows.Forms.Button button_Cancel;
        protected System.Windows.Forms.Button button_OK;
        public System.Windows.Forms.TextBox textBox_Major;
        public System.Windows.Forms.TextBox textBox_Name;
        public System.Windows.Forms.TextBox textBox_Unique_number;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Unique_number;
        protected System.Windows.Forms.Button button_Apply;
    }
}