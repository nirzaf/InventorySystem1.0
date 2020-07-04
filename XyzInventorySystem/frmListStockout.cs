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
    public partial class frmListStockout : Form
    {
        public frmListStockout()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void frmListStockout_Load(object sender, EventArgs e)
        {
            sql = "SELECT  `TRANSACTIONNUMBER` as ID,concat(`FIRSTNAME`, `LASTNAME`) as 'CUSTOMER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE`, `TRANSACTIONDATE` as DATE, o.`QTY`, `TOTALPRICE` FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE REMARKS='StockOut' and i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'" +
              " AND (NAME like '%" + txtsearch.Text + "%' OR  TRANSACTIONNUMBER like '%" + txtsearch.Text + "%')";
            config.Load_DTG(sql, dtglist);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            frmListStockout_Load(sender, e);
        }
    }
}
