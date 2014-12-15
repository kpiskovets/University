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
    public partial class Department : vovk.InstitutionOrg
    {
        public Department()
        :base()
        {
            InitializeComponent();
        }
        public Department(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT specialization, employees FROM [Cathedra] Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_specialization.Text = dr.GetValue(0).ToString();
            textBox_employees.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_specialization.ReadOnly = textBox_employees.ReadOnly= vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_specialization.ReadOnly = textBox_employees.ReadOnly =  false;
            connection.Open();
            command = new OleDbCommand("Update Cathedra Set specialization= '" + textBox_specialization.Text + "', employees='" + textBox_employees.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Cathedra (id, specialization,employees) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_specialization.Text + "', '" + int.Parse(textBox_employees.Text) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
