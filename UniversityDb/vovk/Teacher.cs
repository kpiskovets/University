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
    public partial class Teacher : vovk.Teaching
    {
        public Teacher()
            :base()
        {
            InitializeComponent();
        }
        public Teacher(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT academic_degree FROM PersonTeachers Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_academic_degree.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_academic_degree.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_academic_degree.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update PersonTeachers Set academic_degree= '" + textBox_academic_degree.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonTeachers (id, academic_degree) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_academic_degree.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
