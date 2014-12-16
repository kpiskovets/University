using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vovk
{
    public partial class Form1 : Form
    {
        SimpleTreeView stvTreeView;
        public OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orodr_000\Dropbox\UniversityDb\Database1.accdb");
        OleDbCommand command;
        DataSet ds = new DataSet("University");
        DataTable Classes = new DataTable();
        DataTable dt = new DataTable();
        OleDbDataReader dr;
        TreeNode nodeMain;
        string form_class;
        string child;
        string[] children;
        
       
        
        public Form1()
        {
            InitializeComponent();
            stvTreeView = new SimpleTreeView(new SimpleDataSet());
            this.Controls.Add(stvTreeView);
            stvTreeView.LineColor = Color.Green;
            stvTreeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(stvTreeView_NodeMouseClick);
            ContextMenuShow(stvTreeView);
            
            
            
        }
        public void ContextMenuShow(SimpleTreeView stv)
        {

            stv.ContextMenuStrip = contextMenuStrip1;
            /*foreach (TreeNode RootNode in stv.Nodes)
            {
                RootNode.ContextMenuStrip = contextMenuStrip1;
                foreach (TreeNode ChildNode in RootNode.Nodes)
                {
                    ChildNode.ContextMenuStrip = contextMenuStrip1;
                    foreach (TreeNode ChildNode1 in ChildNode.Nodes)
                    {
                        ChildNode1.ContextMenuStrip = contextMenuStrip1;

                    }
                }


            }*/


        }
        private void stvTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            nodeMain = e.Node;
            connection.Close();
            connection.Open();
            command = new OleDbCommand("Select Name, Children From Classes Where ID = " + "(Select class From UObject Where id = " + nodeMain.Name + ")", connection);
            dr = command.ExecuteReader();
            dr.Read();
            form_class = dr.GetValue(0).ToString();
            child = dr.GetValue(1).ToString();
            
            connection.Close();
            if (e.Button == MouseButtons.Right)
            {
                
                stvTreeView.SelectedNode = e.Node;
                addMenuItems(contextMenuStrip1, stvTreeView);

            }
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Width = 550;
            Form f;
            Type t = Type.GetType("vovk." + form_class);

            f = (Form)Activator.CreateInstance(t, nodeMain, "Edit", connection);
            f.ShowDialog();
        }
        private void addMenuItems(ContextMenuStrip s,SimpleTreeView st)
        {
            //foreach (ToolStripMenuItem item in s.Items)
            
                for (int i = 0; i < s.Items.Count;i++ )
                    if ((string)s.Items[i].Tag == "set_default")
                    {
                        s.Items.Remove(s.Items[i]);
                    }
            
            string[] strList;
            connection.Close();
            connection.Open();
            command = new OleDbCommand("Select Name From Classes_func Where ID = " + "(Select class From UObject Where id = " + nodeMain.Name + ")", connection);
            dr = command.ExecuteReader();
            dr.Read();
            string text="";
            if (dr.HasRows)
            {
                text = dr.GetString(0);
                strList = text.Split(' ');


                //MessageBox.Show(test);
                ToolStripMenuItem[] items = new ToolStripMenuItem[strList.Count()];

                for (int i = 0; i < strList.Count(); i++)
                {
                    
                    items[i] = new ToolStripMenuItem();
                    items[i].Text = strList[i];
                    items[i].Tag = "set_default";
                    items[i].Click += new EventHandler(insertFuncClick);

                }
                s.Items.AddRange(items);
            }
            connection.Close();
            
        }

        private void addInsertMenuItems(ContextMenuStrip s, SimpleTreeView st)
        {
            (s.Items[2] as ToolStripMenuItem).DropDownItems.Clear();
            List<string> stt=new List<string>();
            if (child != "")
            {
                
                children = child.Split(' ');
                connection.Open();
                for (int i = 0; i < children.Count(); i++)
                {
                    command = new OleDbCommand("Select Name From Classes Where ID = " + int.Parse(children[i]), connection);
                    dr = command.ExecuteReader();
                    dr.Read();
                    stt.Add(dr.GetString(0));
                }
                
                dr.Close();
                connection.Close();

                
                ToolStripMenuItem[] items = new ToolStripMenuItem[children.Count()];

                for (int i = 0; i < children.Count(); i++)
                {
                    items[i] = new ToolStripMenuItem();
                    items[i].Text = stt[i];
                    items[i].Click += new EventHandler(insertClick);


                }
                (s.Items[2] as ToolStripMenuItem).DropDownItems.AddRange(items);
            }
            
            

            
            
        }
        private void insertFuncClick(object sender, EventArgs e)
        {
            Form f;
            ToolStripItem clickedItem = sender as ToolStripItem;
            string clickedMenuItem = clickedItem.Text;
            Type t = Type.GetType("vovk." + clickedMenuItem);
            f = (Form)Activator.CreateInstance(t, nodeMain, "Count", connection);
            f.Show();

        }
        private void insertClick(object sender, EventArgs e)
        {     
            Form f;
            ToolStripItem clickedItem = sender as ToolStripItem;
            string clickedMenuItem = clickedItem.Text;
            Type t = Type.GetType("vovk." + clickedMenuItem);
            f = (Form)Activator.CreateInstance(t, nodeMain, "Insert", connection);
            f.Show();
            
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void insertToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            addInsertMenuItems(contextMenuStrip1, stvTreeView);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nodeMain.Nodes.Count > 0)
            {
                if (MessageBox.Show("Вузол  '" + nodeMain.Text + "' не пустий.Ви впевнені що хочете його видалити?", "Видалити", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Delete(nodeMain);
            }
            else
            {
                if (MessageBox.Show("Ви впевнені що хочете видалити вузол '" + nodeMain.Text + "'?", "Видалити", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Delete(nodeMain);
            }
        }
        private void Delete(TreeNode node)
        {
            while (node.Nodes.Count != 0)
            {
                Delete(node.Nodes[0]);
            }

            connection.Open();
            command = new OleDbCommand("DELETE FROM UObject Where id = " + node.Name, connection);
            command.ExecuteNonQuery();
            connection.Close();

            node.Remove();
        }
    }
}
