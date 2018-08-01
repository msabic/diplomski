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
            if(!string.IsNullOrWhiteSpace(DescriptionME.Text) && DateTE.DateTime!=null && DateTE.DateTime>DateTime.Now && PatientLE.EditValue!=null && DoctorLE.EditValue!=null && !string.IsNullOrWhiteSpace(NameTE.Text))
            {
                prescription = new Prescription();
                prescription.Date = DateTE.DateTime;
                prescription.Description = DescriptionME.Text;
                prescription.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                prescription.Patient = int.Parse(PatientLE.EditValue.ToString());
                prescription.Name = NameTE.Text;
                if (!_DB.InsertPrescription(prescription))
                {
                    XtraMessageBox.Show("Element is not added!");
                }
                ClearData();
                _prescription = _DB.GetPrescription();
                PresciptionGridControl.DataSource = _prescription;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (prescription!=null && !string.IsNullOrWhiteSpace(DescriptionME.Text) && DateTE.DateTime != null && DateTE.DateTime > DateTime.Now && PatientLE.EditValue != null && DoctorLE.EditValue != null && !string.IsNullOrWhiteSpace(NameTE.Text))
            {
                
                prescription.Date = DateTE.DateTime;
                prescription.Description = DescriptionME.Text;
                prescription.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                prescription.Patient = int.Parse(PatientLE.EditValue.ToString());
                prescription.Name = NameTE.Text;
                if (!_DB.UpdatePrescription(prescription))
                {
                    XtraMessageBox.Show("Element is not edited!");
                }
                _prescription = _DB.GetPrescription();
                PresciptionGridControl.DataSource = _prescription;
                ClearData();
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void DeleteBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (prescription != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("You really want to delete the selected element?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (!_DB.DeletePrescription(prescription))
                    {
                        XtraMessageBox.Show("Element is not deleted!");
                    }
                    _prescription = _DB.GetPrescription();
                    PresciptionGridControl.DataSource = _prescription;
                    ClearData();
                }
            }
            else
            {
                XtraMessageBox.Show("Element is not selected!");
            }
        }
        private void ClearData()
        {
            prescription = new Prescription();   
            DescriptionME.Text = string.Empty;
            DateTE.DateTime = DateTime.Now;
            PatientLE.EditValue = null;
            DoctorLE.EditValue = null;
            NameTE.Text=string.Empty;
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
                NameTE.Text = prescription.Name;

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