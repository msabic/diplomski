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
    public partial class MainFormDoctor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DBCommunication.DBCommunicationAdmin _DB = new DBCommunication.DBCommunicationAdmin();
        private List<Patient> _patien;
        public MainFormDoctor()
        {
            InitializeComponent();
            _patien = _DB.GetPatient();
            PatientGridControl.DataSource = _patien;
        }
    }
}