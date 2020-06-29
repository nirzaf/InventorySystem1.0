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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql,typeid,unitid;

        private void btnTypesave_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" + txtCategory.Text + "','Category')";
            config.Execute_CUD(sql, "error to saved data", "Data has been saved in the database.");


            sql = "INSERT INTO tblautonumber (STRT,END,INCREMENT,DESCRIPTION)" +
               " VALUES ('" + txtCategory.Text.Substring(0, 1) + "0000" + "',1,1,'" + txtCategory.Text + "')";
            config.Execute_Query(sql); 
            btntypeLoad_Click(sender, e);
        }

        private void btntypeLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Category'";
            config.Load_DTG(sql, dtgtypelist); 
            dtgtypelist.Columns[0].Visible = false;
            txtCategory.Clear();
        }

        private void btncdel_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `tblautonumber` WHERE `ID`='" + dtgtypelist.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM `tblsettings` WHERE `ID`='" + dtgtypelist.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "error to delete data", "Data has been deleted in the database.");

            btntypeLoad_Click(sender, e);
        }

        private void dtgtypelist_Click(object sender, EventArgs e)
        {
            txtCategory.Text = dtgtypelist.CurrentRow.Cells[1].Value.ToString();
            typeid = dtgtypelist.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnuload_Click(object sender, EventArgs e)
        {
            sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Unit'";
            config.Load_DTG(sql, dtgulist);
            dtgulist.Columns[0].Visible = false;
            txtunit.Clear();
        }

        private void btnusave_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" + txtunit.Text + "','Unit')";
            config.Execute_CUD(sql, "error to save date", "Data has been saved in the database.");
            btntypeupdate_Click(sender, e);
        }

        private void btnunit_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `tblsettings` WHERE `ID`='" + dtgulist.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "error to delete date", "Data has been deleted in the database.");
            btntypeupdate_Click(sender, e);
        }

        private void dtgulist_Click(object sender, EventArgs e)
        {
            txtunit.Text = dtgulist.CurrentRow.Cells[1].Value.ToString();
            unitid = dtgulist.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnuupdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tblsettings  SET DESCRIPTION= '" + txtCategory.Text + "' WHERE ID ='" + unitid + "'";
            config.Execute_CUD(sql, "error to update data", "Data has been updated in the database.");
            btntypeupdate_Click(sender, e);
        }

        private void btntypeupdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tblsettings  SET DESCRIPTION= '" + txtCategory.Text + "' WHERE ID ='" + typeid + "'";
            config.Execute_CUD(sql, "error to update data", "Data has been updated in the database.");
            btntypeLoad_Click(sender, e);
        }
    }
}
