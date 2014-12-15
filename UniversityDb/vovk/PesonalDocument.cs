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
    public partial class PesonalDocument : vovk.Document
    {
        public PesonalDocument()
        :base()
        {
            InitializeComponent();
        }
        public PesonalDocument(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT [number] FROM DocumentPersonal Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox1.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox1.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox1.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update DocumentPersonal Set [number]= '" + textBox1.Text  + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into DocumentPersonal (id, [number]) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox1.Text.ToString()  + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
