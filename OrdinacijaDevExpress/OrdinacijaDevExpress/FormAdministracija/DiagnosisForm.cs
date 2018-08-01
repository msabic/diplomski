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
   
    public partial class DiagnosisForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<Diagnosis> _diagnosis;
        private Diagnosis diagnosis;
        private List<Patient> _patient;
        private List<Doctor> _doctor;
        public DiagnosisForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            _DB = _db;
            _diagnosis = _DB.GetDiagnosis();
            DiagnosisGridControl.DataSource = _diagnosis;

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
                diagnosis = new Diagnosis();
                diagnosis.Name = NameTE.Text;
                diagnosis.Description = DescriptionME.Text;
                diagnosis.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                diagnosis.Patient = int.Parse(PatientLE.EditValue.ToString());
                if (!_DB.InsertDiagnosis(diagnosis))
                {
                    XtraMessageBox.Show("Element is not added!");
                }
               
                ClearData();
                _diagnosis = _DB.GetDiagnosis();
                DiagnosisGridControl.DataSource = _diagnosis;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (diagnosis != null && !string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(NameTE.Text) && PatientLE.EditValue != null && DoctorLE.EditValue != null)
            {

                diagnosis.Name = NameTE.Text;
                diagnosis.Description = DescriptionME.Text;
                diagnosis.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                diagnosis.Patient = int.Parse(PatientLE.EditValue.ToString());
                if (!_DB.UpdateDiagnosis(diagnosis))
                {
                    XtraMessageBox.Show("Element is not edited!");
                }
                
                ClearData();
                _diagnosis = _DB.GetDiagnosis();
                DiagnosisGridControl.DataSource = _diagnosis;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void DeleteBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (diagnosis != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("You really want to delete the selected element?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (!_DB.DeleteDiagnosis(diagnosis))
                    {
                        XtraMessageBox.Show("Element is not deleted!");
                    }
                    ClearData();
                    _diagnosis = _DB.GetDiagnosis();
                    DiagnosisGridControl.DataSource = _diagnosis;
                }
            }
            else
            {
                XtraMessageBox.Show("Element is not selected!");
            }
        }
        private void ClearData()
        {
            diagnosis = new Diagnosis();
            DescriptionME.Text = string.Empty;
            NameTE.Text = string.Empty;
            PatientLE.EditValue = null;
            DoctorLE.EditValue = null;
        }

        private void DiagnosisGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            diagnosis = new Diagnosis();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                diagnosis = (Diagnosis)row;

                DescriptionME.Text = diagnosis.Description;
                NameTE.Text = diagnosis.Name;


            }
            catch
            {

            }
        }

        private void DiagnosisGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
           
        }

        private void DiagnosisGridView_CustomColumnDisplayText_1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "DiagnosisPatient")
            {
                foreach (Patient p in _patient)
                {
                    if (e.Value.ToString() == p.ID.ToString())
                    {
                        e.DisplayText = p.Name + " " + p.Surname;
                    }
                }
            }
            if (e.Column.Name == "DiagnosisDoctor")
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