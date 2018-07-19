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
    public partial class PatientInfoForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<PatientInfo> _patientInfo;
        private PatientInfo patientInfo;
        public PatientInfoForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            _DB = _db;
            _patientInfo = _DB.GetPatientInfo();
            PatientInfoGridControl.DataSource = _patientInfo;
        }

        private void NewBarItem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(FatherNameTE.Text) && !string.IsNullOrWhiteSpace(MotherNameTE.Text) &&
                !string.IsNullOrWhiteSpace(AddressTE.Text) && !string.IsNullOrWhiteSpace(PhoneTE.Text) && 
                !string.IsNullOrWhiteSpace(MobileTE.Text) && !string.IsNullOrWhiteSpace(UCIDTE.Text) )
            {
                patientInfo = new PatientInfo();
                patientInfo.Father_name = FatherNameTE.Text;
                patientInfo.Mother_name = MotherNameTE.Text;
                patientInfo.Address = AddressTE.Text;
                patientInfo.Phone = PhoneTE.Text;
                patientInfo.Mobile = MobileTE.Text;
                patientInfo.UCID = UCIDTE.Text;
                patientInfo.Relationship_status = RelationshipStatusCB.Checked;
                patientInfo.Smoker = SmokerCE.Checked;
                if (!_DB.InsertPatientInfo(patientInfo)) 
                {
                    XtraMessageBox.Show("");
                }
                _patientInfo = _DB.GetPatientInfo();
                PatientInfoGridControl.DataSource = _patientInfo;
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void EditBarItem_Click(object sender, EventArgs e)
        {
            if (patientInfo!=null && !string.IsNullOrWhiteSpace(FatherNameTE.Text) && !string.IsNullOrWhiteSpace(MotherNameTE.Text) &&
               !string.IsNullOrWhiteSpace(AddressTE.Text) && !string.IsNullOrWhiteSpace(PhoneTE.Text) &&
               !string.IsNullOrWhiteSpace(MobileTE.Text) && !string.IsNullOrWhiteSpace(UCIDTE.Text))
            {
                
                patientInfo.Father_name = FatherNameTE.Text;
                patientInfo.Mother_name = MotherNameTE.Text;
                patientInfo.Address = AddressTE.Text;
                patientInfo.Phone = PhoneTE.Text;
                patientInfo.Mobile = MobileTE.Text;
                patientInfo.UCID = UCIDTE.Text;
                patientInfo.Relationship_status = RelationshipStatusCB.Checked;
                patientInfo.Smoker = SmokerCE.Checked;
                if (!_DB.UpdatePatientInfo(patientInfo)) 
                {
                    XtraMessageBox.Show("");
                }
                _patientInfo = _DB.GetPatientInfo();
                PatientInfoGridControl.DataSource = _patientInfo;
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void DeleteBarItem_Click(object sender, EventArgs e)
        {
            if (patientInfo!=null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!_DB.DeletePatientInfo(patientInfo))
                    {
                        XtraMessageBox.Show("");
                    }
                    _patientInfo = _DB.GetPatientInfo();
                    PatientInfoGridControl.DataSource = _patientInfo;
                }
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void PatientInfoGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            patientInfo = new PatientInfo();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                patientInfo = (PatientInfo)row;

                FatherNameTE.Text=patientInfo.Father_name;
                MotherNameTE.Text=patientInfo.Mother_name;
                AddressTE.Text=patientInfo.Address;
                PhoneTE.Text=patientInfo.Phone;
                MobileTE.Text=patientInfo.Mobile;
                UCIDTE.Text=patientInfo.UCID;
                RelationshipStatusCB.Checked=patientInfo.Relationship_status;
                SmokerCE.Checked=patientInfo.Smoker;
            }
            catch
            {

            }
        }
    }
}