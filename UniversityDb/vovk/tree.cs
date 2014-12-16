using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using System.Xml;

public class SimpleTreeView : TreeView
{


    SimpleDataSet sdsData;

    public SimpleTreeView(SimpleDataSet Data)
        : base()
    {

        sdsData = Data;

        this.Dock = DockStyle.Left;
        this.Width = 400;
        

        CreateNodesOfParent(0, (TreeNode)null);
    }


    public void CreateNodesOfParent(int iParent, TreeNode pNode)
    {
        for (int i = 0; i < sdsData.Tables.Count; i++)
        {
            DataView dvwData = new DataView(sdsData.Tables[i]);

            dvwData.RowFilter = "[major] = " + iParent;

            foreach (DataRowView Row in dvwData)
            {

                if (pNode == null)
                {
                    TreeNode zNode = this.Nodes.Add(Row["id"].ToString(), Row["name"].ToString());
                    CreateNodesOfParent(Int32.Parse(Row["id"].ToString()), zNode);
                }
                else
                {
                    TreeNode zNode = pNode.Nodes.Add(Row["id"].ToString(), Row["name"].ToString());
                    CreateNodesOfParent(Int32.Parse(Row["id"].ToString()), zNode);
                }
                this.ForeColor = Color.Green;
            }
        }
    }
}
