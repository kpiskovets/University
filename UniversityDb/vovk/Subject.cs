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
    public partial class Subject : vovk.UObject
    {
        public Subject()
         :base()
        {
            InitializeComponent();
        }
        public Subject(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT teachers FROM Subject Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_teachers.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_teachers.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_teachers.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Subject Set teachers= '" + textBox_teachers.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Subject (id, teachers) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_teachers.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
