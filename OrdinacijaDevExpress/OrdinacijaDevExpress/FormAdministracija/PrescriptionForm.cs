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
    public partial class PrescriptionForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<Prescription> _prescription;
        private Prescription prescription;
        private List<Patient> _patient;
        private List<Doctor> _doctor;
        public PrescriptionForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            _DB = _db;
            _prescription = _DB.GetPrescription();
            PresciptionGridControl.DataSource = _prescription;

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

        private void NewBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(DescriptionME.Text) && DateTE.DateTime!=null && DateTE.DateTime>DateTime.Now && PatientLE.EditValue!=null && DoctorLE.EditValue!=null)
            {
                prescription = new Prescription();
                prescription.Date = DateTE.DateTime;
                prescription.Description = DescriptionME.Text;
                prescription.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                prescription.Patient = int.Parse(PatientLE.EditValue.ToString());
                if(!_DB.InsertPrescription(prescription))
                {
                    XtraMessageBox.Show("");
                }
                ClearData();
                _prescription = _DB.GetPrescription();
                PresciptionGridControl.DataSource = _prescription;
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (prescription!=null && !string.IsNullOrWhiteSpace(DescriptionME.Text) && DateTE.DateTime != null && DateTE.DateTime > DateTime.Now && PatientLE.EditValue != null && DoctorLE.EditValue != null)
            {
                
                prescription.Date = DateTE.DateTime;
                prescription.Description = DescriptionME.Text;
                prescription.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                prescription.Patient = int.Parse(PatientLE.EditValue.ToString());
                if (!_DB.UpdatePrescription(prescription))
                {
                    XtraMessageBox.Show("");
                }
                _prescription = _DB.GetPrescription();
                PresciptionGridControl.DataSource = _prescription;
                ClearData();
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void DeleteBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (prescription != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (!_DB.DeletePrescription(prescription))
                    {
                        XtraMessageBox.Show("");
                    }
                    _prescription = _DB.GetPrescription();
                    PresciptionGridControl.DataSource = _prescription;
                    ClearData();
                }
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }
        private void ClearData()
        {
            prescription = new Prescription();   
            DescriptionME.Text = string.Empty;
            DateTE.DateTime = DateTime.Now;
            PatientLE.EditValue = null;
            DoctorLE.EditValue = null;
        }

        private void PresciptionGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            prescription = new Prescription();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                prescription = (Prescription)row;
                
                DescriptionME.Text = prescription.Description;
                DateTE.DateTime = prescription.Date;


            }
            catch
            {

            }
        }

        private void PresciptionGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "PresciptionPatient")
            {
                foreach (Patient p in _patient)
                {
                    if (e.Value.ToString() == p.ID.ToString())
                    {
                        e.DisplayText = p.Name + " " + p.Surname;
                    }
                }
            }
            if (e.Column.Name == "PresciptionDoctor")
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