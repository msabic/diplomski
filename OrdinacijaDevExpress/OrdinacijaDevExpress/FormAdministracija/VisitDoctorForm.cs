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
    public partial class VisitDoctorForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<VisitDoctor> _visitDoctor;
        private VisitDoctor visitDoctor;
        private List<Doctor> _doctor;
        private List<Patient> _patient;
        public VisitDoctorForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            _DB = _db;
            _visitDoctor = _DB.GetVisitDoctor();
            VisitDoctorGridControl.DataSource = _visitDoctor;

            _doctor = _DB.GetDoctor();
            DoctorLE.Properties.DataSource = _doctor;

            _patient = _DB.GetPatient();
            PatientLE.Properties.DataSource = _patient;

            DoctorLE.Properties.DisplayMember = "Surname";
            DoctorLE.Properties.ValueMember = "ID";

            PatientLE.Properties.DisplayMember = "Surname";
            PatientLE.Properties.ValueMember = "ID";

            DateTE.DateTime = DateTime.Now;
        }

        private void NewVisitDoctorBarItem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(ReasonME.Text) && !string.IsNullOrWhiteSpace(DescriptionME.Text) && DateTE.DateTime!=null && DateTE.DateTime>DateTime.Now && PatientLE.EditValue!=null && DoctorLE.EditValue!=null)
            {
                visitDoctor = new VisitDoctor();
                visitDoctor.Reason = ReasonME.Text;
                visitDoctor.Description = DescriptionME.Text;
                visitDoctor.Patient = int.Parse(PatientLE.EditValue.ToString());
                visitDoctor.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                visitDoctor.Date = DateTE.DateTime;
                if(!_DB.InsertVisitDoctor(visitDoctor))
                {
                    XtraMessageBox.Show("");
                }
                _visitDoctor = _DB.GetVisitDoctor();
                VisitDoctorGridControl.DataSource = _visitDoctor;
                ClearData();
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }
        private void ClearData()
        {
            ReasonME.Text = string.Empty;
            DescriptionME.Text = string.Empty;
            DateTE.DateTime = DateTime.Now;
            PatientLE.EditValue = null;
            DoctorLE.EditValue = null;
        }
        private void DeleteVisitDoctorBarItem_Click(object sender, EventArgs e)
        {
            if(visitDoctor!=null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!_DB.DeleteVisitDoctor(visitDoctor))
                    {

                        XtraMessageBox.Show("");

                    }
                    _visitDoctor = _DB.GetVisitDoctor();
                    VisitDoctorGridControl.DataSource = _visitDoctor;
                    ClearData();
                }
            }
        }

        private void VisitDoctorGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            visitDoctor = new VisitDoctor();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                visitDoctor = (VisitDoctor)row;
                ReasonME.Text = visitDoctor.Reason;
                DescriptionME.Text = visitDoctor.Description;
                DateTE.DateTime = visitDoctor.Date;
               

            }
            catch
            {

            }
        }

        private void EditVisitDoctorBarItem_Click(object sender, EventArgs e)
        {
            if (visitDoctor!=null && !string.IsNullOrWhiteSpace(ReasonME.Text) && !string.IsNullOrWhiteSpace(DescriptionME.Text) && DateTE.DateTime != null && DateTE.DateTime > DateTime.Now && PatientLE.EditValue != null && DoctorLE.EditValue != null)
            {
                
                visitDoctor.Reason = ReasonME.Text;
                visitDoctor.Description = DescriptionME.Text;
                visitDoctor.Patient = int.Parse(PatientLE.EditValue.ToString());
                visitDoctor.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                visitDoctor.Date = DateTE.DateTime;
                if (!_DB.UpdateVisitDoctor(visitDoctor))
                {
                    XtraMessageBox.Show("");
                }
                _visitDoctor = _DB.GetVisitDoctor();
                VisitDoctorGridControl.DataSource = _visitDoctor;
                ClearData();
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void VisitDoctorGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "VisitDoctorPatient")
            {
                foreach (Patient p in _patient)
                {
                    if (e.Value.ToString() == p.ID.ToString())
                    {
                        e.DisplayText = p.Name + " " + p.Surname;
                    }
                }
            }
            if (e.Column.Name == "VisitDoctorDoctor")
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