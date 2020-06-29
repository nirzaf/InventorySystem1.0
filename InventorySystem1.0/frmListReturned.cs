using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem1._0.Includes;

namespace InventorySystem1._0
{
    public partial class frmListReturned : Form
    {
        public frmListReturned()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void frmListReturned_Load(object sender, EventArgs e)
        {
            sql = "SELECT concat(`FIRSTNAME`, `LASTNAME`) as 'FULLNAME',`STOCKRETURNNUMBER` as 'TRANSACTION#',`NAME` as 'ITEMNAME', `RETURNDATE` FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ITEMID`=r.`ITEMID` and r.`OWNER_CUS_ID` =p.`SUPLIERCUSTOMERID` and p.TYPE not in ('Suplier')" +
                 " AND STOCKRETURNNUMBER LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtglist);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            frmListReturned_Load(sender, e);
        }
    }
}
