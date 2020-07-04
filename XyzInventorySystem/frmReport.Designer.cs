namespace InventorySystem1._0
{
    partial class frmReport
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnitemlisat = new System.Windows.Forms.Button();
            this.cbooption = new System.Windows.Forms.ComboBox();
            this.btnListStockin = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockReturn = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dptfrom = new System.Windows.Forms.DateTimePicker();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(164, 607);
            this.Panel1.TabIndex = 6;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnitemlisat);
            this.GroupBox2.Controls.Add(this.cbooption);
            this.GroupBox2.Controls.Add(this.btnListStockin);
            this.GroupBox2.Controls.Add(this.btnStockOut);
            this.GroupBox2.Controls.Add(this.btnStockReturn);
            this.GroupBox2.Location = new System.Drawing.Point(5, 24);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(146, 211);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Report Type";
            // 
            // btnitemlisat
            // 
            this.btnitemlisat.BackColor = System.Drawing.Color.Transparent;
            this.btnitemlisat.ForeColor = System.Drawing.Color.Black;
            this.btnitemlisat.Location = new System.Drawing.Point(9, 19);
            this.btnitemlisat.Name = "btnitemlisat";
            this.btnitemlisat.Size = new System.Drawing.Size(124, 30);
            this.btnitemlisat.TabIndex = 3;
            this.btnitemlisat.Text = "List Of Items";
            this.btnitemlisat.UseVisualStyleBackColor = false;
            this.btnitemlisat.Click += new System.EventHandler(this.btnitemlisat_Click);
            // 
            // cbooption
            // 
            this.cbooption.FormattingEnabled = true;
            this.cbooption.Items.AddRange(new object[] {
            "Daily Report",
            "Weekly Report",
            "Monthly Report"});
            this.cbooption.Location = new System.Drawing.Point(9, 55);
            this.cbooption.Name = "cbooption";
            this.cbooption.Size = new System.Drawing.Size(124, 21);
            this.cbooption.TabIndex = 2;
            this.cbooption.Text = "Daily Report";
            // 
            // btnListStockin
            // 
            this.btnListStockin.BackColor = System.Drawing.Color.Transparent;
            this.btnListStockin.ForeColor = System.Drawing.Color.Black;
            this.btnListStockin.Location = new System.Drawing.Point(9, 84);
            this.btnListStockin.Name = "btnListStockin";
            this.btnListStockin.Size = new System.Drawing.Size(124, 30);
            this.btnListStockin.TabIndex = 0;
            this.btnListStockin.Text = "List Of Stock Items";
            this.btnListStockin.UseVisualStyleBackColor = false;
            this.btnListStockin.Click += new System.EventHandler(this.btnListStockin_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.BackColor = System.Drawing.Color.Transparent;
            this.btnStockOut.ForeColor = System.Drawing.Color.Black;
            this.btnStockOut.Location = new System.Drawing.Point(9, 120);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(124, 30);
            this.btnStockOut.TabIndex = 0;
            this.btnStockOut.Text = "List Of Sold Items";
            this.btnStockOut.UseVisualStyleBackColor = false;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockReturn
            // 
            this.btnStockReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnStockReturn.ForeColor = System.Drawing.Color.Black;
            this.btnStockReturn.Location = new System.Drawing.Point(9, 156);
            this.btnStockReturn.Name = "btnStockReturn";
            this.btnStockReturn.Size = new System.Drawing.Size(124, 30);
            this.btnStockReturn.TabIndex = 0;
            this.btnStockReturn.Text = "List Of Returned Items";
            this.btnStockReturn.UseVisualStyleBackColor = false;
            this.btnStockReturn.Click += new System.EventHandler(this.btnStockReturn_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.dtpto);
            this.GroupBox1.Controls.Add(this.dptfrom);
            this.GroupBox1.Location = new System.Drawing.Point(5, 254);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(146, 152);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Report Date Filter";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(20, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "To";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(30, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "From";
            // 
            // dtpto
            // 
            this.dtpto.CustomFormat = "yyyy-MM-dd";
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpto.Location = new System.Drawing.Point(9, 83);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(131, 20);
            this.dtpto.TabIndex = 2;
            // 
            // dptfrom
            // 
            this.dptfrom.CustomFormat = "yyyy-MM-dd";
            this.dptfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptfrom.Location = new System.Drawing.Point(9, 44);
            this.dptfrom.Name = "dptfrom";
            this.dptfrom.Size = new System.Drawing.Size(131, 20);
            this.dptfrom.TabIndex = 2;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "January",
            "February",
            "March ",
            "April",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.ComboBox1.Location = new System.Drawing.Point(239, 44);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(124, 21);
            this.ComboBox1.TabIndex = 7;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(164, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(743, 607);
            this.crystalReportViewer1.TabIndex = 8;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 607);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ComboBox1);
            this.Name = "frmReport";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.Panel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnitemlisat;
        internal System.Windows.Forms.ComboBox cbooption;
        internal System.Windows.Forms.Button btnListStockin;
        internal System.Windows.Forms.Button btnStockOut;
        internal System.Windows.Forms.Button btnStockReturn;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpto;
        internal System.Windows.Forms.DateTimePicker dptfrom;
        internal System.Windows.Forms.ComboBox ComboBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
    }
}