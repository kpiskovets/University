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
    public partial class Event : vovk.UObject
    {
        public Event()
       :base()
        {
            InitializeComponent();
        }
        public Event(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT date_action, place_action, organisator FROM Events Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_date_action.Text = dr.GetValue(0).ToString();
            textBox_place_action.Text = dr.GetValue(1).ToString();
            textBox_Org.Text = dr.GetValue(2).ToString();
            connection.Close();
            textBox_date_action.ReadOnly = textBox_place_action.ReadOnly = textBox_Org.ReadOnly=vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_date_action.ReadOnly = textBox_place_action.ReadOnly = textBox_Org.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update Events Set action_date= '" + textBox_date_action.Text + "' , place_action = '" + textBox_place_action.Text + "' , organisator = '" + textBox_Org.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into Events (id, date_action,place_action,organisator) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_date_action.Text.ToString() + "', '" + textBox_place_action.Text.ToString() +"', '" + textBox_Org.Text.ToString()+ "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
