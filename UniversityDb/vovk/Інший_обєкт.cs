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
    public partial class Інший_обєкт : vovk.MaterialObject
    {
        public Інший_обєкт()
       :base()
        {
            InitializeComponent();
        }
        public Інший_обєкт(TreeNode node, string a, OleDbConnection con)
            : base(node, a, con)
        {
            InitializeComponent();
        }
        protected override void Info()
        {
            base.Info();
            connection.Open();
            command = new OleDbCommand("SELECT desc FROM OtherMaterialObject Where id = " + node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            textBox_desc.Text = dr.GetValue(0).ToString();
            connection.Close();
            textBox_desc.ReadOnly = vizibility;
        }

        protected override void Edit()
        {
            base.Edit();
            textBox_desc.ReadOnly = false;
            connection.Open();
            command = new OleDbCommand("Update OtherMaterialObject Set desc= '" + textBox_desc.Text + "' Where id= " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected override void Insert()
        {
            base.Insert();
            connection.Open();
            command = new OleDbCommand("Insert into OtherMaterialObject (id, desc) Values(" + int.Parse(node.Nodes[node.Nodes.Count - 1].Name) + ", '" + textBox_desc.Text.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
