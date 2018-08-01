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
using DevExpress.XtraEditors;

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class ReferralFormD : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<Referral> _referral;
        private Referral referral;
        private int patient;
        private int doctro;
        public ReferralFormD(DBCommunication.DBCommunicationAdmin _db,int doctorId,int patientID)
        {
            InitializeComponent();
            _DB = _db;
            patient = patientID;
            doctro = doctorId;
            _referral = _DB.GetReferralForPatient(patient);
            ReferralGridControl.DataSource = _referral;
        }

        private void NewBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(NameTE.Text)) { 

                referral = new Referral();
                referral.Name = NameTE.Text;
                referral.Description = DescriptionME.Text;
                referral.Doctor = doctro;
                 referral.Patient = patient;
                if (!_DB.InsertReferral(referral))
                {
                    XtraMessageBox.Show("Element is not added!");
                }
                ClearData();
                _referral = _DB.GetReferralForPatient(patient);
                ReferralGridControl.DataSource = _referral;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");

            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (referral != null && !string.IsNullOrWhiteSpace(DescriptionME.Text) && !string.IsNullOrWhiteSpace(NameTE.Text))
            {

                referral.Name = NameTE.Text;
                referral.Description = DescriptionME.Text;
                referral.Doctor = doctro;
                referral.Patient = patient;
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
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "You really want to delete the selected element?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (!_DB.DeleteReferral(referral))
                    {
                        XtraMessageBox.Show("Element is not deleted!");
                    }
                    ClearData();
                    _referral = _DB.GetReferralForPatient(patient);
                    ReferralGridControl.DataSource = _referral;
                }
            }
            else
            {
                XtraMessageBox.Show("Element is not selected!");
            }
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


            }
            catch
            {

            }
        }
        private void ClearData()
        {
            referral = new Referral();
            DescriptionME.Text = string.Empty;
            NameTE.Text = string.Empty;
            
        }
    }
}