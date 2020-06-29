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
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql, custormerid;

        private void frmReturn_Load(object sender, EventArgs e)
        {
            sql = "SELECT `TRANSACTIONNUMBER` FROM `tblstock_in_out` WHERE  `REMARKS`='Stockout'";
            config.autocomplete(sql, txttransactionid); 
        }

        private void btnreturnadd_Click(object sender, EventArgs e)
        {
     
            if (dtCus_addedlist.RowCount == 0)
            {

                string[] row = new string[] { dtgCus_itemlist.CurrentRow.Cells[0].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[1].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[2].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[5].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[6].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[7].Value.ToString()};

                dtCus_addedlist.Rows.Add(row);


            }
            else
            {
                foreach (DataGridViewRow r in dtCus_addedlist.Rows)
                {
                    if (dtgCus_itemlist.CurrentRow.Cells[0].Value == r.Cells[0].Value)
                    {
                        MessageBox.Show("Item is already in the cart", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (dtCus_addedlist.CurrentRow.Cells[0].Value != dtgCus_itemlist.CurrentRow.Cells[0].Value)
                {

                    string[] row = new string[] { dtgCus_itemlist.CurrentRow.Cells[0].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[1].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[2].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[5].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[6].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[7].Value.ToString()};
                    dtCus_addedlist.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("Item is already in the cart", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }



            }
        }

        private void dtCus_addedlist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total;
            if (dtCus_addedlist.CurrentCell.ColumnIndex == 4)
            {
                foreach (DataGridViewRow row in dtCus_addedlist.Rows)
                {
                    total = double.Parse(row.Cells[4].Value.ToString()) * double.Parse(row.Cells[3].Value.ToString());
                    row.Cells[5].Value = total;
                }
            }
        }

        private void btnreturn_save_Click(object sender, EventArgs e)
        {
            string tranid;

            config.singleResult("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6");
            tranid = config.dt.Rows[0].Field<string>(0);

            if (txttransactionid.Text == "")
            {
                MessageBox.Show("There are empty fields left that must be fill up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtCus_addedlist.RowCount == 0)
            {
                MessageBox.Show("Cart is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sql = "SELECT `ITEMID`, `QTY` FROM `tblstock_in_out` WHERE  `TRANSACTIONNUMBER` ='" + txttransactionid.Text + "'";
            config.singleResult(sql);

            foreach (DataRow row in config.dt.Rows)
            {
                for (int i = 0; i < dtCus_addedlist.Rows.Count; i++)
                {
                    if (dtCus_addedlist.Rows[i].Cells[0].Value.ToString() == row.Field<string>(0))
                    {
                        if (int.Parse(dtCus_addedlist.Rows[i].Cells[4].Value.ToString()) > row.Field<int>(1))
                        {
                            MessageBox.Show("The returned quantity of the item ( " + dtCus_addedlist.Rows[i].Cells[1].Value.ToString() + " ) is greater than the available quantity of it.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    if (dtCus_addedlist.Rows[i].Cells[4].Value.ToString() == "")
                    {
                        MessageBox.Show("Set your purpose.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            foreach (DataGridViewRow r in dtCus_addedlist.Rows)
            {
                sql = "INSERT INTO `tblstock_return` (  `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`)" +
                        " VALUES ('" + tranid + "','" + r.Cells[0].Value + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + r.Cells[4].Value +
                        "','" + r.Cells[5].Value + "','" + custormerid + "')";
                config.Execute_Query(sql);

                //     '-----------------------------------------------update item
                sql = "UPDATE `tblitems`  SET `QTY`=`QTY` + '" + r.Cells[4].Value + "' WHERE ITEMID='" + r.Cells[0].Value + "'";
                config.Execute_Query(sql);

                sql = "UPDATE `tblstock_in_out` SET  `QTY`=`QTY`-'" + r.Cells[4].Value + "', `TOTALPRICE`=`TOTALPRICE`-'" + r.Cells[5].Value + "'  WHERE `STOCKOUTID` ='" + r.Cells[6].Value + "'";
                config.Execute_Query(sql);
            }


            sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" +
                  " VALUES ('" + txttransactionid.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','Returned','" + custormerid + "')";
            config.Execute_Query(sql);

            // '-----------------------------------------------update autonumber
            config.Execute_Query("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 6");

            // '------------------------------------------------------------
            MessageBox.Show("Item(s) has been returned in the database.");
            // '------------------------------------------------------------clearing
            funct.clearTxt(GroupBox3);
            dtCus_addedlist.Rows.Clear();

            frmReturn_Load(sender, e);
        }

        private void btnreturn_remove_Click(object sender, EventArgs e)
        {
            dtCus_addedlist.Rows.Remove(dtCus_addedlist.CurrentRow);
        }

        private void btnreturn_clear_Click(object sender, EventArgs e)
        {
            dtCus_addedlist.Columns.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnvewlreturn_Click(object sender, EventArgs e)
        {
            frmListReturned frm = new frmListReturned();
            frm.Show();
        }

        private void txttransactionid_TextChanged(object sender, EventArgs e)
        {
            
            sql = "SELECT p.SUPLIERCUSTOMERID as ID, `FIRSTNAME`, `LASTNAME` ,`ADDRESS` FROM  `tbltransaction` t, `tblperson`  p  WHERE t.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND `TRANSACTIONNUMBER`='" + txttransactionid.Text + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                custormerid = config.dt.Rows[0].Field<string>("ID");
                txtreturn_name.Text = config.dt.Rows[0].Field<string>("FIRSTNAME").ToString() + " " + config.dt.Rows[0].Field<string>("LASTNAME").ToString();
                txtreturn_address.Text = config.dt.Rows[0].Field<string>("ADDRESS").ToString();




                sql = "SELECT   i.`ITEMID`, `NAME`, `DESCRIPTION`, `PRICE`,`TRANSACTIONDATE`, o.`QTY`, `TOTALPRICE`,`STOCKOUTID` FROM  `tblitems` i , `tblstock_in_out` o WHERE i.`ITEMID`=o.`ITEMID` AND `TRANSACTIONNUMBER`='" + txttransactionid.Text + "'";
                config.Load_DTG(sql,dtgCus_itemlist);
                dtgCus_itemlist.Columns[7].Visible = false;
            }
            else
            {
                txtreturn_name.Clear();
                txtreturn_address.Clear();
                dtgCus_itemlist.Columns.Clear();
            }

          
        }
    }
}
