namespace STmanager
{
    partial class dlgLogin
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.smDlgLogin = new MetroFramework.Components.MetroStyleManager(this.components);
            this.seDlgLogin = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smDlgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seDlgLogin.SetApplyMetroTheme(this.txtBarcode, true);
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBarcode.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBarcode.Location = new System.Drawing.Point(203, 131);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '*';
            this.txtBarcode.Size = new System.Drawing.Size(364, 47);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(197, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Barcode";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(200, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "*กรุณายิงบาร์โค้ดด้านหลังบัตรประจำตัวพนักงานเพื่อเข้าสู่ระบบ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::STmanager.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // smDlgLogin
            // 
            this.smDlgLogin.Owner = this;
            this.smDlgLogin.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // seDlgLogin
            // 
            this.seDlgLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImagePadding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.BackMaxSize = 100;
            this.ClientSize = new System.Drawing.Size(596, 258);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Movable = false;
            this.Name = "dlgLogin";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Login(เข้าสู่ระบบ)";
            this.Load += new System.EventHandler(this.dlgLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smDlgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleExtender seDlgLogin;
        private MetroFramework.Components.MetroStyleManager smDlgLogin;

    }
}

