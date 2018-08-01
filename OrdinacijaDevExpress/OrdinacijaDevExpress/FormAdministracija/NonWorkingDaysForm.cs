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
    public partial class NonWorkingDaysForm  : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DBCommunication.DBCommunication _DB;
        private List<NonWorkingDays> _nonWorkingdays;
        private NonWorkingDays nonworkingdays;
        public NonWorkingDaysForm(DBCommunication.DBCommunicationAdmin _db)
        {
            InitializeComponent();
            _DB = _db;
            _nonWorkingdays = _DB.GetNonWorkingDays();
            NonWorkingDaysGridControl.DataSource = _nonWorkingdays;
        }

        private void NewBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(NamteTE.Text) && DateMC.SelectionStart!=null && DateMC.SelectionStart>DateTime.Now)
            {
                nonworkingdays = new NonWorkingDays();
                nonworkingdays.Date = DateMC.SelectionStart;
                nonworkingdays.Name = NamteTE.Text;
                if(!_DB.InsertNonWorkingDays(nonworkingdays))
                {
                    XtraMessageBox.Show("Element is not added!");
                }
                _nonWorkingdays = _DB.GetNonWorkingDays();
                NonWorkingDaysGridControl.DataSource = _nonWorkingdays;
                NamteTE.Text = string.Empty;
                DateMC.SelectionStart = DateTime.Now;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }

        private void NonWorkingDaysGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            nonworkingdays = new NonWorkingDays();
            try
            {
                GridView view = sender as GridView;
                object row = view.GetRow(e.RowHandle);
                nonworkingdays = (NonWorkingDays)row;
                NamteTE.Text = nonworkingdays.Name;
                DateMC.SelectionStart = nonworkingdays.Date;
            }
            catch
            {

            }
        }

        private void DeleteBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(nonworkingdays!=null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("You really want to delete the selected element?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!_DB.DeleteNonWorkingDays(nonworkingdays))
                    {
                        XtraMessageBox.Show("Element is not deleted!");
                    }
                    _nonWorkingdays = _DB.GetNonWorkingDays();
                    NonWorkingDaysGridControl.DataSource = _nonWorkingdays;
                    NamteTE.Text = string.Empty;
                    DateMC.SelectionStart = DateTime.Now;
                }
            }
            else
            {
                XtraMessageBox.Show("Element is not selected!");
            }
        }

        private void EditBarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(nonworkingdays!=null && !string.IsNullOrWhiteSpace(NamteTE.Text) && DateMC.SelectionStart!=null && DateMC.SelectionStart>DateTime.Now)
            {
                nonworkingdays.Name = NamteTE.Text;
                nonworkingdays.Date = DateMC.SelectionStart;
                if(!_DB.UpdateNonWokringDays(nonworkingdays))
                {
                    XtraMessageBox.Show("Element is not edited!");
                }
                _nonWorkingdays = _DB.GetNonWorkingDays();
                NonWorkingDaysGridControl.DataSource = _nonWorkingdays;
                NamteTE.Text = string.Empty;
                DateMC.SelectionStart = DateTime.Now;
            }
            else
            {
                XtraMessageBox.Show("All fields should be filled!");
            }
        }
    }
}