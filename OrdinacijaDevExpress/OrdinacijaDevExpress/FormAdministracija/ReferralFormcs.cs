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
using Models.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace OrdinacijaDevExpress
{
    public partial class ReferralFormcs : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<Referral> _referral;
        private Referral referral;
        private List<Patient> _patient;
        private List<Doctor> _doctor;
        public ReferralFormcs(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            
            _DB = _db;
            _referral = _DB.GetReferral();
            ReferralGridControl.DataSource = _referral;

            _doctor = _DB.GetDoctor();
            DoctorLE.Properties.DataSource = _doctor;

            _patient = _DB.GetPatient();
            PatientLE.Properties.DataSource = _patient;

            DoctorLE.Properties.DisplayMember = "Surname";
            DoctorLE.Properties.ValueMember = "ID";

            PatientLE.Properties.DisplayMember = "Surname";
            PatientLE.Properties.ValueMember = "ID";
        }

        private void NewBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(NameTE.Text) && PatientLE.EditValue != null && DoctorLE.EditValue != null)
            {
                referral = new Referral();
                referral.Name = NameTE.Text;
                referral.Description = DescriptionME.Text;
                referral.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                referral.Patient = int.Parse(PatientLE.EditValue.ToString());
                if (!_DB.InsertReferral(referral))
                {
                    XtraMessageBox.Show("Element is not added!");
                }
                ClearData();
                _referral = _DB.GetReferral();
                ReferralGridControl.DataSource = _referral;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (referral!=null && !string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(NameTE.Text) && PatientLE.EditValue != null && DoctorLE.EditValue != null)
            {
                
                referral.Name = NameTE.Text;
                referral.Description = DescriptionME.Text;
                referral.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                referral.Patient = int.Parse(PatientLE.EditValue.ToString());
                if (!_DB.UpdateReferral(referral))
                {
                    XtraMessageBox.Show("Element is not edited!");
                }
                ClearData();
                _referral = _DB.GetReferral();
                ReferralGridControl.DataSource = _referral;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void DeleteBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (referral != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("You really want to delete the selected element?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (!_DB.DeleteReferral(referral))
                    {
                        XtraMessageBox.Show("Element is not deleted!");
                    }
                    ClearData();
                    _referral = _DB.GetReferral();
                    ReferralGridControl.DataSource = _referral;
                }
            }
            else
            {
                XtraMessageBox.Show("Element is not selected!");
            } 
        }
        private void ClearData()
        {
            referral = new Referral();
            DescriptionME.Text = string.Empty;
            NameTE.Text = string.Empty;
            PatientLE.EditValue = null;
            DoctorLE.EditValue = null;
        }

        private void ReferralGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            referral = new Referral();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                referral = (Referral)row;

                DescriptionME.Text = referral.Description;
                NameTE.Text = referral.Name;
                PatientLE.EditValue = referral.Patient;
                DoctorLE.EditValue = referral.Doctor;

            }
            catch
            {

            }
        }

        private void ReferralGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "ReferralPatient")
            {
                foreach (Patient p in _patient)
                {
                    if (e.Value.ToString() == p.ID.ToString())
                    {
                        e.DisplayText = p.Name + " " + p.Surname;
                    }
                }
            }
            if (e.Column.Name == "ReferralDoctor")
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