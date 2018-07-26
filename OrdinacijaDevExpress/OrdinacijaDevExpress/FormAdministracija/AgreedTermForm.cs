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

namespace OrdinacijaDevExpress
{
    public partial class AgreedTermForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AgreedTerm agreedTerm;
        List<AgreedTerm> _agreedTerm;

        public Patient patient;
        List<Patient> _patient;

        public Doctor doctor;
        List<Doctor> _doctor;
       
        DBCommunication.DBCommunication _DB;
        public AgreedTermForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            agreedTerm = new AgreedTerm();
            _DB = _db;
            _agreedTerm = _DB.GetAgreedTerm();
            AgreedTermGridControl.DataSource = _agreedTerm;

            _patient = _DB.GetPatient();

            PatientLE.Properties.DataSource = _patient;
            PatientLE.Properties.DisplayMember = "Name";
            PatientLE.Properties.ValueMember = "ID";

            _doctor = _DB.GetDoctor();
            DoctorLE.Properties.DataSource = _doctor;
            DoctorLE.Properties.DisplayMember = "Name";
            DoctorLE.Properties.ValueMember = "ID";
        }

        private void AgreedTermForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgreedTermForm_Load(object sender, EventArgs e)
        {

        }

        private void NewAgreedTermBarItem_Click(object sender, EventArgs e)
        {
            DateTime date = DateCalendar.SelectionStart;
            if (date != null && PatientLE.EditValue != null && DoctorLE.EditValue!=null)
            {
                agreedTerm.Date = date;
                agreedTerm.Doctor = int.Parse(DoctorLE.EditValue.ToString());
                agreedTerm.Patient = int.Parse(PatientLE.EditValue.ToString());
            }
        }
    }
}