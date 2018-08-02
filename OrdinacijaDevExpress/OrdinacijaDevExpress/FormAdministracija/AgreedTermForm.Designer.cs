namespace OrdinacijaDevExpress
{
    partial class AgreedTermForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgreedTermForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DeleteAgreedTermBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.EditAgreedTermBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.NewAgreedTermBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.DateCalendar = new System.Windows.Forms.MonthCalendar();
            this.FreeTermLE = new DevExpress.XtraEditors.LookUpEdit();
            this.PatientLE = new DevExpress.XtraEditors.LookUpEdit();
            this.AgreedTermGridControl = new DevExpress.XtraGrid.GridControl();
            this.AgreedTermGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AgreedTermID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DoctorLE = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeTermLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.DeleteAgreedTermBarItem);
            this.groupControl1.Controls.Add(this.EditAgreedTermBarItem);
            this.groupControl1.Controls.Add(this.NewAgreedTermBarItem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(986, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Action";
            // 
            // DeleteAgreedTermBarItem
            // 
            this.DeleteAgreedTermBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteAgreedTermBarItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAgreedTermBarItem.Image")));
            this.DeleteAgreedTermBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteAgreedTermBarItem.Location = new System.Drawing.Point(104, 20);
            this.DeleteAgreedTermBarItem.Name = "DeleteAgreedTermBarItem";
            this.DeleteAgreedTermBarItem.Size = new System.Drawing.Size(51, 78);
            this.DeleteAgreedTermBarItem.TabIndex = 6;
            this.DeleteAgreedTermBarItem.Text = "Delete";
            this.DeleteAgreedTermBarItem.Click += new System.EventHandler(this.DeleteAgreedTermBarItem_Click);
            // 
            // EditAgreedTermBarItem
            // 
            this.EditAgreedTermBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditAgreedTermBarItem.Image = ((System.Drawing.Image)(resources.GetObject("EditAgreedTermBarItem.Image")));
            this.EditAgreedTermBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.EditAgreedTermBarItem.Location = new System.Drawing.Point(53, 20);
            this.EditAgreedTermBarItem.Name = "EditAgreedTermBarItem";
            this.EditAgreedTermBarItem.Size = new System.Drawing.Size(51, 78);
            this.EditAgreedTermBarItem.TabIndex = 5;
            this.EditAgreedTermBarItem.Text = "Edit";
            this.EditAgreedTermBarItem.Click += new System.EventHandler(this.EditAgreedTermBarItem_Click);
            // 
            // NewAgreedTermBarItem
            // 
            this.NewAgreedTermBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewAgreedTermBarItem.Image = ((System.Drawing.Image)(resources.GetObject("NewAgreedTermBarItem.Image")));
            this.NewAgreedTermBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewAgreedTermBarItem.Location = new System.Drawing.Point(2, 20);
            this.NewAgreedTermBarItem.Name = "NewAgreedTermBarItem";
            this.NewAgreedTermBarItem.Size = new System.Drawing.Size(51, 78);
            this.NewAgreedTermBarItem.TabIndex = 4;
            this.NewAgreedTermBarItem.Text = "New";
            this.NewAgreedTermBarItem.Click += new System.EventHandler(this.NewAgreedTermBarItem_Click);
            // 
            // DateCalendar
            // 
            this.DateCalendar.Location = new System.Drawing.Point(52, 216);
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.TabIndex = 1;
            this.DateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateCalendar_DateSelected);
            // 
            // FreeTermLE
            // 
            this.FreeTermLE.Location = new System.Drawing.Point(52, 423);
            this.FreeTermLE.Name = "FreeTermLE";
            this.FreeTermLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FreeTermLE.Properties.DisplayMember = "Time";
            this.FreeTermLE.Properties.ValueMember = "Time";
            this.FreeTermLE.Size = new System.Drawing.Size(199, 20);
            this.FreeTermLE.TabIndex = 2;
            // 
            // PatientLE
            // 
            this.PatientLE.Location = new System.Drawing.Point(52, 483);
            this.PatientLE.Name = "PatientLE";
            this.PatientLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PatientLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname")});
            this.PatientLE.Size = new System.Drawing.Size(198, 20);
            this.PatientLE.TabIndex = 3;
            // 
            // AgreedTermGridControl
            // 
            this.AgreedTermGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgreedTermGridControl.Location = new System.Drawing.Point(324, 100);
            this.AgreedTermGridControl.MainView = this.AgreedTermGridView;
            this.AgreedTermGridControl.Name = "AgreedTermGridControl";
            this.AgreedTermGridControl.Size = new System.Drawing.Size(662, 488);
            this.AgreedTermGridControl.TabIndex = 4;
            this.AgreedTermGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.AgreedTermGridView});
            // 
            // AgreedTermGridView
            // 
            this.AgreedTermGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AgreedTermID,
            this.AgreedTermDate,
            this.AgreedTermTime,
            this.AgreedTermPatient,
            this.AgreedTermDoctor});
            this.AgreedTermGridView.GridControl = this.AgreedTermGridControl;
            this.AgreedTermGridView.Name = "AgreedTermGridView";
            this.AgreedTermGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.AgreedTermGridView_RowClick);
            this.AgreedTermGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.AgreedTermGridView_CustomColumnDisplayText);
            // 
            // AgreedTermID
            // 
            this.AgreedTermID.Caption = "ID";
            this.AgreedTermID.FieldName = "ID";
            this.AgreedTermID.Name = "AgreedTermID";
            this.AgreedTermID.OptionsColumn.AllowEdit = false;
            // 
            // AgreedTermDate
            // 
            this.AgreedTermDate.Caption = "Date";
            this.AgreedTermDate.FieldName = "Date";
            this.AgreedTermDate.Name = "AgreedTermDate";
            this.AgreedTermDate.OptionsColumn.AllowEdit = false;
            this.AgreedTermDate.Visible = true;
            this.AgreedTermDate.VisibleIndex = 0;
            // 
            // AgreedTermTime
            // 
            this.AgreedTermTime.Caption = "Time";
            this.AgreedTermTime.FieldName = "Time";
            this.AgreedTermTime.Name = "AgreedTermTime";
            this.AgreedTermTime.OptionsColumn.AllowEdit = false;
            this.AgreedTermTime.Visible = true;
            this.AgreedTermTime.VisibleIndex = 1;
            // 
            // AgreedTermPatient
            // 
            this.AgreedTermPatient.Caption = "Patient";
            this.AgreedTermPatient.FieldName = "Patient";
            this.AgreedTermPatient.Name = "AgreedTermPatient";
            this.AgreedTermPatient.OptionsColumn.AllowEdit = false;
            this.AgreedTermPatient.Visible = true;
            this.AgreedTermPatient.VisibleIndex = 2;
            // 
            // AgreedTermDoctor
            // 
            this.AgreedTermDoctor.Caption = "Doctor";
            this.AgreedTermDoctor.FieldName = "Doctor";
            this.AgreedTermDoctor.Name = "AgreedTermDoctor";
            this.AgreedTermDoctor.OptionsColumn.AllowEdit = false;
            this.AgreedTermDoctor.Visible = true;
            this.AgreedTermDoctor.VisibleIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Free term";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doctor";
            // 
            // DoctorLE
            // 
            this.DoctorLE.Location = new System.Drawing.Point(52, 163);
            this.DoctorLE.Name = "DoctorLE";
            this.DoctorLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DoctorLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname")});
            this.DoctorLE.Size = new System.Drawing.Size(198, 20);
            this.DoctorLE.TabIndex = 9;
            this.DoctorLE.EditValueChanged += new System.EventHandler(this.DoctorLE_EditValueChanged);
            // 
            // AgreedTermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 590);
            this.Controls.Add(this.DoctorLE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgreedTermGridControl);
            this.Controls.Add(this.PatientLE);
            this.Controls.Add(this.FreeTermLE);
            this.Controls.Add(this.DateCalendar);
            this.Controls.Add(this.groupControl1);
            this.Name = "AgreedTermForm";
            this.Text = "AgreedTermForm";
            this.Deactivate += new System.EventHandler(this.AgreedTermForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FreeTermLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton DeleteAgreedTermBarItem;
        private DevExpress.XtraEditors.SimpleButton EditAgreedTermBarItem;
        private DevExpress.XtraEditors.SimpleButton NewAgreedTermBarItem;
        private System.Windows.Forms.MonthCalendar DateCalendar;
        private DevExpress.XtraEditors.LookUpEdit FreeTermLE;
        private DevExpress.XtraEditors.LookUpEdit PatientLE;
        private DevExpress.XtraGrid.GridControl AgreedTermGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView AgreedTermGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit DoctorLE;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermID;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermDate;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermTime;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermPatient;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermDoctor;
    }
}