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
    public partial class VisitDoctorFormD : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<VisitDoctor> _vistiDoctor;
        private VisitDoctor vistitDoctor;
        private int doctor;
        private int patient;
        public VisitDoctorFormD(DBCommunication.DBCommunicationAdmin _db,int doctorID, int patientID)
        {
            InitializeComponent();
            _DB = _db;
            doctor = doctorID;
            patient = patientID;
            _vistiDoctor = _DB.GetVistiDoctorForPatient(patientID);
            VisitDoctorGridControl.DataSource= _vistiDoctor;
        }

        private void AddBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ReasonME.Text) && !string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(DateTE.Text) && DateTE.DateTime > DateTime.Now)
            {
                vistitDoctor = new VisitDoctor();
                vistitDoctor.Date = DateTE.DateTime;
                vistitDoctor.Reason = ReasonME.Text;
                vistitDoctor.Description = DescriptionME.Text;
                vistitDoctor.Patient = patient;
                vistitDoctor.Doctor = doctor;
                if (!_DB.InsertVisitDoctor(vistitDoctor))
                {
                    XtraMessageBox.Show("Visit is not added!");
                }
                CleatData();
                _vistiDoctor = _DB.GetVistiDoctorForPatient(patient);
                VisitDoctorGridControl.DataSource = _vistiDoctor;
            }
            else
            {
                XtraMessageBox.Show("Data is not valid!");
            }
        }
        private void CleatData()
        {
            ReasonME.Text = string.Empty;
            DescriptionME.Text = string.Empty;
            DateTE.Text = string.Empty;
        }

        private void DeleteBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (vistitDoctor != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!_DB.DeleteVisitDoctor(vistitDoctor))
                    {

                        XtraMessageBox.Show("");

                    }
                    _vistiDoctor = _DB.GetVistiDoctorForPatient(patient);
                    VisitDoctorGridControl.DataSource = _vistiDoctor;
                    CleatData();
                }
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (vistitDoctor != null && !string.IsNullOrWhiteSpace(ReasonME.Text) && !string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(DateTE.Text)  && DateTE.DateTime > DateTime.Now)
            {

                vistitDoctor.Reason = ReasonME.Text;
                vistitDoctor.Description = DescriptionME.Text;
                vistitDoctor.Patient =patient;
                vistitDoctor.Doctor = doctor;
                vistitDoctor.Date = DateTE.DateTime;
                if (!_DB.UpdateVisitDoctor(vistitDoctor))
                {
                    XtraMessageBox.Show("");
                }
                _vistiDoctor = _DB.GetVistiDoctorForPatient(patient);
                VisitDoctorGridControl.DataSource = _vistiDoctor;
                CleatData();
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void VisitDoctorGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            vistitDoctor = new VisitDoctor();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                vistitDoctor = (VisitDoctor)row;
                
                ReasonME.Text = vistitDoctor.Reason;
                DescriptionME.Text = vistitDoctor.Description;
                DateTE.DateTime = vistitDoctor.Date;


            }
            catch
            {

            }
        }
    }
}