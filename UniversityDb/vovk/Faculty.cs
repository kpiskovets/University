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
    public partial class Faculty : vovk.InstitutionOrg
    {
        public Faculty()
        :base()
        {
            InitializeComponent();
        }
        public Faculty(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT amount_cathedr, amount_groups FROM Faculty Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_amount_cathedr.Text = dr.GetValue(0).ToString();
            textBox_amount_groups.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_amount_cathedr.ReadOnly = textBox_amount_groups.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_amount_cathedr.ReadOnly = textBox_amount_groups.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Faculty Set amount_cathedr= '" + textBox_amount_cathedr.Text + "' , amount_groups = '" + textBox_amount_groups.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Faculty (id, amount_cathedr, amount_groups) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_amount_cathedr.Text) + "', '" + int.Parse(textBox_amount_groups.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
