namespace InventorySystem1._0
{
    partial class frmItems
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
            this.txtqty = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblinc = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnlast = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.txtitemid = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.cbounit = new System.Windows.Forms.ComboBox();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.pnl_stockmaster = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.Panel2.SuspendLayout();
            this.pnl_stockmaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(443, 131);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(153, 22);
            this.txtqty.TabIndex = 4;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(450, 193);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(106, 30);
            this.Button1.TabIndex = 44;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(419, 238);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 13);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "Search :";
            // 
            // lblinc
            // 
            this.lblinc.AutoSize = true;
            this.lblinc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinc.Location = new System.Drawing.Point(14, 235);
            this.lblinc.Name = "lblinc";
            this.lblinc.Size = new System.Drawing.Size(14, 16);
            this.lblinc.TabIndex = 42;
            this.lblinc.Text = "1";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(472, 235);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(263, 20);
            this.txtsearch.TabIndex = 29;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(338, 193);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(106, 30);
            this.btnnew.TabIndex = 33;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(36, 235);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(19, 16);
            this.Label9.TabIndex = 37;
            this.Label9.Text = "of";
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.Transparent;
            this.btnlast.ForeColor = System.Drawing.Color.Black;
            this.btnlast.Location = new System.Drawing.Point(222, 229);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(39, 30);
            this.btnlast.TabIndex = 38;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(228, 193);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 30);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.ForeColor = System.Drawing.Color.Black;
            this.btnnext.Location = new System.Drawing.Point(174, 229);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(39, 30);
            this.btnnext.TabIndex = 39;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // cbotype
            // 
            this.cbotype.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Location = new System.Drawing.Point(441, 59);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(252, 24);
            this.cbotype.TabIndex = 2;
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cbotype_SelectedIndexChanged);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(110, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 22);
            this.txtname.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(392, 99);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 16);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Price ::";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(368, 62);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Category ::";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(443, 96);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(250, 22);
            this.txtprice.TabIndex = 0;
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.Color.Transparent;
            this.btnprev.ForeColor = System.Drawing.Color.Black;
            this.btnprev.Location = new System.Drawing.Point(128, 229);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(39, 30);
            this.btnprev.TabIndex = 40;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(119, 193);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 30);
            this.btnupdate.TabIndex = 35;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.Transparent;
            this.btnfirst.ForeColor = System.Drawing.Color.Black;
            this.btnfirst.Location = new System.Drawing.Point(83, 229);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(39, 30);
            this.btnfirst.TabIndex = 41;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(7, 193);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 30);
            this.btnsave.TabIndex = 36;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(109, 95);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(253, 62);
            this.txtdescription.TabIndex = 3;
            this.txtdescription.Text = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(23, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Description ::";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmax.Location = new System.Drawing.Point(63, 235);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(14, 16);
            this.lblmax.TabIndex = 43;
            this.lblmax.Text = "1";
            // 
            // txtitemid
            // 
            this.txtitemid.Enabled = false;
            this.txtitemid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemid.Location = new System.Drawing.Point(110, 31);
            this.txtitemid.Name = "txtitemid";
            this.txtitemid.Size = new System.Drawing.Size(251, 22);
            this.txtitemid.TabIndex = 7;
            this.txtitemid.TextChanged += new System.EventHandler(this.txtitemid_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(47, 34);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(56, 16);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Item Id ::";
            // 
            // cbounit
            // 
            this.cbounit.FormattingEnabled = true;
            this.cbounit.Items.AddRange(new object[] {
            "Metre",
            "Pcs."});
            this.cbounit.Location = new System.Drawing.Point(606, 130);
            this.cbounit.Name = "cbounit";
            this.cbounit.Size = new System.Drawing.Size(87, 23);
            this.cbounit.TabIndex = 6;
            this.cbounit.Text = "Metre";
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(0, 0);
            this.dtglist.Name = "dtglist";
            this.dtglist.Size = new System.Drawing.Size(733, 311);
            this.dtglist.TabIndex = 0;
            this.dtglist.Click += new System.EventHandler(this.dtglist_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.dtglist);
            this.Panel2.Controls.Add(this.btnadd);
            this.Panel2.Location = new System.Drawing.Point(6, 265);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(735, 313);
            this.Panel2.TabIndex = 32;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(344, 55);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(142, 25);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(30, 59);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Item Name ::";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(373, 134);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 16);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Quantity ::";
            // 
            // pnl_stockmaster
            // 
            this.pnl_stockmaster.BackColor = System.Drawing.Color.White;
            this.pnl_stockmaster.Controls.Add(this.txtitemid);
            this.pnl_stockmaster.Controls.Add(this.Label8);
            this.pnl_stockmaster.Controls.Add(this.cbounit);
            this.pnl_stockmaster.Controls.Add(this.Label7);
            this.pnl_stockmaster.Controls.Add(this.txtqty);
            this.pnl_stockmaster.Controls.Add(this.txtdescription);
            this.pnl_stockmaster.Controls.Add(this.cbotype);
            this.pnl_stockmaster.Controls.Add(this.txtname);
            this.pnl_stockmaster.Controls.Add(this.Label4);
            this.pnl_stockmaster.Controls.Add(this.Label3);
            this.pnl_stockmaster.Controls.Add(this.txtprice);
            this.pnl_stockmaster.Controls.Add(this.Label2);
            this.pnl_stockmaster.Controls.Add(this.Label1);
            this.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_stockmaster.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_stockmaster.Location = new System.Drawing.Point(0, 0);
            this.pnl_stockmaster.Name = "pnl_stockmaster";
            this.pnl_stockmaster.Size = new System.Drawing.Size(748, 184);
            this.pnl_stockmaster.TabIndex = 30;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 590);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lblinc);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.pnl_stockmaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Master";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.pnl_stockmaster.ResumeLayout(false);
            this.pnl_stockmaster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtqty;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblinc;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btnlast;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnnext;
        internal System.Windows.Forms.ComboBox cbotype;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtprice;
        internal System.Windows.Forms.Button btnprev;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnfirst;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.RichTextBox txtdescription;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblmax;
        internal System.Windows.Forms.TextBox txtitemid;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox cbounit;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel pnl_stockmaster;
    }
}