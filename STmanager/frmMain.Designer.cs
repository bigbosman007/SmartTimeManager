﻿namespace STmanager
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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.lblCurrentEmpName = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.metroTile13 = new MetroFramework.Controls.MetroTile();
            this.metroTile14 = new MetroFramework.Controls.MetroTile();
            this.metroTile15 = new MetroFramework.Controls.MetroTile();
            this.metroTile16 = new MetroFramework.Controls.MetroTile();
            this.metroTile17 = new MetroFramework.Controls.MetroTile();
            this.metroTile18 = new MetroFramework.Controls.MetroTile();
            this.metroTile19 = new MetroFramework.Controls.MetroTile();
            this.metroTile20 = new MetroFramework.Controls.MetroTile();
            this.metroTile21 = new MetroFramework.Controls.MetroTile();
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
            this.flowLayoutPanel1.Controls.Add(this.metroTile2);
            this.flowLayoutPanel1.Controls.Add(this.metroTile3);
            this.flowLayoutPanel1.Controls.Add(this.metroTile4);
            this.flowLayoutPanel1.Controls.Add(this.metroTile1);
            this.flowLayoutPanel1.Controls.Add(this.metroTile5);
            this.flowLayoutPanel1.Controls.Add(this.metroTile6);
            this.flowLayoutPanel1.Controls.Add(this.metroTile7);
            this.flowLayoutPanel1.Controls.Add(this.metroTile8);
            this.flowLayoutPanel1.Controls.Add(this.metroTile9);
            this.flowLayoutPanel1.Controls.Add(this.metroTile10);
            this.flowLayoutPanel1.Controls.Add(this.metroTile11);
            this.flowLayoutPanel1.Controls.Add(this.metroTile12);
            this.flowLayoutPanel1.Controls.Add(this.metroTile13);
            this.flowLayoutPanel1.Controls.Add(this.metroTile14);
            this.flowLayoutPanel1.Controls.Add(this.metroTile15);
            this.flowLayoutPanel1.Controls.Add(this.metroTile16);
            this.flowLayoutPanel1.Controls.Add(this.metroTile17);
            this.flowLayoutPanel1.Controls.Add(this.metroTile18);
            this.flowLayoutPanel1.Controls.Add(this.metroTile19);
            this.flowLayoutPanel1.Controls.Add(this.metroTile20);
            this.flowLayoutPanel1.Controls.Add(this.metroTile21);
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 109);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(128, 100);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseVisualStyleBackColor = true;
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
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(3, 215);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(128, 100);
            this.metroTile8.TabIndex = 8;
            this.metroTile8.Text = "metroTile8";
            this.metroTile8.UseSelectable = true;
            this.metroTile8.UseVisualStyleBackColor = true;
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Location = new System.Drawing.Point(137, 215);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(128, 100);
            this.metroTile9.TabIndex = 9;
            this.metroTile9.Text = "metroTile9";
            this.metroTile9.UseSelectable = true;
            this.metroTile9.UseVisualStyleBackColor = true;
            // 
            // metroTile10
            // 
            this.metroTile10.ActiveControl = null;
            this.metroTile10.Location = new System.Drawing.Point(271, 215);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(128, 100);
            this.metroTile10.TabIndex = 10;
            this.metroTile10.Text = "metroTile10";
            this.metroTile10.UseSelectable = true;
            this.metroTile10.UseVisualStyleBackColor = true;
            // 
            // metroTile11
            // 
            this.metroTile11.ActiveControl = null;
            this.metroTile11.Location = new System.Drawing.Point(405, 215);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(128, 100);
            this.metroTile11.TabIndex = 11;
            this.metroTile11.Text = "metroTile11";
            this.metroTile11.UseSelectable = true;
            this.metroTile11.UseVisualStyleBackColor = true;
            // 
            // metroTile12
            // 
            this.metroTile12.ActiveControl = null;
            this.metroTile12.Location = new System.Drawing.Point(3, 321);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(128, 100);
            this.metroTile12.TabIndex = 12;
            this.metroTile12.Text = "metroTile12";
            this.metroTile12.UseSelectable = true;
            this.metroTile12.UseVisualStyleBackColor = true;
            // 
            // metroTile13
            // 
            this.metroTile13.ActiveControl = null;
            this.metroTile13.Location = new System.Drawing.Point(137, 321);
            this.metroTile13.Name = "metroTile13";
            this.metroTile13.Size = new System.Drawing.Size(128, 100);
            this.metroTile13.TabIndex = 13;
            this.metroTile13.Text = "metroTile13";
            this.metroTile13.UseSelectable = true;
            this.metroTile13.UseVisualStyleBackColor = true;
            // 
            // metroTile14
            // 
            this.metroTile14.ActiveControl = null;
            this.metroTile14.Location = new System.Drawing.Point(271, 321);
            this.metroTile14.Name = "metroTile14";
            this.metroTile14.Size = new System.Drawing.Size(128, 100);
            this.metroTile14.TabIndex = 14;
            this.metroTile14.Text = "metroTile14";
            this.metroTile14.UseSelectable = true;
            this.metroTile14.UseVisualStyleBackColor = true;
            // 
            // metroTile15
            // 
            this.metroTile15.ActiveControl = null;
            this.metroTile15.Location = new System.Drawing.Point(405, 321);
            this.metroTile15.Name = "metroTile15";
            this.metroTile15.Size = new System.Drawing.Size(128, 100);
            this.metroTile15.TabIndex = 15;
            this.metroTile15.Text = "metroTile15";
            this.metroTile15.UseSelectable = true;
            this.metroTile15.UseVisualStyleBackColor = true;
            // 
            // metroTile16
            // 
            this.metroTile16.ActiveControl = null;
            this.metroTile16.Location = new System.Drawing.Point(3, 427);
            this.metroTile16.Name = "metroTile16";
            this.metroTile16.Size = new System.Drawing.Size(128, 100);
            this.metroTile16.TabIndex = 16;
            this.metroTile16.Text = "metroTile16";
            this.metroTile16.UseSelectable = true;
            this.metroTile16.UseVisualStyleBackColor = true;
            // 
            // metroTile17
            // 
            this.metroTile17.ActiveControl = null;
            this.metroTile17.Location = new System.Drawing.Point(137, 427);
            this.metroTile17.Name = "metroTile17";
            this.metroTile17.Size = new System.Drawing.Size(128, 100);
            this.metroTile17.TabIndex = 17;
            this.metroTile17.Text = "metroTile17";
            this.metroTile17.UseSelectable = true;
            this.metroTile17.UseVisualStyleBackColor = true;
            // 
            // metroTile18
            // 
            this.metroTile18.ActiveControl = null;
            this.metroTile18.Location = new System.Drawing.Point(271, 427);
            this.metroTile18.Name = "metroTile18";
            this.metroTile18.Size = new System.Drawing.Size(128, 100);
            this.metroTile18.TabIndex = 18;
            this.metroTile18.Text = "metroTile18";
            this.metroTile18.UseSelectable = true;
            this.metroTile18.UseVisualStyleBackColor = true;
            // 
            // metroTile19
            // 
            this.metroTile19.ActiveControl = null;
            this.metroTile19.Location = new System.Drawing.Point(405, 427);
            this.metroTile19.Name = "metroTile19";
            this.metroTile19.Size = new System.Drawing.Size(128, 100);
            this.metroTile19.TabIndex = 19;
            this.metroTile19.Text = "metroTile19";
            this.metroTile19.UseSelectable = true;
            this.metroTile19.UseVisualStyleBackColor = true;
            // 
            // metroTile20
            // 
            this.metroTile20.ActiveControl = null;
            this.metroTile20.Location = new System.Drawing.Point(3, 533);
            this.metroTile20.Name = "metroTile20";
            this.metroTile20.Size = new System.Drawing.Size(128, 100);
            this.metroTile20.TabIndex = 20;
            this.metroTile20.Text = "metroTile20";
            this.metroTile20.UseSelectable = true;
            this.metroTile20.UseVisualStyleBackColor = true;
            // 
            // metroTile21
            // 
            this.metroTile21.ActiveControl = null;
            this.metroTile21.Location = new System.Drawing.Point(137, 533);
            this.metroTile21.Name = "metroTile21";
            this.metroTile21.Size = new System.Drawing.Size(128, 100);
            this.metroTile21.TabIndex = 21;
            this.metroTile21.Text = "metroTile21";
            this.metroTile21.UseSelectable = true;
            this.metroTile21.UseVisualStyleBackColor = true;
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
        private MetroFramework.Controls.MetroTile tileProductManagement;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroTile metroTile12;
        private MetroFramework.Controls.MetroTile metroTile13;
        private MetroFramework.Controls.MetroTile metroTile14;
        private MetroFramework.Controls.MetroTile metroTile15;
        private MetroFramework.Controls.MetroTile metroTile16;
        private MetroFramework.Controls.MetroTile metroTile17;
        private MetroFramework.Controls.MetroTile metroTile18;
        private MetroFramework.Controls.MetroTile metroTile19;
        private MetroFramework.Controls.MetroTile metroTile20;
        private MetroFramework.Controls.MetroTile metroTile21;
    }
}