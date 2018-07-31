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
using System.Security.Cryptography;

namespace OrdinacijaDevExpress
{
    public partial class LoginForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DBCommunication.DBCommunicationAdmin _DB = new DBCommunication.DBCommunicationAdmin();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        private void Login()
        {
            if (EmailTE.Text == "admin" && PasswordTE.Text == "admin")
            {
              MainForm mf=new MainForm();
                mf.Show();
                //this.Close();
            }
            else
            {

                string pass = _DB.Login(EmailTE.Text, PasswordTE.Text);
                if (pass.Split(';')[0]== Base64Encode(CalculateMD5Hash("1950th"+ EmailTE.Text + ";"+ PasswordTE.Text)))
                {
                    FormDoctor.MainFormDoctor mfd = new FormDoctor.MainFormDoctor(pass.Split(';')[1]);
                    mfd.Show();
                    //this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Username and password are invalid! Please try again!");
                }
            }
        }

        private void PasswordTE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }

        }
        public string CalculateMD5Hash(string input)

        {

            

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

          

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            return sb.ToString();

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}