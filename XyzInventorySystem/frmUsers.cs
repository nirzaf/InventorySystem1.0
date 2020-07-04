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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void btn_New_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "id";

            cbo_type.Text = "Administrator";

            config.Load_DTG("Select user_id as 'ID' ,name as 'Name',user_name as 'Username',type as 'Type' From user", dtg_listUser);
            dtg_listUser.Columns[0].Visible = false;

            if(lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false; 
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }

            funct.clearTxt(Panel1);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {


            if( txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text== "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "insert into user (name,user_name,pass,type) "
                     + "values('" + txt_name.Text + "','" + txt_username.Text
                     + "',sha1('" + txt_pass.Text + "'),'" + cbo_type.Text
                     + "')";
                config.Execute_CUD(sql, "Unable to saved", "Data has been saved in the database.");
                frmUsers_Load(sender, e);
            }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "update user set name = '" + txt_name.Text + "',user_name= '" + txt_username.Text 
                          + "',pass= sha1('" + txt_pass.Text + "'),type= '" + cbo_type.Text 
                          + "' where user_id = " + lbl_id.Text;
                config.Execute_CUD(sql, "Unable to update", "Data has been updated in the database.");
                frmUsers_Load(sender, e);
            } 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "delete from user where user_id = '" + lbl_id.Text + "'";
            config.Execute_CUD(sql, "unable to delete", "Data has been deleted in the database");
            frmUsers_Load(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_listUser_Click(object sender, EventArgs e)
        { 
            lbl_id.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dtg_listUser.CurrentRow.Cells[1].Value.ToString();
            txt_username.Text = dtg_listUser.CurrentRow.Cells[2].Value.ToString();
            cbo_type.Text = dtg_listUser.CurrentRow.Cells[3].Value.ToString();
        }

        private void lbl_id_TextChanged(object sender, EventArgs e)
        {
            if (lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
    }
}
