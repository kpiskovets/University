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
    public partial class InstitutionOrg : vovk.Institution
    {
        List<String> s = new List<string>();
        public InstitutionOrg()
            : base()
        {
            InitializeComponent();
        }
        public InstitutionOrg(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {

            InitializeComponent();
            LoadComboBox();
        }
        public void LoadComboBox()
        {
            connection.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT name FROM UObject Where Class= 32", connection);
            da.Fill(dt);
            
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row.ItemArray[0]);
            }
            connection.Close();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT chief FROM InstitutionOrg Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            comboBox1.SelectedItem = dr.GetValue(0).ToString();
            textBox_chief.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_chief.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_chief.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update InstitutionOrg Set chief= '" + textBox_chief.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into InstitutionOrg (id, chief) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + comboBox1.SelectedItem.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
