﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Models.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class MainFormDoctor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DBCommunication.DBCommunicationAdmin _DB = new DBCommunication.DBCommunicationAdmin();
        private List<Patient> _patien;
        private Patient patient;
        private int doctorID;
        public MainFormDoctor(string doctor)
        {
            InitializeComponent();
            try
            {
                doctorID = int.Parse(doctor);
                _patien = _DB.GetPatientForDoctor(1);
                PatientGridControl.DataSource = _patien;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void PatientGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            patient = new Patient();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                patient = (Patient)row;
                

                label1.Text = "Selected patient is " + patient.Name + " " + patient.Surname;
            }
            catch
            {

            }
        }

        private void PatientInfoBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(patient!=null)
                using (FormDoctor.PatientInfoForm _patrient_info_form = new FormDoctor.PatientInfoForm(_DB,patient.ID))
                {
                    _patrient_info_form.StartPosition = FormStartPosition.CenterScreen;
                    _patrient_info_form.ShowDialog();
                    
                }
        }

        private void VisitDoctorBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
                using (FormDoctor.VisitDoctorFormD _visit_doctor_form = new FormDoctor.VisitDoctorFormD(_DB, doctorID, patient.ID))
                {
                    _visit_doctor_form.StartPosition = FormStartPosition.CenterScreen;
                    _visit_doctor_form.ShowDialog();

                }
        }

        private void DiagnoseBarItme_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
                using (FormDoctor.DiagnoseFormD _diagnosis_form = new FormDoctor.DiagnoseFormD(_DB, doctorID,patient.ID))
                {
                    _diagnosis_form.StartPosition = FormStartPosition.CenterScreen;
                    _diagnosis_form.ShowDialog();

                }
        }

        private void ReferalBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
                using (FormDoctor.ReferralFormD _referral_form = new FormDoctor.ReferralFormD(_DB, doctorID,patient.ID))
                {
                    _referral_form.StartPosition = FormStartPosition.CenterScreen;
                    _referral_form.ShowDialog();

                }
        }

        private void AgreedTermBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
                using (FormDoctor.AgreedTermForPatientFormD _agreed_term_for_patient_form = new FormDoctor.AgreedTermForPatientFormD(_DB, patient.ID))
                {
                    _agreed_term_for_patient_form.StartPosition = FormStartPosition.CenterScreen;
                    _agreed_term_for_patient_form.ShowDialog();

                }
        }

        private void ChangePasswordBarITem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (FormDoctor.ChangePAsswordFormDcs _change_password_form = new FormDoctor.ChangePAsswordFormDcs(_DB, doctorID))
            {
                _change_password_form.StartPosition = FormStartPosition.CenterScreen;
                _change_password_form.ShowDialog();

            }
        }

        private void NewPatientBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (FormDoctor.AddPatientFormD _add_patient_form = new FormDoctor.AddPatientFormD(_DB, doctorID))
            {
                _add_patient_form.StartPosition = FormStartPosition.CenterScreen;
                _add_patient_form.ShowDialog();

            }
        }

        private void EditPatientBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(patient!=null)
            {
                using (FormDoctor.EditPatientFormD _edit_patient_form = new FormDoctor.EditPatientFormD(_DB, patient.ID))
                {
                    _edit_patient_form.StartPosition = FormStartPosition.CenterScreen;
                    _edit_patient_form.ShowDialog();

                }
            }
        }

        private void MainFormDoctor_Activated(object sender, EventArgs e)
        {
            _patien = _DB.GetPatientForDoctor(1);
            PatientGridControl.DataSource = _patien;
        }

        private void DeletePatientBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!_DB.DeletePatient(patient))
                    {
                        XtraMessageBox.Show("");
                    }
                   
                    patient = new Patient();
                    _patien = _DB.GetPatientForDoctor(1);
                    PatientGridControl.DataSource = _patien;

                }
            }

        }
    }
}