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
using DevExpress.XtraGrid.Views.Grid;

namespace OrdinacijaDevExpress
{
    public partial class PatientForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<Patient> _patient;
        private List<Doctor> _doctor;
        private Patient patient;
        public PatientForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            _DB = _db;
            _patient = _DB.GetPatient();
            PatientGridControl.DataSource = _patient;
            _doctor = _DB.GetDoctor();
            DoctorLE.Properties.DataSource = _doctor;
            DoctorLE.Properties.DisplayMember = "Surname";
            DoctorLE.Properties.ValueMember = "ID";
        }

        private void PatientForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearData()
        {
            NameTE.Text = string.Empty;
            SurnameTE.Text = string.Empty;
            EmailTE.Text = string.Empty;
            ConactTE.Text = string.Empty;
            DoctorLE.EditValue = null;
        }

        private void NewPatientBarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTE.Text) && !string.IsNullOrWhiteSpace(SurnameTE.Text) && !string.IsNullOrWhiteSpace(EmailTE.Text) && !string.IsNullOrWhiteSpace(ConactTE.Text) && DoctorLE.EditValue != null)
            {
                patient = new Patient();
                patient.Name = NameTE.Text;
                patient.Surname = SurnameTE.Text;
                patient.Email = EmailTE.Text;
                patient.Contact = ConactTE.Text;
                patient.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                if(!_DB.InsertPatient(patient))
                {
                    XtraMessageBox.Show("Element is not added!");
                }
                _patient = _DB.GetPatient();
                PatientGridControl.DataSource = _patient;
                ClearData();
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }

        }

        private void EditPatientBarItem_Click(object sender, EventArgs e)
        {
            if (patient!=null && !string.IsNullOrWhiteSpace(NameTE.Text) && !string.IsNullOrWhiteSpace(SurnameTE.Text) && !string.IsNullOrWhiteSpace(EmailTE.Text) && !string.IsNullOrWhiteSpace(ConactTE.Text) && DoctorLE.EditValue != null)
            {
                patient.Name = NameTE.Text;
                patient.Surname = SurnameTE.Text;
                patient.Email = EmailTE.Text;
                patient.Contact = ConactTE.Text;
                patient.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                if (!_DB.UpdatePatient(patient))
                {
                    XtraMessageBox.Show("Element is not edited!");
                }
                _patient = _DB.GetPatient();
                PatientGridControl.DataSource = _patient;
                ClearData();
                patient = new Patient(); 
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void PatientGridView_RowClick(object sender, RowClickEventArgs e)
        {
            patient = new Patient();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                patient = (Patient)row;
                NameTE.Text = patient.Name;
                SurnameTE.Text = patient.Surname;
                EmailTE.Text = patient.Email;
                ConactTE.Text = patient.Contact;
                DoctorLE.EditValue = patient.Doctor;
                
            }
            catch 
            {
                
            }
        }

        private void DeletePatientBarItem_Click(object sender, EventArgs e)
        {
            if (patient != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("You really want to delete the selected element?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!_DB.DeletePatient(patient))
                    {
                        XtraMessageBox.Show("Element is not deleted!");
                    }
                    ClearData();
                    patient = new Patient();
                    _patient = _DB.GetPatient();
                    PatientGridControl.DataSource = _patient;

                }
            }
            else
            {
                XtraMessageBox.Show("Element is not selected!");
            }
        }

        private void PatientGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "PatientDoctor")
            {
                foreach (Doctor dr in _doctor)
                {
                    if (e.Value.ToString() == dr.ID.ToString())
                    {
                        e.DisplayText = dr.Name + " " + dr.Surname;
                    }
                }
            }
        }
    }
}