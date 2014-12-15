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
    public partial class Test : vovk.ScienceEvent
    {
        public Test()
        :base()
        {
            InitializeComponent();
        }
        public Test(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT max_mark FROM EventCultural Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_max_mark.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_max_mark.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_max_mark.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update EventCultural Set max_mark= '" + textBox_max_mark.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into EventCultural (id, max_mark) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_max_mark.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
