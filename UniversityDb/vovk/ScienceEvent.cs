﻿using System;
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
    public partial class ScienceEvent : vovk.Event
    {
        public ScienceEvent()
            :base()
        {
            InitializeComponent();
        }
        public ScienceEvent(TreeNode node, string a, OleDbConnection con)
            :base(node,a,con)
        {
            InitializeComponent();
        }

        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT theme FROM EventSport Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_theme.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_theme.ReadOnly =  vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_theme.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update EventSport Set theme= '" + textBox_theme.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into EventSport (id, theme) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_theme.Text.ToString() +  "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
