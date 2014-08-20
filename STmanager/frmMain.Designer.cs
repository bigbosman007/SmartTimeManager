namespace STmanager
{
    partial class frmMain
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
            this.lblCurrentEmpID = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.msmFrmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mseFrmMain = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mtabMainMenuHost = new MetroFramework.Controls.MetroTabControl();
            this.tpageHome = new System.Windows.Forms.TabPage();
            this.pnlFrmDock = new MetroFramework.Controls.MetroPanel();
            this.lblEmployeePermission = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tileProductManagement = new MetroFramework.Controls.MetroTile();
            this.tileEmployeeManagement = new MetroFramework.Controls.MetroTile();
            this.tileBranchManagement = new MetroFramework.Controls.MetroTile();
            this.tileSaleManagement = new MetroFramework.Controls.MetroTile();
            this.tileSaleReport = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.lblCurrentEmpName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmFrmMain)).BeginInit();
            this.mtabMainMenuHost.SuspendLayout();
            this.tpageHome.SuspendLayout();
            this.pnlFrmDock.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentEmpID
            // 
            this.lblCurrentEmpID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentEmpID.Location = new System.Drawing.Point(375, 11);
            this.lblCurrentEmpID.Name = "lblCurrentEmpID";
            this.lblCurrentEmpID.Size = new System.Drawing.Size(317, 23);
            this.lblCurrentEmpID.TabIndex = 0;
            this.lblCurrentEmpID.Text = "EmpID";
            this.lblCurrentEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(698, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 43);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // msmFrmMain
            // 
            this.msmFrmMain.Owner = this;
            this.msmFrmMain.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mseFrmMain.SetApplyMetroTheme(this.label1, true);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to SmartTime Manager Client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtabMainMenuHost
            // 
            this.mtabMainMenuHost.Controls.Add(this.tpageHome);
            this.mtabMainMenuHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtabMainMenuHost.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mtabMainMenuHost.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mtabMainMenuHost.Location = new System.Drawing.Point(20, 60);
            this.mtabMainMenuHost.Name = "mtabMainMenuHost";
            this.mtabMainMenuHost.Padding = new System.Drawing.Point(6, 8);
            this.mtabMainMenuHost.SelectedIndex = 0;
            this.mtabMainMenuHost.Size = new System.Drawing.Size(792, 580);
            this.mtabMainMenuHost.TabIndex = 28;
            this.mtabMainMenuHost.UseSelectable = true;
            // 
            // tpageHome
            // 
            this.tpageHome.Controls.Add(this.pnlFrmDock);
            this.tpageHome.Location = new System.Drawing.Point(4, 44);
            this.tpageHome.Name = "tpageHome";
            this.tpageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpageHome.Size = new System.Drawing.Size(784, 532);
            this.tpageHome.TabIndex = 0;
            this.tpageHome.Text = "Home";
            this.tpageHome.UseVisualStyleBackColor = true;
            // 
            // pnlFrmDock
            // 
            this.pnlFrmDock.Controls.Add(this.lblEmployeePermission);
            this.pnlFrmDock.Controls.Add(this.flowLayoutPanel1);
            this.pnlFrmDock.Controls.Add(this.label1);
            this.pnlFrmDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrmDock.HorizontalScrollbarBarColor = true;
            this.pnlFrmDock.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFrmDock.HorizontalScrollbarSize = 10;
            this.pnlFrmDock.Location = new System.Drawing.Point(3, 3);
            this.pnlFrmDock.Name = "pnlFrmDock";
            this.pnlFrmDock.Size = new System.Drawing.Size(778, 526);
            this.pnlFrmDock.TabIndex = 0;
            this.pnlFrmDock.VerticalScrollbarBarColor = true;
            this.pnlFrmDock.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFrmDock.VerticalScrollbarSize = 10;
            // 
            // lblEmployeePermission
            // 
            this.lblEmployeePermission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeePermission.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployeePermission.Location = new System.Drawing.Point(162, 115);
            this.lblEmployeePermission.Name = "lblEmployeePermission";
            this.lblEmployeePermission.Size = new System.Drawing.Size(445, 31);
            this.lblEmployeePermission.TabIndex = 4;
            this.lblEmployeePermission.Text = "Available task for EmployeePermission.Name";
            this.lblEmployeePermission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tileProductManagement);
            this.flowLayoutPanel1.Controls.Add(this.tileEmployeeManagement);
            this.flowLayoutPanel1.Controls.Add(this.tileBranchManagement);
            this.flowLayoutPanel1.Controls.Add(this.tileSaleManagement);
            this.flowLayoutPanel1.Controls.Add(this.tileSaleReport);
            this.flowLayoutPanel1.Controls.Add(this.metroTile5);
            this.flowLayoutPanel1.Controls.Add(this.metroTile6);
            this.flowLayoutPanel1.Controls.Add(this.metroTile7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(74, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 300);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tileProductManagement
            // 
            this.tileProductManagement.ActiveControl = null;
            this.tileProductManagement.Location = new System.Drawing.Point(3, 3);
            this.tileProductManagement.Name = "tileProductManagement";
            this.tileProductManagement.Size = new System.Drawing.Size(128, 100);
            this.tileProductManagement.TabIndex = 0;
            this.tileProductManagement.Text = "Products";
            this.tileProductManagement.UseSelectable = true;
            this.tileProductManagement.UseVisualStyleBackColor = true;
            this.tileProductManagement.Click += new System.EventHandler(this.tileProductManagement_Click);
            // 
            // tileEmployeeManagement
            // 
            this.tileEmployeeManagement.ActiveControl = null;
            this.tileEmployeeManagement.Location = new System.Drawing.Point(137, 3);
            this.tileEmployeeManagement.Name = "tileEmployeeManagement";
            this.tileEmployeeManagement.Size = new System.Drawing.Size(128, 100);
            this.tileEmployeeManagement.TabIndex = 1;
            this.tileEmployeeManagement.Text = "Employee";
            this.tileEmployeeManagement.UseSelectable = true;
            this.tileEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // tileBranchManagement
            // 
            this.tileBranchManagement.ActiveControl = null;
            this.tileBranchManagement.Location = new System.Drawing.Point(271, 3);
            this.tileBranchManagement.Name = "tileBranchManagement";
            this.tileBranchManagement.Size = new System.Drawing.Size(128, 100);
            this.tileBranchManagement.TabIndex = 2;
            this.tileBranchManagement.Text = "Branch";
            this.tileBranchManagement.UseSelectable = true;
            this.tileBranchManagement.UseVisualStyleBackColor = true;
            // 
            // tileSaleManagement
            // 
            this.tileSaleManagement.ActiveControl = null;
            this.tileSaleManagement.Location = new System.Drawing.Point(405, 3);
            this.tileSaleManagement.Name = "tileSaleManagement";
            this.tileSaleManagement.Size = new System.Drawing.Size(128, 100);
            this.tileSaleManagement.TabIndex = 3;
            this.tileSaleManagement.Text = "Sale";
            this.tileSaleManagement.UseSelectable = true;
            this.tileSaleManagement.UseVisualStyleBackColor = true;
            this.tileSaleManagement.Click += new System.EventHandler(this.tileSaleManagement_Click);
            // 
            // tileSaleReport
            // 
            this.tileSaleReport.ActiveControl = null;
            this.tileSaleReport.Location = new System.Drawing.Point(3, 109);
            this.tileSaleReport.Name = "tileSaleReport";
            this.tileSaleReport.Size = new System.Drawing.Size(128, 100);
            this.tileSaleReport.TabIndex = 4;
            this.tileSaleReport.Text = "Sale Report";
            this.tileSaleReport.UseSelectable = true;
            this.tileSaleReport.UseVisualStyleBackColor = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(137, 109);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(128, 100);
            this.metroTile5.TabIndex = 5;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseVisualStyleBackColor = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(271, 109);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(128, 100);
            this.metroTile6.TabIndex = 6;
            this.metroTile6.Text = "metroTile6";
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseVisualStyleBackColor = true;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(405, 109);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(128, 100);
            this.metroTile7.TabIndex = 7;
            this.metroTile7.Text = "metroTile7";
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseVisualStyleBackColor = true;
            // 
            // lblCurrentEmpName
            // 
            this.lblCurrentEmpName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentEmpName.Location = new System.Drawing.Point(375, 34);
            this.lblCurrentEmpName.Name = "lblCurrentEmpName";
            this.lblCurrentEmpName.Size = new System.Drawing.Size(317, 23);
            this.lblCurrentEmpName.TabIndex = 29;
            this.lblCurrentEmpName.Text = "EmpName EmpLast";
            this.lblCurrentEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 660);
            this.ControlBox = false;
            this.Controls.Add(this.lblCurrentEmpName);
            this.Controls.Add(this.mtabMainMenuHost);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblCurrentEmpID);
            this.Movable = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "SmartTime Manager Client";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmFrmMain)).EndInit();
            this.mtabMainMenuHost.ResumeLayout(false);
            this.tpageHome.ResumeLayout(false);
            this.pnlFrmDock.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCurrentEmpID;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Components.MetroStyleManager msmFrmMain;
        private MetroFramework.Components.MetroStyleExtender mseFrmMain;
        private MetroFramework.Controls.MetroTabControl mtabMainMenuHost;
        private System.Windows.Forms.TabPage tpageHome;
        private MetroFramework.Controls.MetroLabel lblCurrentEmpName;
        private MetroFramework.Controls.MetroPanel pnlFrmDock;
        private MetroFramework.Controls.MetroLabel lblEmployeePermission;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile tileProductManagement;
        private MetroFramework.Controls.MetroTile tileEmployeeManagement;
        private MetroFramework.Controls.MetroTile tileBranchManagement;
        private MetroFramework.Controls.MetroTile tileSaleManagement;
        private MetroFramework.Controls.MetroTile tileSaleReport;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
    }
}