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
    public partial class Study : vovk.Person
    {
        public Study()
            :base()
        {
            InitializeComponent();
        }

        public Study(TreeNode nnnode, string a, OleDbConnection con)
            :base(nnnode,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT secondary_education FROM PersonStuding WHERE id=" + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_secondary_education.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_secondary_education.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_secondary_education.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("UPDATE PersonStuding SET secondary_education ='" + textBox_secondary_education.Text + "'WHERE id=" + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonStuding (id, secondary_education) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_secondary_education.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
