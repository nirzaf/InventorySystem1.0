using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem1._0.Properties;

namespace InventorySystem1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }
        public void enabled_menu()
        {
            ts_ManageUsers.Enabled = true;
            ts_Report.Enabled = true;
            ts_Return.Enabled = true;
            ts_StockOut.Enabled = true;
            ts_stocks.Enabled = true;
            ts_Login.Text = "Logout";
            ts_Login.Image = Resources.lock_open;
            ts_settings.Enabled = true;

        }
        public void disabled_menu()
        {
            ts_ManageUsers.Enabled = false;
            ts_Report.Enabled = false;
            ts_Return.Enabled = false;
            ts_StockOut.Enabled = false;
            ts_stocks.Enabled = false;
            ts_Login.Image = Resources.login;
            ts_settings.Enabled = false;
        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ts_stocks_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmItems());
        }

        private void ts_StockOut_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmStockOut(""));
        }

        private void ts_Return_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmReturn());
        }

        private void ts_ManageUsers_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmUsers());
        }

        private void ts_Report_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmReport());

        }

        private void ts_Login_Click(object sender, EventArgs e)
        {
            if (ts_Login.Text == "Login")
            {
                closeForm();
                showFrm(new frmLogin(this));
            }
            else
            {
                closeForm();
                disabled_menu();
                ts_Login.Text = "Login";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();

        }

        private void ts_settings_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmSettings());
        }
    }
}
