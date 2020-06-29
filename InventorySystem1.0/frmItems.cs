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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxcolumn;
        int inc = 0;
        int maxrow;

        private void select_navigation(string sql)
        {
            config.singleResult(sql);
            maxrow = config.dt.Rows.Count;
        }
        public void navigate_records(int inc)
        {
            config.singleResult("SELECT * FROM `tblitems`");
            txtitemid.Text =config.dt.Rows[inc].Field<string>("ITEMID");
            txtname.Text = config.dt.Rows[inc].Field<string>("NAME");
            txtdescription.Text = config.dt.Rows[inc].Field<string>("DESCRIPTION");
            txtprice.Text = config.dt.Rows[inc].Field<double>("PRICE").ToString();
            cbotype.Text = config.dt.Rows[inc].Field<string>("TYPE");
            //txtqty.Text = config.dt.Rows[inc].Field<int>("Quantity").ToString();
            //cbounit.Text = config.dt.Rows[inc].Field<string>("Units");


        }
        private void btnnew_Click(object sender, EventArgs e)
        {

            inc = 0;
          
            sql = "SELECT * FROM tblitems";
            config.Load_DTG(sql, dtglist);  

            maxcolumn = dtglist.Columns.Count - 1;

            dtglist.Columns[maxcolumn].Visible = false;

            btnadd.Visible = false;
             
            select_navigation("SELECT ITEMID FROM tblitems");
            lblmax.Text = maxrow.ToString();
            lblinc.Text = inc.ToString();

            sql = "SELECT DESCRIPTION FROM `tblsettings` WHERE `PARA`='CATEGORY'";
            config.fiil_CBO(sql, cbotype);

            sql = "SELECT DESCRIPTION FROM `tblsettings` WHERE `PARA`='Unit'";
            config.fiil_CBO(sql, cbounit);


            funct.clearTxt(pnl_stockmaster);

        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        { 
                sql = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`= '" + cbotype.Text + "'";
                config.autonumber(sql, txtitemid);
 
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            foreach(Control obj in pnl_stockmaster.Controls)
            {
                if(obj is TextBox)
                {
                    if(obj.Text == "")
                    {
                        MessageBox.Show("Action connot be perform. All fields are required to be fill up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }



            sql = "INSERT INTO  `tblstock_in_out` (`ITEMID`, `QTY`,`TRANSACTIONDATE`, `TOTALPRICE`, `REMARKS`)" +
              " VALUES ('" + txtitemid.Text + "','" + txtqty.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + txtprice.Text +
              "','StockIn')";
           config.Execute_Query(sql);


            sql = "SELECT ITEMID FROM tblitems WHERE ITEMID='" + txtitemid.Text + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                sql = "UPDATE tblitems SET qty =qty + '" + txtqty.Text + "' WHERE ITEMID ='" + txtitemid.Text + "'";
                config.Execute_Query(sql);
            }
            else
            {
                sql = "insert into tblitems  (ITEMID,`NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY`,UNIT)" +
                   "VALUES ('" + txtitemid.Text + "','" + txtname.Text + "','" + txtdescription.Text + "','" + cbotype.Text 
                   + "','" + txtprice.Text + "','" + txtqty.Text + "','" + cbounit.Text + "' )";
                config.Execute_CUD(sql, "No data saved.", "Data has been saved in the database.");

                config.update_Autonumber(cbotype.Text);
            }

            btnnew_Click(sender, e);
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tblitems SET `NAME`='" + txtname.Text + "', `DESCRIPTION`='" + txtdescription.Text + "', `TYPE`='" + cbotype.Text + "', `PRICE`='" + txtprice.Text + "'" +
            ",`UNIT`='" + cbounit.Text + "' WHERE ITEMID='" + txtitemid.Text + "'";
            config.Execute_CUD(sql, "Error to update", "Data has been updated in the database"); 
            btnnew_Click(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM tblitems WHERE ITEMID='" + dtglist.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "error to delete", "Data has been deleted.");
            btnnew_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtitemid_TextChanged(object sender, EventArgs e)
        {
            
             
        }

        private void dtglist_Click(object sender, EventArgs e)
        { 
            sql = "SELECT * FROM tblitems WHERE ITEMID='" + dtglist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtitemid.Text = config.dt.Rows[0].Field<string>("ITEMID");
                txtname.Text = config.dt.Rows[0].Field<string>("NAME");
                txtdescription.Text = config.dt.Rows[0].Field<string>("DESCRIPTION");
                txtprice.Text = config.dt.Rows[0].Field<double>("PRICE").ToString();
                cbotype.Text = config.dt.Rows[0].Field<string>("TYPE");
                //txtqty.Text = config.dt.Rows[0].Field<int>("QTY").ToString();
                //cbounit.Text = config.dt.Rows[0].Field<string>("UNIT");
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            inc = 1; 
            lblinc.Text = inc.ToString();
            inc = 0;
            navigate_records(inc);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            select_navigation("SELECT ITEMID FROM tblitems"); 
            if(inc!= maxrow)
            {
                inc = maxrow;
                lblinc.Text = inc.ToString();
                inc = maxrow - 1;
                navigate_records(inc); 
            } 
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            int lbl_inc=0; 

            if(inc > 0)
            {
                inc = inc - 1;
                navigate_records(inc);
                 

                lbl_inc = int.Parse(lblinc.Text) - 1;

                lblinc.Text = lbl_inc.ToString();
            }
            else if(inc == 0)
            {
                navigate_records(inc);
                lbl_inc = 1;
                lblinc.Text = lbl_inc.ToString();
                MessageBox.Show("First Records", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int lbl_inc;

            select_navigation("SELECT ITEMID FROM tblitems");
            if(inc==maxrow-1)
            {
                MessageBox.Show("no more rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (inc != maxrow - 1)
                {
                    inc = inc + 1;
                    navigate_records(inc);
                }

                lbl_inc = int.Parse(lblinc.Text) + 1;
                lblinc.Text = lbl_inc.ToString();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblitems WHERE ITEMID LIKE '%" + txtsearch.Text + "%' OR NAME LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtglist);


            maxcolumn = dtglist.Columns.Count - 1;

            dtglist.Columns[maxcolumn].Visible = false;

        }
    }
}
