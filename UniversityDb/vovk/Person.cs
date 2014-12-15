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
    public partial class Person : vovk.UObject
    {
        public Person()
            :base()
        {
            InitializeComponent();
        }

        public Person(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT sex , birthday FROM Person Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            comboBox_sex.Text = dr.GetString(0);
            textBox_birthday.Text = dr.GetValue(1).ToString();
            connection.Close();
            comboBox_sex.Enabled = !vizibility;
            textBox_birthday.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            comboBox_sex.Enabled = true;
            textBox_birthday.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Person Set sex= '" + comboBox_sex.Text + "' , birthday = '" + textBox_birthday.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Person (id, sex, birthday) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + comboBox_sex.Text.ToString() + "', '" + textBox_birthday.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
 
}
