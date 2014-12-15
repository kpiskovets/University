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
    public partial class Aspirant : vovk.Teaching
    {
        public Aspirant()
        :base()
        {
            InitializeComponent();
        }
        public Aspirant(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT years  FROM PersonGraduateStudents Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_years.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_years.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_years.ReadOnly  = false;
            connection.Open();
            command = new OleDbCommand("Update PersonGraduateStudents Set years= '" + textBox_years.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into PersonGraduateStudents (id, years ) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + int.Parse(textBox_years.Text) +  "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
