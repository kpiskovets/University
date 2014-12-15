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
    public partial class University : vovk.InstitutionOrg
    {
        public University()
        :base()
        {
            InitializeComponent();
        }
        public University(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT accredetation FROM Universities Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_accredetation.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_accredetation.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_accredetation.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Universities Set accredetation= '" + textBox_accredetation.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Universities (id, accredetation) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_accredetation.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
