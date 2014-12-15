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
    public partial class Teaching : vovk.Working
    {
        public Teaching()
            :base()
        {
            InitializeComponent();
        }

        public Teaching(TreeNode nnnode, string a, OleDbConnection con)
            :base(nnnode,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT subject FROM PersonTeaching Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_subject.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_subject.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_subject.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update PersonTeaching Set subject= '" + textBox_subject.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonTeaching (id, subject) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_subject.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
