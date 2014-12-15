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
    public partial class Territory : vovk.Institution
    {
        public Territory()
            :base()
        {
            InitializeComponent();
        }
         public Territory(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT area FROM Territory Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_area.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_area.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_area.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Territory Set area= '" + textBox_area.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Territory (id, area) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_area.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
