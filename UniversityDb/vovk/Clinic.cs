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
    public partial class Clinic : vovk.Building
    {
        public Clinic()
            :base()
        {
            InitializeComponent();
        }
        public Clinic(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT amount_doctors, doctors FROM Clinic Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_amount_doctors.Text = dr.GetValue(0).ToString();
            textBox_doctors.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_amount_doctors.ReadOnly = textBox_doctors.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_amount_doctors.ReadOnly = textBox_doctors.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Clinic Set amount_doctors= '" + textBox_amount_doctors.Text + "' , doctors = '" + textBox_doctors.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Clinic (id, amount_doctors, doctors) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_amount_doctors.Text) + "', '" + textBox_doctors.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
