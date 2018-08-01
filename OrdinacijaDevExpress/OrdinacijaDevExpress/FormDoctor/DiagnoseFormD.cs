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

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class DiagnoseFormD : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<Diagnosis> _diagnosis;
        private Diagnosis diagnosis;
        private int doctor;
        private int patient;
        public DiagnoseFormD(DBCommunication.DBCommunicationAdmin _db,int doctorID, int patientID)
        {
            InitializeComponent();
            _DB = _db;
            patient = patientID;
            doctor = doctorID;
            _diagnosis = _DB.GetDiagnosisForPatient(patientID);
            DiagnosisGridControl.DataSource = _diagnosis;

        }
        private void ClearData()
        {
            diagnosis = new Diagnosis();
            DescriptionME.Text = string.Empty;
            NameTE.Text = string.Empty;
            
        }
        private void NewBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(NameTE.Text) )
            {
                diagnosis = new Diagnosis();
                diagnosis.Name = NameTE.Text;
                diagnosis.Description = DescriptionME.Text;
                diagnosis.Doctor = doctor;
                diagnosis.Patient = patient;
                if (!_DB.InsertDiagnosis(diagnosis))
                {
                    XtraMessageBox.Show("");
                }
                ClearData();
                _diagnosis = _DB.GetDiagnosisForPatient(patient);
                DiagnosisGridControl.DataSource = _diagnosis;

            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (diagnosis != null && !string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(NameTE.Text))
            {

                diagnosis.Name = NameTE.Text;
                diagnosis.Description = DescriptionME.Text;
                diagnosis.Doctor = doctor;
                diagnosis.Patient = patient;
                if (!_DB.UpdateDiagnosis(diagnosis))
                {
                    XtraMessageBox.Show("");
                }
                ClearData();
                _diagnosis = _DB.GetDiagnosisForPatient(patient);
                DiagnosisGridControl.DataSource = _diagnosis;
            }
            else
            {
                XtraMessageBox.Show("");
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
                        XtraMessageBox.Show("");
                    }
                    ClearData();
                    _diagnosis = _DB.GetDiagnosisForPatient(patient);
                    DiagnosisGridControl.DataSource = _diagnosis;
                }
            }
            else
            {
                XtraMessageBox.Show("");
            }
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
    }
}