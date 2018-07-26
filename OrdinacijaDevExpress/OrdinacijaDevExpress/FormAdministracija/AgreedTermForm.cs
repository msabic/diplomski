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

        List<Term> _termAM;
        List<Term> _termPM;

        public Working_time workingTime;
        List<Working_time> _workingTime;

        public bool parni = false, neparni = false, jutro = false;
        DBCommunication.DBCommunication _DB;
        public AgreedTermForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            HideShowElement(false);
            _termAM = new List<Term>();
            _termAM.Add(new Term { Time = "08:00" }); _termAM.Add(new Term { Time = "08:15" }); _termAM.Add(new Term { Time = "08:30" }); _termAM.Add(new Term { Time = "08:45" });
            _termAM.Add(new Term { Time = "09:00" }); _termAM.Add(new Term { Time = "09:15" }); _termAM.Add(new Term { Time = "09:30" }); _termAM.Add(new Term { Time = "09:45" });
            _termAM.Add(new Term { Time = "10:00" }); _termAM.Add(new Term { Time = "10:15" }); _termAM.Add(new Term { Time = "10:30" }); _termAM.Add(new Term { Time = "10:45" });
            _termAM.Add(new Term { Time = "11:00" }); _termAM.Add(new Term { Time = "11:15" }); _termAM.Add(new Term { Time = "11:30" }); _termAM.Add(new Term { Time = "11:45" });
            _termAM.Add(new Term { Time = "12:00" }); _termAM.Add(new Term { Time = "12:15" }); _termAM.Add(new Term { Time = "12:30" }); _termAM.Add(new Term { Time = "12:45" });
            _termAM.Add(new Term { Time = "13:00" }); _termAM.Add(new Term { Time = "13:15" }); _termAM.Add(new Term { Time = "13:30" }); _termAM.Add(new Term { Time = "13:45" });

            _termPM = new List<Term>();
            _termPM.Add(new Term { Time = "14:00" }); _termPM.Add(new Term { Time = "14:15" }); _termPM.Add(new Term { Time = "14:30" }); _termPM.Add(new Term { Time = "14:45" });
            _termPM.Add(new Term { Time = "15:00" }); _termPM.Add(new Term { Time = "15:15" }); _termPM.Add(new Term { Time = "15:30" }); _termPM.Add(new Term { Time = "15:45" });
            _termPM.Add(new Term { Time = "16:00" }); _termPM.Add(new Term { Time = "16:15" }); _termPM.Add(new Term { Time = "16:30" }); _termPM.Add(new Term { Time = "16:45" });
            _termPM.Add(new Term { Time = "17:00" }); _termPM.Add(new Term { Time = "17:15" }); _termPM.Add(new Term { Time = "17:30" }); _termPM.Add(new Term { Time = "17:45" });
            _termPM.Add(new Term { Time = "18:00" }); _termPM.Add(new Term { Time = "18:15" }); _termPM.Add(new Term { Time = "18:30" }); _termPM.Add(new Term { Time = "18:45" });
            _termPM.Add(new Term { Time = "19:00" }); _termPM.Add(new Term { Time = "19:15" }); _termPM.Add(new Term { Time = "19:30" }); _termPM.Add(new Term { Time = "19:45" });


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
        private void HideShowElement(bool value)
        {
            DateCalendar.Visible = value;
            PatientLE.Visible = value;
            FreeTermLE.Visible = value;
            label1.Visible = value;
            label2.Visible = value;
            label3.Visible = value;
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

        private void DoctorLE_EditValueChanged(object sender, EventArgs e)
        {
            if (DoctorLE.EditValue != null)
            {
                foreach(Doctor dr in _doctor)
                {
                    if (dr.ID == int.Parse(DoctorLE.EditValue.ToString()))
                    {
                        doctor = dr;
                        _workingTime = _DB.GetWorkingTime();
                        foreach(Working_time wt in _workingTime)
                        {
                            if(wt.ID==dr.Working_time)
                            {
                                workingTime = wt;
                                WortTimeAM_PM();
                            }
                        }

                    }
                }
                HideShowElement(true);
            }
            else
            {
                HideShowElement(false);
            }
        }
        private void WortTimeAM_PM()
        {
            if (workingTime.Odd_Even == "Parni" && workingTime.Morning_Afternoon == "Jutro")
            {
                parni = true; neparni = false;
            }
            if (workingTime.Odd_Even == "Neparni" && workingTime.Morning_Afternoon == "Jutro")
            {
                parni = true; neparni = false;
            }
            if (workingTime.Odd_Even == "Parni" && workingTime.Morning_Afternoon == "Posljepodne")
            {
                parni = true; neparni = false;
            }
            if (workingTime.Odd_Even == "Neparni" && workingTime.Morning_Afternoon == "Posljepodne")
            {
                parni = true; neparni = false;
            }
        }
        private void DateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = DateCalendar.SelectionStart;
            if(date.Day%2==0)
            {
               if(parni)
                {
                    jutro = true;
                }
                else
                {
                    jutro = false;
                }
            }
            else
            {
                if(neparni)
                {
                    jutro = true;
                }
                else
                {
                    jutro = false;
                }
            }

            if(!jutro)
            {
                FreeTermLE.Properties.DataSource = _termAM;
            }
            else
            {
                FreeTermLE.Properties.DataSource = _termPM;
            }
        }
    }

    public class Term
    {
        public string Time { get; set; }
    }
}