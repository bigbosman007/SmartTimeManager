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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
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
            this.flowLayoutPanel1.Controls.Add(this.metroTile1);
            this.flowLayoutPanel1.Controls.Add(this.metroTile2);
            this.flowLayoutPanel1.Controls.Add(this.metroTile3);
            this.flowLayoutPanel1.Controls.Add(this.metroTile4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(74, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 300);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(128, 100);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseVisualStyleBackColor = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(137, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(128, 100);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseVisualStyleBackColor = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(271, 3);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(128, 100);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseVisualStyleBackColor = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(405, 3);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(128, 100);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "metroTile4";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseVisualStyleBackColor = true;
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
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}