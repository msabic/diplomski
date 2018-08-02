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
    public partial class AgreedTermAllFormD : DevExpress.XtraEditors.XtraForm
    {
        private List<AgreedTerm> _agreedTerm;
        private List<Patient> _patient;
        private int doctor;
        DBCommunication.DBCommunication _DB;
        public AgreedTermAllFormD(DBCommunication.DBCommunicationAdmin _db, int doctorID)
        {
            InitializeComponent();
            _DB = _db;
            doctor = doctorID;
            _patient = _DB.GetPatient();
            _agreedTerm = _DB.AgreedTemForDoctor(doctor);
            AgreedTermGridControl.DataSource = _agreedTerm;
        }

        private void AgreedTermGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.Name == "AgreedTermPatient")
            {
                foreach (Patient p in _patient)
                {
                    if (e.Value != null)
                    {
                        if (e.Value.ToString() == p.ID.ToString())
                        {
                            e.DisplayText = p.Name + " " + p.Surname;
                        }
                    }
                }
            }
           
        }

        private void AgreedTermGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}