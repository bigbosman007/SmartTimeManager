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
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Utility.MaximizeForm(this);
            btnLogout.PerformClick();
            
            /*
            frmProducts frmProduct = new frmProducts();
            PrepareChildForm(ref frmProduct);
            pnlFrmDock.Controls.Add(frmProduct);
             */
        }

        private void PrepareChildForm(ref MetroForm DestinationForm)
        {
            DestinationForm.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            DestinationForm.Dock = DockStyle.Fill;
            DestinationForm.TopLevel = false;
            DestinationForm.Visible = true;
            DestinationForm.ControlBox = false;

        }
        private bool Login()
        {
            dlgLogin dlgLogin = new dlgLogin();
            DialogResult LoginResult = dlgLogin.ShowDialog();

            if (LoginResult == DialogResult.OK)
            {
                lblCurrentEmpID.Text = Utility.CurrentEmployee.emp_id;
                lblCurrentEmpName.Text = string.Format("Welcome : {0} {1}",
                    Utility.CurrentEmployee.emp_name,
                    Utility.CurrentEmployee.emp_last);
                btnLogout.Text = "Logout";
                lblEmployeePermission.Text = string.Format("Available tasks for {0}",
                    Utility.CurrentEmployee.EmployeePermission.Name);
                mtabMainMenuHost.Visible = true;
                return true;
            }
            return false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(Utility.CurrentEmployee != null)
            {
                Utility.CurrentEmployee = null;
                btnLogout.Text = "Login";
                lblCurrentEmpID.Text = "Logged Out";
                lblCurrentEmpName.Text = "Waiting for user";
                mtabMainMenuHost.Visible = false;
            }
            while (!Login()) ;
        }
    }
}
