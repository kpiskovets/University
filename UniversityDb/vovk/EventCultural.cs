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
    public partial class EventCultural : vovk.Event
    {
        public EventCultural()
         :base()
        {
            InitializeComponent();
        }
        public EventCultural(TreeNode node, string a, OleDbConnection con)
            :base(node,a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT Occasion FROM EventCultural Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_reason.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_reason.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_reason.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update EventCultural Set reason= '" + textBox_reason.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into EventCultural (id, reason) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_reason.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
