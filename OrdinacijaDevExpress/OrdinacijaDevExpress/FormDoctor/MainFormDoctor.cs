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
using DevExpress.XtraGrid.Views.Grid;

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class MainFormDoctor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DBCommunication.DBCommunicationAdmin _DB = new DBCommunication.DBCommunicationAdmin();
        private List<Patient> _patien;
        private Patient patient;
        public MainFormDoctor()
        {
            InitializeComponent();
            _patien = _DB.GetPatientForDoctor(1);
            PatientGridControl.DataSource = _patien;
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
                using (FormDoctor.PatientInfoForm _patrient_info_form = new FormDoctor.PatientInfoForm(_DB, patient.ID))
                {
                    _patrient_info_form.StartPosition = FormStartPosition.CenterScreen;
                    _patrient_info_form.ShowDialog();

                }
        }

        private void DiagnoseBarItme_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
                using (FormDoctor.PatientInfoForm _patrient_info_form = new FormDoctor.PatientInfoForm(_DB, patient.ID))
                {
                    _patrient_info_form.StartPosition = FormStartPosition.CenterScreen;
                    _patrient_info_form.ShowDialog();

                }
        }

        private void ReferalBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
                using (FormDoctor.PatientInfoForm _patrient_info_form = new FormDoctor.PatientInfoForm(_DB, patient.ID))
                {
                    _patrient_info_form.StartPosition = FormStartPosition.CenterScreen;
                    _patrient_info_form.ShowDialog();

                }
        }

        private void AgreedTermBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (patient != null)
                using (FormDoctor.PatientInfoForm _patrient_info_form = new FormDoctor.PatientInfoForm(_DB, patient.ID))
                {
                    _patrient_info_form.StartPosition = FormStartPosition.CenterScreen;
                    _patrient_info_form.ShowDialog();

                }
        }
    }
}