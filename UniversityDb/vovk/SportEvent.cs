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
    public partial class SportEvent : vovk.Event
    {
        public SportEvent()
            :base()
        {
            InitializeComponent();
        }
        public SportEvent(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT sport,referee FROM EventSport Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_sport.Text = dr.GetValue(0).ToString();
            textBox_referee.Text = dr.GetValue(1).ToString();
            connection.Close();
            textBox_sport.ReadOnly = textBox_referee.ReadOnly  = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_sport.ReadOnly = textBox_referee.ReadOnly  = false;
            connection.Open();
            command = new OleDbCommand("Update EventSport Set sport= '" + textBox_sport.Text + "' , referee = '" + textBox_referee.Text +  "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into EventSport (id, sport, referee) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_sport.Text.ToString() + "', '" + textBox_referee.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
