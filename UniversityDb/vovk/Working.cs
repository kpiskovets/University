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
    public partial class Working : vovk.Person
    {
        public Working()
            :base()
        {
            InitializeComponent();
        }

        public Working(TreeNode nnnode, string a, OleDbConnection con)
            :base(nnnode,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT experience, salary FROM PersonWorking Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_experience.Text = dr.GetValue(0).ToString();
            textBox_salary.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_experience.ReadOnly = textBox_salary.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_experience.ReadOnly = textBox_salary.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update PersonWorking Set experience= '" + textBox_experience.Text + "' , salary = '" + textBox_salary.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonWorking (id, experience, salary) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_experience.Text.ToString() + "', '" + textBox_salary.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
