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
    public partial class Equipment : vovk.MaterialObject
    {
        public Equipment()
          :base()
        {
            InitializeComponent();
        }
        public Equipment(TreeNode nnnode, string a, OleDbConnection con)
            :base(nnnode,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT status FROM Equipment Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_status.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_status.ReadOnly = vizibility;
        }

        

        protected override void Edit()
        {
            base.Edit();
            textBox_status.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Equipment Set status= '" + textBox_status.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Equipment (id, status) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_status.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
