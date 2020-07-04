namespace InventorySystem1._0
{
    partial class frmSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgtypelist = new System.Windows.Forms.DataGridView();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.btnusave = new System.Windows.Forms.Button();
            this.btncdel = new System.Windows.Forms.Button();
            this.btntypeupdate = new System.Windows.Forms.Button();
            this.btntypeLoad = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnuupdate = new System.Windows.Forms.Button();
            this.btnuload = new System.Windows.Forms.Button();
            this.dtgulist = new System.Windows.Forms.DataGridView();
            this.btnTypesave = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnunit = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtypelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgulist)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgtypelist
            // 
            this.dtgtypelist.AllowUserToAddRows = false;
            this.dtgtypelist.AllowUserToDeleteRows = false;
            this.dtgtypelist.AllowUserToResizeColumns = false;
            this.dtgtypelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgtypelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtypelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgtypelist.Location = new System.Drawing.Point(6, 54);
            this.dtgtypelist.Name = "dtgtypelist";
            this.dtgtypelist.RowHeadersVisible = false;
            this.dtgtypelist.Size = new System.Drawing.Size(278, 312);
            this.dtgtypelist.TabIndex = 3;
            this.dtgtypelist.Click += new System.EventHandler(this.dtgtypelist_Click);
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(72, 28);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(212, 20);
            this.txtunit.TabIndex = 2;
            // 
            // btnusave
            // 
            this.btnusave.BackColor = System.Drawing.Color.White;
            this.btnusave.ForeColor = System.Drawing.Color.Black;
            this.btnusave.Location = new System.Drawing.Point(290, 31);
            this.btnusave.Name = "btnusave";
            this.btnusave.Size = new System.Drawing.Size(75, 23);
            this.btnusave.TabIndex = 0;
            this.btnusave.Text = "Save";
            this.btnusave.UseVisualStyleBackColor = false;
            this.btnusave.Click += new System.EventHandler(this.btnusave_Click);
            // 
            // btncdel
            // 
            this.btncdel.BackColor = System.Drawing.Color.White;
            this.btncdel.ForeColor = System.Drawing.Color.Black;
            this.btncdel.Location = new System.Drawing.Point(290, 89);
            this.btncdel.Name = "btncdel";
            this.btncdel.Size = new System.Drawing.Size(75, 23);
            this.btncdel.TabIndex = 6;
            this.btncdel.Text = "Delete";
            this.btncdel.UseVisualStyleBackColor = false;
            this.btncdel.Click += new System.EventHandler(this.btncdel_Click);
            // 
            // btntypeupdate
            // 
            this.btntypeupdate.BackColor = System.Drawing.Color.White;
            this.btntypeupdate.ForeColor = System.Drawing.Color.Black;
            this.btntypeupdate.Location = new System.Drawing.Point(290, 60);
            this.btntypeupdate.Name = "btntypeupdate";
            this.btntypeupdate.Size = new System.Drawing.Size(75, 23);
            this.btntypeupdate.TabIndex = 5;
            this.btntypeupdate.Text = "Update";
            this.btntypeupdate.UseVisualStyleBackColor = false;
            this.btntypeupdate.Click += new System.EventHandler(this.btntypeupdate_Click);
            // 
            // btntypeLoad
            // 
            this.btntypeLoad.BackColor = System.Drawing.Color.White;
            this.btntypeLoad.ForeColor = System.Drawing.Color.Black;
            this.btntypeLoad.Location = new System.Drawing.Point(290, 121);
            this.btntypeLoad.Name = "btntypeLoad";
            this.btntypeLoad.Size = new System.Drawing.Size(75, 23);
            this.btntypeLoad.TabIndex = 4;
            this.btntypeLoad.Text = "Load";
            this.btntypeLoad.UseVisualStyleBackColor = false;
            this.btntypeLoad.Click += new System.EventHandler(this.btntypeLoad_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(72, 28);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(212, 20);
            this.txtCategory.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(6, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Category :";
            // 
            // btnuupdate
            // 
            this.btnuupdate.BackColor = System.Drawing.Color.White;
            this.btnuupdate.ForeColor = System.Drawing.Color.Black;
            this.btnuupdate.Location = new System.Drawing.Point(290, 60);
            this.btnuupdate.Name = "btnuupdate";
            this.btnuupdate.Size = new System.Drawing.Size(75, 23);
            this.btnuupdate.TabIndex = 5;
            this.btnuupdate.Text = "Update";
            this.btnuupdate.UseVisualStyleBackColor = false;
            this.btnuupdate.Click += new System.EventHandler(this.btnuupdate_Click);
            // 
            // btnuload
            // 
            this.btnuload.BackColor = System.Drawing.Color.White;
            this.btnuload.ForeColor = System.Drawing.Color.Black;
            this.btnuload.Location = new System.Drawing.Point(290, 117);
            this.btnuload.Name = "btnuload";
            this.btnuload.Size = new System.Drawing.Size(75, 23);
            this.btnuload.TabIndex = 4;
            this.btnuload.Text = "Load";
            this.btnuload.UseVisualStyleBackColor = false;
            this.btnuload.Click += new System.EventHandler(this.btnuload_Click);
            // 
            // dtgulist
            // 
            this.dtgulist.AllowUserToAddRows = false;
            this.dtgulist.AllowUserToDeleteRows = false;
            this.dtgulist.AllowUserToResizeColumns = false;
            this.dtgulist.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgulist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgulist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgulist.Location = new System.Drawing.Point(6, 54);
            this.dtgulist.Name = "dtgulist";
            this.dtgulist.RowHeadersVisible = false;
            this.dtgulist.Size = new System.Drawing.Size(278, 312);
            this.dtgulist.TabIndex = 3;
            this.dtgulist.Click += new System.EventHandler(this.dtgulist_Click);
            // 
            // btnTypesave
            // 
            this.btnTypesave.BackColor = System.Drawing.Color.White;
            this.btnTypesave.ForeColor = System.Drawing.Color.Black;
            this.btnTypesave.Location = new System.Drawing.Point(290, 31);
            this.btnTypesave.Name = "btnTypesave";
            this.btnTypesave.Size = new System.Drawing.Size(75, 23);
            this.btnTypesave.TabIndex = 0;
            this.btnTypesave.Text = "Save";
            this.btnTypesave.UseVisualStyleBackColor = false;
            this.btnTypesave.Click += new System.EventHandler(this.btnTypesave_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnunit);
            this.GroupBox2.Controls.Add(this.btnuupdate);
            this.GroupBox2.Controls.Add(this.btnuload);
            this.GroupBox2.Controls.Add(this.dtgulist);
            this.GroupBox2.Controls.Add(this.txtunit);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btnusave);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(392, 9);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(374, 372);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Add New Item Unit";
            // 
            // btnunit
            // 
            this.btnunit.BackColor = System.Drawing.Color.White;
            this.btnunit.ForeColor = System.Drawing.Color.Black;
            this.btnunit.Location = new System.Drawing.Point(290, 88);
            this.btnunit.Name = "btnunit";
            this.btnunit.Size = new System.Drawing.Size(75, 23);
            this.btnunit.TabIndex = 7;
            this.btnunit.Text = "Delete";
            this.btnunit.UseVisualStyleBackColor = false;
            this.btnunit.Click += new System.EventHandler(this.btnunit_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(6, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Item Unit :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btncdel);
            this.GroupBox1.Controls.Add(this.btntypeupdate);
            this.GroupBox1.Controls.Add(this.btntypeLoad);
            this.GroupBox1.Controls.Add(this.dtgtypelist);
            this.GroupBox1.Controls.Add(this.txtCategory);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnTypesave);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(374, 372);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Add new Category";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 395);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dtgtypelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgulist)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgtypelist;
        internal System.Windows.Forms.TextBox txtunit;
        internal System.Windows.Forms.Button btnusave;
        internal System.Windows.Forms.Button btncdel;
        internal System.Windows.Forms.Button btntypeupdate;
        internal System.Windows.Forms.Button btntypeLoad;
        internal System.Windows.Forms.TextBox txtCategory;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnuupdate;
        internal System.Windows.Forms.Button btnuload;
        internal System.Windows.Forms.DataGridView dtgulist;
        internal System.Windows.Forms.Button btnTypesave;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnunit;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}