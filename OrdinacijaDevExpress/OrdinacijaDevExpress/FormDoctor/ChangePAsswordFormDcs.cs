using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models.Model;
using System.Security.Cryptography;

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class ChangePAsswordFormDcs : DevExpress.XtraEditors.XtraForm
    {
        DBCommunication.DBCommunication _DB;
        private int doctor;
        private List<Doctor> _doctor;
        private Doctor dr;
        public ChangePAsswordFormDcs(DBCommunication.DBCommunicationAdmin _db, int doctorID)
        {
            InitializeComponent();
            _DB = _db;
            doctor = doctorID;
            _doctor = _DB.GetDoctorID(doctor);
            dr = _doctor[0];
        }

        private void ChangeBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(OldTE.Text) && !string.IsNullOrWhiteSpace(NewTE.Text) && !string.IsNullOrWhiteSpace(ReTE.Text))
            {
                if (CalculateMD5Hash(OldTE.Text) == dr.Password && NewTE.Text == ReTE.Text)
                {
                    if (_DB.ChangePassword(doctor, NewTE.Text))
                    {
                        XtraMessageBox.Show("The password has been changed!");
                        OldTE.Text = string.Empty;
                        NewTE.Text = string.Empty;
                        ReTE.Text = string.Empty;
                    }
                    else
                    {
                        XtraMessageBox.Show("The password has been changed!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Old password is invalid or new ones are not the same!");
                }
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
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

    }
}