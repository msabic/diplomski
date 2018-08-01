using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models.Model;

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class PatientInfoForm : DevExpress.XtraEditors.XtraForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<PatientInfo> _patientInfo;
        private PatientInfo patientInfo;
        public PatientInfoForm(DBCommunication.DBCommunicationAdmin _db,int patientID)
        {
            InitializeComponent();
            _DB = _db;
            _patientInfo = _DB.GetPatientInfoID(patientID);
            //PatientInfoGridControl.DataSource = _patientInfo;
            if(_patientInfo.Count>0)
            {
                patientInfo = (PatientInfo)_patientInfo[0];
                Father_nameLBL.Text = patientInfo.Father_name;
                Mother_nameLBL.Text = patientInfo.Mother_name;
                AddressLBL.Text = patientInfo.Address;
                PhoneLBL.Text = patientInfo.Phone;
                MobileLBL.Text = patientInfo.Mobile;
                UCIDLBL.Text = patientInfo.UCID;
                RelationShipCB.Checked = patientInfo.Relationship_status;
                SmokreCB.Checked = patientInfo.Smoker;
            }
            else
            {
                XtraMessageBox.Show("No information!");
            }
        }
    }
}