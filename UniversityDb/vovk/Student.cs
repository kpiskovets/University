using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vovk
{
    public partial class Student : vovk.Study
    {
        public Student()
            :base()
        {
            InitializeComponent();
        }
        public Student(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT studing_form, entry_year FROM PersonStudents Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_studing_form.Text = dr.GetValue(0).ToString();
            textBox_entry_year.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_studing_form.ReadOnly = textBox_entry_year.ReadOnly= vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_studing_form.ReadOnly = textBox_entry_year.ReadOnly= false;
            connection.Open();
            command = new OleDbCommand("Update PersonStudents Set studing_form= '" + textBox_studing_form.Text + "', entry_year='" + textBox_entry_year.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonStudents (id, studing_form, entry_year) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_studing_form.Text.ToString() + "', '" + int.Parse(textBox_entry_year.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
