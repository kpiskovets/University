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
    public partial class Collective : vovk.InstitutionOrg
    {
        public Collective()
         :base()
        {
            InitializeComponent();
        }
        public Collective(TreeNode nide, string a, OleDbConnection con)
            :base(nide,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT activity, [amount] FROM Collective Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_activity.Text = dr.GetValue(0).ToString();
            textBox_amount.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_activity.ReadOnly = textBox_amount.ReadOnly= vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_activity.ReadOnly = textBox_amount.ReadOnly= false;
            connection.Open();
            command = new OleDbCommand("Update Collective Set activity= '" + textBox_activity.Text + "', [amount]='"+textBox_amount.Text+"' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Collective (id, activity,[amount]) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_activity.Text.ToString() + "', '" + int.Parse(textBox_amount.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
