namespace InventorySystem1._0
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_listUser = new System.Windows.Forms.DataGridView();
            this.Button1 = new System.Windows.Forms.Button();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_New = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.txt_name);
            this.Panel1.Controls.Add(this.lbl_id);
            this.Panel1.Controls.Add(this.cbo_type);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.txt_pass);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.txt_username);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(753, 171);
            this.Panel1.TabIndex = 27;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(243, 23);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(280, 22);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(257, 26);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 16);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            this.lbl_id.TextChanged += new System.EventHandler(this.lbl_id_TextChanged);
            // 
            // cbo_type
            // 
            this.cbo_type.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Administrator",
            "Staff"});
            this.cbo_type.Location = new System.Drawing.Point(243, 116);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(280, 24);
            this.cbo_type.TabIndex = 4;
            this.cbo_type.Text = "Administrator";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location = new System.Drawing.Point(186, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Name :";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(243, 86);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(280, 22);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Image = ((System.Drawing.Image)(resources.GetObject("Label2.Image")));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(160, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Username :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Image = ((System.Drawing.Image)(resources.GetObject("Label4.Image")));
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label4.Location = new System.Drawing.Point(186, 119);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 16);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Type :";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(243, 56);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(280, 22);
            this.txt_username.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Image = ((System.Drawing.Image)(resources.GetObject("Label3.Image")));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Location = new System.Drawing.Point(163, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Password :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.Controls.Add(this.dtg_listUser);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox1.Location = new System.Drawing.Point(0, 209);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(753, 310);
            this.GroupBox1.TabIndex = 26;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "List Of User";
            // 
            // dtg_listUser
            // 
            this.dtg_listUser.AllowUserToAddRows = false;
            this.dtg_listUser.AllowUserToDeleteRows = false;
            this.dtg_listUser.AllowUserToResizeColumns = false;
            this.dtg_listUser.AllowUserToResizeRows = false;
            this.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_listUser.Location = new System.Drawing.Point(3, 16);
            this.dtg_listUser.Name = "dtg_listUser";
            this.dtg_listUser.RowHeadersVisible = false;
            this.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listUser.Size = new System.Drawing.Size(747, 291);
            this.dtg_listUser.TabIndex = 0;
            this.dtg_listUser.Click += new System.EventHandler(this.dtg_listUser_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button1.Location = new System.Drawing.Point(580, 177);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(132, 26);
            this.Button1.TabIndex = 28;
            this.Button1.Text = "Close";
            this.ToolTip1.SetToolTip(this.Button1, "Close");
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveuser.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saveuser.Location = new System.Drawing.Point(23, 178);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(138, 26);
            this.btn_saveuser.TabIndex = 22;
            this.btn_saveuser.Text = "Save";
            this.ToolTip1.SetToolTip(this.btn_saveuser, "Save Data");
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(167, 177);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(138, 26);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Update";
            this.ToolTip1.SetToolTip(this.btn_update, "Update");
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Location = new System.Drawing.Point(311, 176);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 26);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.Transparent;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_New.Location = new System.Drawing.Point(442, 176);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(132, 26);
            this.btn_New.TabIndex = 24;
            this.btn_New.Text = "New";
            this.ToolTip1.SetToolTip(this.btn_New, "New");
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 519);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_New);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label lbl_id;
        internal System.Windows.Forms.ComboBox cbo_type;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_pass;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_username;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dtg_listUser;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_New;
    }
}