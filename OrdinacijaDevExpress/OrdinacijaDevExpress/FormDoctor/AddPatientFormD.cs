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

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class AddPatientFormD : DevExpress.XtraEditors.XtraForm
    {
        DBCommunication.DBCommunication _DB;
        private Patient patient;
        private int doctor;
        public AddPatientFormD(DBCommunication.DBCommunicationAdmin _db, int doctorID)
        {
            InitializeComponent();
            _DB = _db;
            doctor = doctorID;

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(NameTE.Text) && !string.IsNullOrWhiteSpace(SurnameTE.Text) && !string.IsNullOrWhiteSpace(EmailTE.Text) && !string.IsNullOrWhiteSpace(ContactTE.Text))
            {
                patient = new Patient();
                patient.Name = NameTE.Text;
                patient.Surname = SurnameTE.Text;
                patient.Email = EmailTE.Text;
                patient.Contact = ContactTE.Text;
                patient.Doctor = doctor;
                if (_DB.InsertPatient(patient))
                {
                    XtraMessageBox.Show("Patient is added!");
                    NameTE.Text=string.Empty;
                    SurnameTE.Text = string.Empty;
                    EmailTE.Text = string.Empty;
                    ContactTE.Text = string.Empty;
                }
                else
                {
                    XtraMessageBox.Show("Patient was not added");
                }

            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }
    }
}