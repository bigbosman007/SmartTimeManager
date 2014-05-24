namespace STmanager
{
    partial class frmSale
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.txtgen = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtprice);
            this.metroPanel1.Controls.Add(this.txtgen);
            this.metroPanel1.Controls.Add(this.txtbrand);
            this.metroPanel1.Controls.Add(this.txtname);
            this.metroPanel1.Controls.Add(this.txtsid);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(14, 141);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(334, 604);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(129, 27);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(202, 22);
            this.txtsid.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(129, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(202, 22);
            this.txtname.TabIndex = 3;
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(129, 83);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(202, 22);
            this.txtbrand.TabIndex = 4;
            // 
            // txtgen
            // 
            this.txtgen.Location = new System.Drawing.Point(129, 111);
            this.txtgen.Name = "txtgen";
            this.txtgen.Size = new System.Drawing.Size(202, 22);
            this.txtgen.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(129, 139);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(202, 22);
            this.txtprice.TabIndex = 6;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(146, 113);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(202, 22);
            this.txtdate.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.metroLabel1.Location = new System.Drawing.Point(1138, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Name : N/A";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.metroLabel2.Location = new System.Drawing.Point(1138, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Date Time : N/A";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.metroLabel3.Location = new System.Drawing.Point(1138, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Status : N/A";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.metroPanel1);
            this.Movable = false;
            this.Name = "frmSale";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "การขาย(Sale)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtgen;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtdate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}