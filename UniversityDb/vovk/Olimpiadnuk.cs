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
    public partial class Olimpiadnuk : vovk.Entrant
    {
        public Olimpiadnuk()
            :base()
        {
            InitializeComponent();
        }
        public Olimpiadnuk(TreeNode nnnode, string a, OleDbConnection con)
            :base(nnnode,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT olymp_place from PersonOlymp Where id=" + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_olymp_place.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_olymp_place.ReadOnly = vizibility;
        }
        protected override void Edit()
        {
            base.Edit();
            textBox_olymp_place.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update PersonOlymp Set olymp_place= '" + textBox_olymp_place.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonOlymp (id, olymp_place) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_olymp_place.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
