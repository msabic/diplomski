using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace OrdinacijaDevExpress
{
    public partial class LoginForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private bool Login()
        {
            if (EmailTE.Text == "admin" && PasswordTE.Text == "admin")
            {
                return true;
            }
            else
            {

                if(true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void PasswordTE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(Login())
                {
                    MainForm mform = new MainForm();
                    mform.Show();
                    this.Close();
                }
                else
                {
                    PasswordTE.Text = string.Empty;
                    XtraMessageBox.Show("Invalid user!");
                }
            }

        }
    }
}