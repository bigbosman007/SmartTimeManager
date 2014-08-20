namespace STmanager
{
    partial class frmEmployee
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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnInsert = new MetroFramework.Controls.MetroTile();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.msmFrmProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // msmFrmProducts
            // 
            this.msmFrmProducts.Owner = null;
            this.msmFrmProducts.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(592, 144);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(142, 78);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "ปิดหน้าต่าง";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.ActiveControl = null;
            this.btnInsert.Location = new System.Drawing.Point(592, 62);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(142, 78);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "เพิ่มพนักงาน";
            this.btnInsert.UseSelectable = true;
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 62);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 367);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 488);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listView1);
            this.Name = "frmEmployee";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmFrmProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmFrmProducts;
        private MetroFramework.Components.MetroStyleExtender mseFrmProducts;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile btnInsert;
        private System.Windows.Forms.ListView listView1;
    }
}