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

namespace OrdinacijaDevExpress.FormDoctor
{
    public partial class AgreedTermForPatientFormD : DevExpress.XtraEditors.XtraForm
    {
        private List<AgreedTerm> _agreedTerm;
        private int patient;
        DBCommunication.DBCommunication _DB;
        public AgreedTermForPatientFormD(DBCommunication.DBCommunicationAdmin _db, int patientID)
        {
            InitializeComponent();
            _DB = _db;
            patient = patientID;
            _agreedTerm = _DB.GetAgreedTermForPatient(patient);
            AgreedTermGridControl.DataSource = _agreedTerm;
        }
    }
}