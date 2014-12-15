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
    public partial class Classroom : vovk.Institution
    {
        public Classroom()
            :base()
        {
            InitializeComponent();
        }
        public Classroom(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT seats FROM ClassRoom Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_seats.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_seats.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_seats.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update ClassRoom Set seats= '" + textBox_seats.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into ClassRoom (id, seats) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse( textBox_seats.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
