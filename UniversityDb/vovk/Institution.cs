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
    public partial class Institution : vovk.UObject
    {
        public Institution()
            :base()
        {
            InitializeComponent();
        }
        public Institution(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT adress FROM Institution Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_adress.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_adress.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_adress.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Institution Set adress= '" + textBox_adress.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Institution (id,adress) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_adress.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
