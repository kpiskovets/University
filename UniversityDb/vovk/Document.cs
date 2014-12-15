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
    public partial class Document : vovk.MaterialObject
    {
        public Document()
         :base()
        {
            InitializeComponent();
        }
        public Document(TreeNode node, string a, OleDbConnection c)
            :base(node,a,c)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT author FROM Document Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_author.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_author.ReadOnly  = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_author.ReadOnly =  false;
            connection.Open();
            command = new OleDbCommand("Update Document Set author= '" + textBox_author.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Document (id, author) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_author.Text.ToString() +  "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
