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
    public partial class UObject : Form
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

        public UObject()
        {
            InitializeComponent();
            
        }

        public UObject(TreeNode nnnode, string a, OleDbConnection con)
        {            
            InitializeComponent();
            node = nnnode;
            action = a;
            connection = con;
        }

        protected virtual void Process()
        {
        }
        protected virtual void Info()
        {
            textBox_Unique_number.Text = node.Name;
            textBox_Name.Text = node.Text;
            if(node.Parent!=null)
                textBox_Major.Text = node.Parent.Text;
            textBox_Class.Text = this.Text;
            textBox_Name.ReadOnly = vizibility;
            //vizibility = true;
        }
       
        protected virtual void Edit()
        {
            connection.Close();
            textBox_Name.ReadOnly = vizibility;
            node.Text = textBox_Name.Text;
            connection.Open();
            command = new OleDbCommand("Update UObject Set name= '" + textBox_Name.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();            
        }

        protected virtual void Insert()
        {
            connection.Open(); 
            command = new OleDbCommand("Select id From Classes Where Name = '" + textBox_Class.Text+"'", connection);
            dr = command.ExecuteReader();
            dr.Read();
            int Class = dr.GetInt32(0);

            command = new OleDbCommand("Insert into UObject (id, name, major, class) Values(" + int.Parse(textBox_Unique_number.Text) + ", '" + textBox_Name.Text.ToString() + "', " + node.Name + ", " + Class + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();
            node.Nodes.Add(textBox_Unique_number.Text, textBox_Name.Text);
            node.Nodes[textBox_Unique_number.Text].Tag = Class;
        }
        

        private void Objects_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Info":
                    {
                        vizibility = true;
                        button_OK.Visible = true;
                        Info();
                        break;
                    }
                case "Edit":
                    {
                        vizibility = false;
                        button_Apply.Visible = true;
                        button_Cancel.Visible = true;
                        Info();
                        break;
                    }
                case "Insert":
                    {
                        connection.Open();
                        command = new OleDbCommand("Select Max(id) From UObject ", connection);
                        dr = command.ExecuteReader();
                        dr.Read();
                        textBox_Unique_number.Text = (dr.GetInt32(0) + 1).ToString();
                        connection.Close();
                        textBox_Major.Text = node.Text;
                        textBox_Class.Text = this.Text;
                        vizibility = false;
                        button_Apply.Visible = true;
                        button_Cancel.Visible = true;
                        break;
                    }
                
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Edit":
                    {
                        Edit();
                        break;
                    }
                case "Insert":
                    {
                        Insert();
                        break;
                    }
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    
    }
}
