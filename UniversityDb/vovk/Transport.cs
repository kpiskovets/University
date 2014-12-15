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
    public partial class Transport : vovk.MaterialObject
    {
        public Transport()
         : base()
        {
            InitializeComponent();
        }
        public Transport(TreeNode nnnode, string a, OleDbConnection con)
            : base(nnnode, a, con)
        {
            InitializeComponent();
        }

        protected override void Process()
        {
            base.Process();

            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Transport (id, [number],[type]) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_number.Text.ToString() + "', '" + textBox_type.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT  [number], type,price FROM Transport Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_type.Text = dr.GetValue(1).ToString();
            textBox_number.Text = dr.GetValue(0).ToString();
            textBox1.Text = dr.GetValue(2).ToString();
            textBox_type.ReadOnly = textBox_number.ReadOnly =textBox1.ReadOnly= vizibility;
            connection.Close();
            //Perevirka();
        }

        
       
        
        protected override void Edit()
        {
            base.Edit();
            textBox_type.ReadOnly = textBox_number.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Transport Set [number]= '" + textBox_number.Text + "' , [type] = '" + textBox_type.Text +"' , price = '"+textBox1.Text+ "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Transport (id, [number],[type],price) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_number.Text.ToString() + "', '" + textBox_type.Text +"', '"+Convert.ToDouble(textBox1.Text)+ "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
