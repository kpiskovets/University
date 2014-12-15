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
    public partial class Funding : Form
    {
        protected TreeNode node;
        protected string action; 
        protected OleDbConnection connection;
        protected OleDbCommand command;
        protected OleDbCommand command1,command2,command3;
        protected OleDbCommandBuilder builder;
        protected OleDbDataAdapter adapter;
        protected DataTable dt = new DataTable();
        protected DataSet ds = new DataSet();
        protected OleDbDataReader dr;
        protected OleDbDataReader dr1;
        protected bool vizibility = true;
        public double points;
        public Funding()
        {
            InitializeComponent();
        }
        public Funding(TreeNode nnnode,string a, OleDbConnection con)
        {
            InitializeComponent();
            node = nnnode;
            action = a;
            connection = con;
        }

        protected virtual void Count()
        {
            connection.Open();
            command = new OleDbCommand("Select zno_points From PersonEntrants Where id="+node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            points = dr.GetInt32(0);
            points *= 1.5;
            label2.Text = (points).ToString();
            connection.Close();
            //connection.Open();
            //command = new OleDbCommand("Insert into Funding (Id, funding) Values(" + int.Parse(node.Name) + ", '"+label2.Text+ ")", connection);
            //command.ExecuteNonQuery();
            //connection.Close();
            
        }
        private void Funding_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                
                case "Count":
                    {
                        Count();
                        
                        break;
                    }
            }

        }
    }
}
