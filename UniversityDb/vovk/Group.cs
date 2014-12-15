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
    public partial class Group : vovk.InstitutionOrg
    {
        public Group()
         :base()
        {
            InitializeComponent();
        }
        public Group(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT [amount], curator FROM Group Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_amount.Text = dr.GetValue(0).ToString();
            textBox_curator.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_amount.ReadOnly = textBox_curator.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_amount.ReadOnly = textBox_curator.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update [Group] Set amount= '" + textBox_amount.Text + "' , curator = '" + textBox_curator.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into [Group] (id, [amount], curator) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_amount.Text) + "', '" + textBox_curator.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
