﻿namespace STmanager
{
    partial class frmProducts
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
            this.msmFrmProducts = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mseFrmProducts = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnInsert = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.msmFrmProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // msmFrmProducts
            // 
            this.msmFrmProducts.Owner = null;
            this.msmFrmProducts.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 63);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 367);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsert
            // 
            this.btnInsert.ActiveControl = null;
            this.btnInsert.Location = new System.Drawing.Point(598, 63);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(142, 78);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "เพิ่มสินค้า";
            this.btnInsert.UseSelectable = true;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(598, 145);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(142, 78);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "ปิดหน้าต่าง";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseVisualStyleBackColor = true;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 537);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "จัดการสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.msmFrmProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmFrmProducts;
        private MetroFramework.Components.MetroStyleExtender mseFrmProducts;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroTile btnInsert;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}