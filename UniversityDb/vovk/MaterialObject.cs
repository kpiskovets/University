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
    public partial class MaterialObject : vovk.UObject
    {
        public MaterialObject()
        :base()
        {
            InitializeComponent();
        }
        public MaterialObject(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

                
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT  date_creation FROM MaterialObject Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_date_creation.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_date_creation.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_date_creation.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update MaterialObject Set date_creation = '" + textBox_date_creation.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into MaterialObject (id, date_creation) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_date_creation.Text.ToString() +  "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
