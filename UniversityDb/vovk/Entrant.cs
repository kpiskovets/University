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
    public partial class Entrant : vovk.Study
    {
        public Entrant()
            :base()
        {
            InitializeComponent();
        }
        public Entrant(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT zno_points FROM PersonEntrants Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_zno_points.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_zno_points.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_zno_points.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update PersonEntrants Set zno_points= '" + textBox_zno_points.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonEntrants (id, zno_points) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_zno_points.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
