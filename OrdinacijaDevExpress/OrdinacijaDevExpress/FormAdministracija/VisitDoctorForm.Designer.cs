namespace OrdinacijaDevExpress
{
    partial class VisitDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitDoctorForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DeleteVisitDoctorBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.EditVisitDoctorBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.NewVisitDoctorBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.ReasonME = new DevExpress.XtraEditors.MemoEdit();
            this.DescriptionME = new DevExpress.XtraEditors.MemoEdit();
            this.DoctorLE = new DevExpress.XtraEditors.LookUpEdit();
            this.PatientLE = new DevExpress.XtraEditors.LookUpEdit();
            this.DateTE = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VisitDoctorGridControl = new DevExpress.XtraGrid.GridControl();
            this.VisitDoctorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VisitDoctorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReasonME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.DeleteVisitDoctorBarItem);
            this.groupControl1.Controls.Add(this.EditVisitDoctorBarItem);
            this.groupControl1.Controls.Add(this.NewVisitDoctorBarItem);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1209, 90);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Action";
            // 
            // DeleteVisitDoctorBarItem
            // 
            this.DeleteVisitDoctorBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteVisitDoctorBarItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteVisitDoctorBarItem.Image")));
            this.DeleteVisitDoctorBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteVisitDoctorBarItem.Location = new System.Drawing.Point(104, 20);
            this.DeleteVisitDoctorBarItem.Name = "DeleteVisitDoctorBarItem";
            this.DeleteVisitDoctorBarItem.Size = new System.Drawing.Size(51, 68);
            this.DeleteVisitDoctorBarItem.TabIndex = 7;
            this.DeleteVisitDoctorBarItem.Text = "Delete";
            this.DeleteVisitDoctorBarItem.Click += new System.EventHandler(this.DeleteVisitDoctorBarItem_Click);
            // 
            // EditVisitDoctorBarItem
            // 
            this.EditVisitDoctorBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditVisitDoctorBarItem.Image = ((System.Drawing.Image)(resources.GetObject("EditVisitDoctorBarItem.Image")));
            this.EditVisitDoctorBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.EditVisitDoctorBarItem.Location = new System.Drawing.Point(53, 20);
            this.EditVisitDoctorBarItem.Name = "EditVisitDoctorBarItem";
            this.EditVisitDoctorBarItem.Size = new System.Drawing.Size(51, 68);
            this.EditVisitDoctorBarItem.TabIndex = 5;
            this.EditVisitDoctorBarItem.Text = "Edit";
            this.EditVisitDoctorBarItem.Click += new System.EventHandler(this.EditVisitDoctorBarItem_Click);
            // 
            // NewVisitDoctorBarItem
            // 
            this.NewVisitDoctorBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewVisitDoctorBarItem.Image = ((System.Drawing.Image)(resources.GetObject("NewVisitDoctorBarItem.Image")));
            this.NewVisitDoctorBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewVisitDoctorBarItem.Location = new System.Drawing.Point(2, 20);
            this.NewVisitDoctorBarItem.Name = "NewVisitDoctorBarItem";
            this.NewVisitDoctorBarItem.Size = new System.Drawing.Size(51, 68);
            this.NewVisitDoctorBarItem.TabIndex = 4;
            this.NewVisitDoctorBarItem.Text = "New";
            this.NewVisitDoctorBarItem.Click += new System.EventHandler(this.NewVisitDoctorBarItem_Click);
            // 
            // ReasonME
            // 
            this.ReasonME.Location = new System.Drawing.Point(12, 117);
            this.ReasonME.Name = "ReasonME";
            this.ReasonME.Size = new System.Drawing.Size(500, 130);
            this.ReasonME.TabIndex = 3;
            // 
            // DescriptionME
            // 
            this.DescriptionME.Location = new System.Drawing.Point(518, 118);
            this.DescriptionME.Name = "DescriptionME";
            this.DescriptionME.Size = new System.Drawing.Size(500, 130);
            this.DescriptionME.TabIndex = 4;
            // 
            // DoctorLE
            // 
            this.DoctorLE.Location = new System.Drawing.Point(1044, 221);
            this.DoctorLE.Name = "DoctorLE";
            this.DoctorLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DoctorLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.DoctorLE.Size = new System.Drawing.Size(100, 20);
            this.DoctorLE.TabIndex = 5;
            // 
            // PatientLE
            // 
            this.PatientLE.Location = new System.Drawing.Point(1044, 165);
            this.PatientLE.Name = "PatientLE";
            this.PatientLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PatientLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.PatientLE.Size = new System.Drawing.Size(100, 20);
            this.PatientLE.TabIndex = 6;
            // 
            // DateTE
            // 
            this.DateTE.EditValue = null;
            this.DateTE.Location = new System.Drawing.Point(1044, 117);
            this.DateTE.Name = "DateTE";
            this.DateTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTE.Size = new System.Drawing.Size(100, 20);
            this.DateTE.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reason";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1041, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1041, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Patient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1041, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doctor";
            // 
            // VisitDoctorGridControl
            // 
            this.VisitDoctorGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitDoctorGridControl.Location = new System.Drawing.Point(0, 249);
            this.VisitDoctorGridControl.MainView = this.VisitDoctorGridView;
            this.VisitDoctorGridControl.Name = "VisitDoctorGridControl";
            this.VisitDoctorGridControl.Size = new System.Drawing.Size(1209, 291);
            this.VisitDoctorGridControl.TabIndex = 13;
            this.VisitDoctorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VisitDoctorGridView});
            // 
            // VisitDoctorGridView
            // 
            this.VisitDoctorGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VisitDoctorID,
            this.VisitDoctorReason,
            this.VisitDoctorDescription,
            this.VisitDoctorDate,
            this.VisitDoctorPatient,
            this.VisitDoctorDoctor});
            this.VisitDoctorGridView.GridControl = this.VisitDoctorGridControl;
            this.VisitDoctorGridView.Name = "VisitDoctorGridView";
            this.VisitDoctorGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.VisitDoctorGridView_RowClick);
            this.VisitDoctorGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.VisitDoctorGridView_CustomColumnDisplayText);
            // 
            // VisitDoctorID
            // 
            this.VisitDoctorID.Caption = "ID";
            this.VisitDoctorID.FieldName = "ID";
            this.VisitDoctorID.Name = "VisitDoctorID";
            this.VisitDoctorID.OptionsColumn.AllowEdit = false;
            // 
            // VisitDoctorReason
            // 
            this.VisitDoctorReason.Caption = "Reason";
            this.VisitDoctorReason.FieldName = "Reason";
            this.VisitDoctorReason.Name = "VisitDoctorReason";
            this.VisitDoctorReason.OptionsColumn.AllowEdit = false;
            this.VisitDoctorReason.Visible = true;
            this.VisitDoctorReason.VisibleIndex = 0;
            // 
            // VisitDoctorDescription
            // 
            this.VisitDoctorDescription.Caption = "Decription";
            this.VisitDoctorDescription.FieldName = "Description";
            this.VisitDoctorDescription.Name = "VisitDoctorDescription";
            this.VisitDoctorDescription.OptionsColumn.AllowEdit = false;
            this.VisitDoctorDescription.Visible = true;
            this.VisitDoctorDescription.VisibleIndex = 1;
            // 
            // VisitDoctorDate
            // 
            this.VisitDoctorDate.Caption = "Date";
            this.VisitDoctorDate.FieldName = "Date";
            this.VisitDoctorDate.Name = "VisitDoctorDate";
            this.VisitDoctorDate.OptionsColumn.AllowEdit = false;
            this.VisitDoctorDate.Visible = true;
            this.VisitDoctorDate.VisibleIndex = 2;
            // 
            // VisitDoctorPatient
            // 
            this.VisitDoctorPatient.Caption = "Patient";
            this.VisitDoctorPatient.FieldName = "Patient";
            this.VisitDoctorPatient.Name = "VisitDoctorPatient";
            this.VisitDoctorPatient.OptionsColumn.AllowEdit = false;
            this.VisitDoctorPatient.Visible = true;
            this.VisitDoctorPatient.VisibleIndex = 3;
            // 
            // VisitDoctorDoctor
            // 
            this.VisitDoctorDoctor.Caption = "Doctor";
            this.VisitDoctorDoctor.FieldName = "Doctor";
            this.VisitDoctorDoctor.Name = "VisitDoctorDoctor";
            this.VisitDoctorDoctor.OptionsColumn.AllowEdit = false;
            this.VisitDoctorDoctor.Visible = true;
            this.VisitDoctorDoctor.VisibleIndex = 4;
            // 
            // VisitDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 540);
            this.Controls.Add(this.VisitDoctorGridControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTE);
            this.Controls.Add(this.PatientLE);
            this.Controls.Add(this.DoctorLE);
            this.Controls.Add(this.DescriptionME);
            this.Controls.Add(this.ReasonME);
            this.Controls.Add(this.groupControl1);
            this.Name = "VisitDoctorForm";
            this.Text = "VisitDoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReasonME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton DeleteVisitDoctorBarItem;
        private DevExpress.XtraEditors.SimpleButton EditVisitDoctorBarItem;
        private DevExpress.XtraEditors.SimpleButton NewVisitDoctorBarItem;
        private DevExpress.XtraEditors.MemoEdit ReasonME;
        private DevExpress.XtraEditors.MemoEdit DescriptionME;
        private DevExpress.XtraEditors.LookUpEdit DoctorLE;
        private DevExpress.XtraEditors.LookUpEdit PatientLE;
        private DevExpress.XtraEditors.DateEdit DateTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl VisitDoctorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView VisitDoctorGridView;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorID;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorReason;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorDescription;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorDate;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorPatient;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorDoctor;
    }
}