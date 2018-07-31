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
    public partial class EditPatientFormD : DevExpress.XtraEditors.XtraForm
    {
        DBCommunication.DBCommunication _DB;
        private List<Patient> _ptaient;
        private Patient patient;
        private int pat;
        public EditPatientFormD(DBCommunication.DBCommunicationAdmin _db, int patientID)
        {
            InitializeComponent();
            _DB = _db;
            pat = patientID;
            _ptaient = _DB.GetPatientID(pat);
            patient = _ptaient[0];
            NameTE.Text = patient.Name;
            SurnameTE.Text = patient.Surname;
            EmailTE.Text = patient.Email;
            ContactTE.Text = patient.Contact;

        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTE.Text) && !string.IsNullOrWhiteSpace(SurnameTE.Text) && !string.IsNullOrWhiteSpace(EmailTE.Text) && !string.IsNullOrWhiteSpace(ContactTE.Text))
            {
               
                patient.Name = NameTE.Text;
                patient.Surname = SurnameTE.Text;
                patient.Email = EmailTE.Text;
                patient.Contact = ContactTE.Text;
                if (_DB.UpdatePatient(patient))
                {
                    XtraMessageBox.Show("Patient is amended!");
                    NameTE.Text = string.Empty;
                    SurnameTE.Text = string.Empty;
                    EmailTE.Text = string.Empty;
                    ContactTE.Text = string.Empty;
                }
                else
                {
                    XtraMessageBox.Show("Patient was not amended");
                }

            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }
    }
}