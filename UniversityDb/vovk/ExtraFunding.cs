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
    public partial class ExtraFunding : vovk.Funding
    {
        double place;
        public ExtraFunding()
            :base()
        {
            InitializeComponent();
        }
        public ExtraFunding(TreeNode nnnode, string a, OleDbConnection con)
            :base(nnnode,a,con)
        {
            InitializeComponent();
        }
        protected override void Count()
        {
            base.Count();
            connection.Open();
            command = new OleDbCommand("Select olymp_place From PersonOlymp Where id="+node.Name, connection);
            dr = command.ExecuteReader();
            dr.Read();
            place = dr.GetInt32(0);
            points +=(4-place)*100 ;
            
            label2.Text = (points).ToString();
        }

        private void ExtraFunding_Load(object sender, EventArgs e)
        {

        }
    }
}
