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
    public partial class WorkingDaysForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<Working_time> _working_time;
        private Working_time working_time;
        public WorkingDaysForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            _DB = _db;
            _working_time = _DB.GetWorkingTime();
            WorkingTimeGridControl.DataSource = _working_time;
        }

        private void WorkingDaysForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void NewBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Odd_EvenCB.SelectedIndex>0 && Morning_AfternoonCB.SelectedIndex>0)
            {
                string oddeven = (Odd_EvenCB.SelectedIndex == 1) ? "Neparni" : "Parni";
                string morningafternoon = (Morning_AfternoonCB.SelectedIndex == 1) ? "Jutro" : "Posljepodne";
                working_time = new Working_time();
                working_time.Odd_Even = oddeven;
                working_time.Morning_Afternoon = morningafternoon;
                if(!_DB.InsertWorkingDay(working_time))
                {
                    XtraMessageBox.Show("Element is not added!");
                }
                _working_time = _DB.GetWorkingTime();
                WorkingTimeGridControl.DataSource = _working_time;
                Odd_EvenCB.SelectedIndex = 0;
                Morning_AfternoonCB.SelectedIndex = 0;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void WorkingTimeGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            working_time = new Working_time();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                working_time = (Working_time)row;
                Odd_EvenCB.SelectedIndex = (working_time.Odd_Even == "Parni") ? 2 : 1;
                Morning_AfternoonCB.SelectedIndex = (working_time.Morning_Afternoon == "Jutro") ? 1 : 2;
               
            }
            catch 
            {
               
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(working_time!=null)
            {

                string oddeven = (Odd_EvenCB.SelectedIndex == 1) ? "Neparni" : "Parni";
                string morningafternoon = (Morning_AfternoonCB.SelectedIndex == 1) ? "Jutro" : "Posljepodne";
               
                working_time.Odd_Even = oddeven;
                working_time.Morning_Afternoon = morningafternoon;
                if (!_DB.UpdateWorkingDays(working_time))
                {
                    XtraMessageBox.Show("Element is not edited!");
                }
                _working_time = _DB.GetWorkingTime();
                WorkingTimeGridControl.DataSource = _working_time;
                Odd_EvenCB.SelectedIndex = 0;
                Morning_AfternoonCB.SelectedIndex = 0;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void DeleteBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(working_time!=null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Sure", "You really want to delete the selected element?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    {
                        if (!_DB.DeleteWorkingDay(working_time))
                        {
                            XtraMessageBox.Show("Element is not deleted!");
                        }
                        _working_time = _DB.GetWorkingTime();
                        WorkingTimeGridControl.DataSource = _working_time;
                        Odd_EvenCB.SelectedIndex = 0;
                        Morning_AfternoonCB.SelectedIndex = 0;
                    }
            }
            else
            {
                XtraMessageBox.Show("Element is not selected!");
            }
        }
    }
}