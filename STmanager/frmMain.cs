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

            dlgLogin dlgLogin = new dlgLogin();
            DialogResult LoginResult = dlgLogin.ShowDialog();

            if (LoginResult == DialogResult.OK)
            {
                metroLabel1.Text = "Login State : Logged";
            }

            var emp = Utility.testjoinn();
            foreach(var em in emp)
            {
                ListViewItem item = new ListViewItem()
                {
                    Text = em.emp.emp_id
                };
                item.SubItems.AddRange(new string[]
                        {
                        em.emp.emp_name,
                        em.emp.emp_tel,
                        em.branch.branch_name
                        });

                lsvDemo.Items.Add(item);
            }
        }
    }
}
