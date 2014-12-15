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
    public partial class Rectorat : vovk.InstitutionOrg
    {
        public Rectorat()
         :base()
        {
            InitializeComponent();
        }
        public Rectorat(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT prorectors FROM Rectorat Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_prorectors.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_prorectors.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_prorectors.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Rectorat Set prorectors = '" + textBox_prorectors.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Rectorat (id, prorectors) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_prorectors.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
