using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrdinacijaDevExpress
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DBCommunication.DBCommunicationAdmin _DB = new DBCommunication.DBCommunicationAdmin();
        public MainForm()
        {
            InitializeComponent();
           
            DoctorForm _doctor_form = new DoctorForm(_DB);
            OpenForm(_doctor_form);
            SkinHelper.InitSkinPopupMenu(StyleContainerItem);
        }
        private void OpenForm(Form _frm)
        {
            this.IsMdiContainer = true;
            
            _frm.MdiParent = this;
            
            _frm.Show();
            
        }
        private void ribbonControl1_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
        {
           if(e.Page.Name== "DoctorPage")
            {
                DoctorForm _doctor_form = new DoctorForm(_DB);
                OpenForm(_doctor_form);
            }
           if(e.Page.Name== "PatientPage")
            {
                PatientForm _patient_form = new PatientForm(_DB);
                OpenForm(_patient_form);
            }
           if(e.Page.Name=="WorkingDaysPage")
            {
                using (WorkingDaysForm _workingdays_form = new WorkingDaysForm(_DB))
                {
                    _workingdays_form.StartPosition = FormStartPosition.CenterScreen;
                    _workingdays_form.ShowDialog();

                }
            }
           if(e.Page.Name== "non_working_days_page")
            {
                using (NonWorkingDaysForm _nonworkingdays_form = new NonWorkingDaysForm(_DB))
                {
                    _nonworkingdays_form.StartPosition = FormStartPosition.CenterScreen;
                    _nonworkingdays_form.ShowDialog();

                }
            }
           if(e.Page.Name== "VisitDoctorPage")
            {
                VisitDoctorForm _visitDoctorForm = new VisitDoctorForm(_DB);
                OpenForm(_visitDoctorForm);
            }
            
            if (e.Page.Name == "PrescriptionPage")
            {
                using (PrescriptionForm _prescriptionForm = new PrescriptionForm(_DB))
                {
                    _prescriptionForm.StartPosition = FormStartPosition.CenterScreen;
                    _prescriptionForm.ShowDialog();
                }
                   
            }
            if(e.Page.Name=="ReferralPage")
            {
                using (ReferralFormcs _referral_form = new ReferralFormcs(_DB))
                {
                    _referral_form.StartPosition = FormStartPosition.CenterScreen;
                    _referral_form.ShowDialog();
                }
            }
            if(e.Page.Name=="PatientInfoPage")
            {
                PatientInfoForm _patientInfoForm = new PatientInfoForm(_DB);
                OpenForm(_patientInfoForm);
            }
            if(e.Page.Name=="DiagnosisPage")
            {
                using (DiagnosisForm _diagnosisForm = new DiagnosisForm(_DB))
                {
                    _diagnosisForm.StartPosition = FormStartPosition.CenterScreen;
                    _diagnosisForm.ShowDialog();
                }
                
            }
            if (e.Page.Name == "AgreedTermPage")
            {
                AgreedTermForm _agreedTermForm = new AgreedTermForm(_DB);
                OpenForm(_agreedTermForm);
            }
        }
        

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
