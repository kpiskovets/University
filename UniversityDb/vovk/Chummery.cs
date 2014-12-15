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
    public partial class Chummery : vovk.Building
    {
        public Chummery()
            :base()
        {
            InitializeComponent();
        }
        public Chummery(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT comendant, faculty FROM Chummery Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_comendant.Text = dr.GetValue(0).ToString();
            textBox_faculty.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_comendant.ReadOnly = textBox_faculty.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_comendant.ReadOnly = textBox_faculty.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Chummery Set comendant= '" + textBox_comendant.Text + "' , faculty = '" + textBox_faculty.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Chummery (id, comendant, faculty) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_comendant.Text.ToString() + "', '" + textBox_faculty.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
