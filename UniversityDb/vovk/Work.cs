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
    public partial class Work : vovk.Event
    {
        public Work()
        :base()
        {
            InitializeComponent();
        }
        public Work(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT type_of_work FROM EventWork Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_type_of_work.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_type_of_work.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_type_of_work.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update EventWork Set type_of_work= '" + textBox_type_of_work.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into EventWork (id, type_of_work) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_type_of_work.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
