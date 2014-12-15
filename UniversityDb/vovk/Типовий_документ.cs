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
    public partial class Типовий_документ : vovk.Document
    {
        public Типовий_документ()
        :base()
        {
            InitializeComponent();
        }
        public Типовий_документ(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT doc_type FROM DocumentGeneral Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_doc_type.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_doc_type.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_doc_type.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update DocumentGeneral Set doc_type= '" + textBox_doc_type.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into DocumentGeneral (id, doc_type) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_doc_type.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
