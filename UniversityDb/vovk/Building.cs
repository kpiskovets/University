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
    public partial class Building : vovk.Institution
    {
        public Building()
            : base()
        {
            InitializeComponent();
        }
        public Building(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT  rooms FROM Buildings Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_rooms.Text = dr.GetValue(0).ToString();

            connection.Close();
            textBox_rooms.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_rooms.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Buildings Set rooms= '" + textBox_rooms.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Buildings (id, rooms) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_rooms.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
