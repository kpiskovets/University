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
    public partial class Deanery : vovk.InstitutionOrg
    {
        public Deanery()
           :base()
        {
            InitializeComponent();
        }
        public Deanery(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT assistant FROM Deanery Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_assistant.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_assistant.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_assistant.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Deanery Set assistant= '" + textBox_assistant.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Deanery (id, assistant) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_assistant.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
