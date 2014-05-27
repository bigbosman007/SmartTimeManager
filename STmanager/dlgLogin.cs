using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace STmanager
{
    public partial class dlgLogin : MetroForm
    {
        public dlgLogin()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Utility.Login(txtBarcode.Text, out Utility.CurrentEmployee)) 
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid User ID");
                    txtBarcode.Clear();
                }
            }
        }

        private void dlgLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
