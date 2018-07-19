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
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Models.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Helpers;

namespace OrdinacijaDevExpress
{
    public partial class DoctorForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Doctor doctor;
        List<Doctor> _doctor;
        List<Working_time> _working_time;
        DBCommunication.DBCommunication _DB;
       public DoctorForm(DBCommunication.DBCommunicationAdmin _db)
        { 
            InitializeComponent();
            _DB = _db;
            _doctor =_DB.GetDoctor();
            DoctorGridControl.DataSource = _doctor;
            _working_time = _DB.GetWorkingTime();
            WorkingTimeLE.Properties.DataSource = _working_time;
            WorkingTimeLE.Properties.DisplayMember = "Odd_Even";
            WorkingTimeLE.Properties.ValueMember = "ID";
           
        }

        private void DoctorForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearData()
        {
            NameTE.Text = string.Empty;
            SurnameTE.Text = string.Empty;
            EmailTE.Text = string.Empty;
            ContactTE.Text = string.Empty;
            WorkingTimeLE.EditValue = null;
        }
        private void NewDoctorBarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTE.Text) && !string.IsNullOrWhiteSpace(SurnameTE.Text) && !string.IsNullOrWhiteSpace(EmailTE.Text) && !string.IsNullOrWhiteSpace(ContactTE.Text) && WorkingTimeLE.EditValue != null)
            {
                doctor = new Doctor();
                doctor.Name = NameTE.Text;
                doctor.Surname = SurnameTE.Text;
                doctor.Email = EmailTE.Text;
                doctor.Contact = ContactTE.Text;
                doctor.Working_time = int.Parse(WorkingTimeLE.EditValue.ToString());
                if (!_DB.InsertDoctor(doctor))
                {
                    XtraMessageBox.Show("");
                }
                _doctor = _DB.GetDoctor();
                DoctorGridControl.DataSource = _doctor;
                ClearData();
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void DoctorGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            doctor = new Doctor();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                doctor = (Doctor)row;
                NameTE.Text = doctor.Name;
                SurnameTE.Text = doctor.Surname;
                EmailTE.Text = doctor.Email;
                ContactTE.Text = doctor.Contact;
               
            }
            catch
            {
               
            }

        }

        private void EditDoctorBarItem_Click(object sender, EventArgs e)
        {
            if(doctor!=null && !string.IsNullOrWhiteSpace(NameTE.Text) && !string.IsNullOrWhiteSpace(SurnameTE.Text) && !string.IsNullOrWhiteSpace(EmailTE.Text) && !string.IsNullOrWhiteSpace(ContactTE.Text) && WorkingTimeLE.EditValue!=null)
            {
                doctor.Name = NameTE.Text;
                doctor.Surname = SurnameTE.Text;
                doctor.Email = EmailTE.Text;
                doctor.Contact = ContactTE.Text;
                doctor.Working_time = int.Parse(WorkingTimeLE.EditValue.ToString());
                if(!_DB.UpdateDoctor(doctor))
                {
                    XtraMessageBox.Show("Doctor is't edited!");
                }
                ClearData();
                _doctor = _DB.GetDoctor();
                DoctorGridControl.DataSource = _doctor;
            }
            else
            {
                XtraMessageBox.Show("");
            }
        }

        private void DeleteDoctorBarItem_Click(object sender, EventArgs e)
        {

            if(doctor!=null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!_DB.DeleteDoctor(doctor))
                    {
                        XtraMessageBox.Show("");
                    }
                    _doctor = _DB.GetDoctor();
                    DoctorGridControl.DataSource = _doctor;
                }
                
               
            }
            else
            {
                XtraMessageBox.Show("");
            }

        }

        private void DoctorGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "DoctorWorkingTime")
            {
                foreach (Working_time wtime in _working_time)
                {
                    if (e.Value.ToString() == wtime.ID.ToString())
                    {
                        e.DisplayText = wtime.Odd_Even + " " + wtime.Morning_Afternoon;
                    }
                }
            }
        }
    }
}