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
    public partial class Worker : vovk.Working
    {
        public Worker()
            :base()
        {
            InitializeComponent();
        }
        public Worker(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT post FROM PersonWorkers Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_post.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_post.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_post.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update PersonWorkers Set post= '" + textBox_post.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonWorkers Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_post.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
