namespace OrdinacijaDevExpress
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PresciptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.PresciptionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PresciptionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PresciptionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PresciptionDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PresciptionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PresciptionPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PresciptionDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateTE = new DevExpress.XtraEditors.DateEdit();
            this.PatientLE = new DevExpress.XtraEditors.LookUpEdit();
            this.DoctorLE = new DevExpress.XtraEditors.LookUpEdit();
            this.DescriptionME = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresciptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresciptionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.NewBarItem,
            this.EditBarItem,
            this.DeleteBarItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(703, 143);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // NewBarItem
            // 
            this.NewBarItem.Caption = "New";
            this.NewBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.NewBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("NewBarItem.Glyph")));
            this.NewBarItem.Id = 1;
            this.NewBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("NewBarItem.LargeGlyph")));
            this.NewBarItem.Name = "NewBarItem";
            this.NewBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewBarItem_ItemClick);
            // 
            // EditBarItem
            // 
            this.EditBarItem.Caption = "Edit";
            this.EditBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.EditBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("EditBarItem.Glyph")));
            this.EditBarItem.Id = 2;
            this.EditBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("EditBarItem.LargeGlyph")));
            this.EditBarItem.Name = "EditBarItem";
            this.EditBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditBarItem_ItemClick);
            // 
            // DeleteBarItem
            // 
            this.DeleteBarItem.Caption = "Delete";
            this.DeleteBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DeleteBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DeleteBarItem.Glyph")));
            this.DeleteBarItem.Id = 3;
            this.DeleteBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DeleteBarItem.LargeGlyph")));
            this.DeleteBarItem.Name = "DeleteBarItem";
            this.DeleteBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBarItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Action";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.NewBarItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EditBarItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteBarItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Action";
            // 
            // PresciptionGridControl
            // 
            this.PresciptionGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresciptionGridControl.Location = new System.Drawing.Point(0, 297);
            this.PresciptionGridControl.MainView = this.PresciptionGridView;
            this.PresciptionGridControl.MenuManager = this.ribbon;
            this.PresciptionGridControl.Name = "PresciptionGridControl";
            this.PresciptionGridControl.Size = new System.Drawing.Size(703, 302);
            this.PresciptionGridControl.TabIndex = 2;
            this.PresciptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PresciptionGridView});
            // 
            // PresciptionGridView
            // 
            this.PresciptionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PresciptionID,
            this.PresciptionName,
            this.PresciptionDescription,
            this.PresciptionDate,
            this.PresciptionPatient,
            this.PresciptionDoctor});
            this.PresciptionGridView.GridControl = this.PresciptionGridControl;
            this.PresciptionGridView.Name = "PresciptionGridView";
            this.PresciptionGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.PresciptionGridView_RowClick);
            this.PresciptionGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.PresciptionGridView_CustomColumnDisplayText);
            // 
            // PresciptionID
            // 
            this.PresciptionID.Caption = "ID";
            this.PresciptionID.FieldName = "ID";
            this.PresciptionID.Name = "PresciptionID";
            this.PresciptionID.OptionsColumn.AllowEdit = false;
            // 
            // PresciptionName
            // 
            this.PresciptionName.Caption = "Name";
            this.PresciptionName.FieldName = "Name";
            this.PresciptionName.Name = "PresciptionName";
            this.PresciptionName.OptionsColumn.AllowEdit = false;
            this.PresciptionName.Visible = true;
            this.PresciptionName.VisibleIndex = 0;
            // 
            // PresciptionDescription
            // 
            this.PresciptionDescription.Caption = "Description";
            this.PresciptionDescription.FieldName = "Description";
            this.PresciptionDescription.Name = "PresciptionDescription";
            this.PresciptionDescription.OptionsColumn.AllowEdit = false;
            this.PresciptionDescription.Visible = true;
            this.PresciptionDescription.VisibleIndex = 1;
            // 
            // PresciptionDate
            // 
            this.PresciptionDate.Caption = "Date";
            this.PresciptionDate.FieldName = "Date";
            this.PresciptionDate.Name = "PresciptionDate";
            this.PresciptionDate.OptionsColumn.AllowEdit = false;
            this.PresciptionDate.Visible = true;
            this.PresciptionDate.VisibleIndex = 2;
            // 
            // PresciptionPatient
            // 
            this.PresciptionPatient.Caption = "Patient";
            this.PresciptionPatient.FieldName = "Patient";
            this.PresciptionPatient.Name = "PresciptionPatient";
            this.PresciptionPatient.OptionsColumn.AllowEdit = false;
            this.PresciptionPatient.Visible = true;
            this.PresciptionPatient.VisibleIndex = 3;
            // 
            // PresciptionDoctor
            // 
            this.PresciptionDoctor.Caption = "Doctor";
            this.PresciptionDoctor.FieldName = "Doctor";
            this.PresciptionDoctor.Name = "PresciptionDoctor";
            this.PresciptionDoctor.OptionsColumn.AllowEdit = false;
            this.PresciptionDoctor.Visible = true;
            this.PresciptionDoctor.VisibleIndex = 4;
            // 
            // DateTE
            // 
            this.DateTE.EditValue = null;
            this.DateTE.Location = new System.Drawing.Point(569, 209);
            this.DateTE.MenuManager = this.ribbon;
            this.DateTE.Name = "DateTE";
            this.DateTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTE.Size = new System.Drawing.Size(100, 20);
            this.DateTE.TabIndex = 3;
            // 
            // PatientLE
            // 
            this.PatientLE.Location = new System.Drawing.Point(569, 235);
            this.PatientLE.MenuManager = this.ribbon;
            this.PatientLE.Name = "PatientLE";
            this.PatientLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PatientLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.PatientLE.Size = new System.Drawing.Size(100, 20);
            this.PatientLE.TabIndex = 4;
            // 
            // DoctorLE
            // 
            this.DoctorLE.Location = new System.Drawing.Point(569, 259);
            this.DoctorLE.MenuManager = this.ribbon;
            this.DoctorLE.Name = "DoctorLE";
            this.DoctorLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DoctorLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.DoctorLE.Size = new System.Drawing.Size(100, 20);
            this.DoctorLE.TabIndex = 5;
            // 
            // DescriptionME
            // 
            this.DescriptionME.Location = new System.Drawing.Point(12, 170);
            this.DescriptionME.MenuManager = this.ribbon;
            this.DescriptionME.Name = "DescriptionME";
            this.DescriptionME.Size = new System.Drawing.Size(492, 121);
            this.DescriptionME.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // NameTE
            // 
            this.NameTE.Location = new System.Drawing.Point(569, 183);
            this.NameTE.MenuManager = this.ribbon;
            this.NameTE.Name = "NameTE";
            this.NameTE.Size = new System.Drawing.Size(100, 20);
            this.NameTE.TabIndex = 13;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 597);
            this.Controls.Add(this.NameTE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionME);
            this.Controls.Add(this.DoctorLE);
            this.Controls.Add(this.PatientLE);
            this.Controls.Add(this.DateTE);
            this.Controls.Add(this.PresciptionGridControl);
            this.Controls.Add(this.ribbon);
            this.Name = "PrescriptionForm";
            this.Ribbon = this.ribbon;
            this.Text = "PrescriptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresciptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresciptionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem NewBarItem;
        private DevExpress.XtraBars.BarButtonItem EditBarItem;
        private DevExpress.XtraBars.BarButtonItem DeleteBarItem;
        private DevExpress.XtraGrid.GridControl PresciptionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PresciptionGridView;
        private DevExpress.XtraEditors.DateEdit DateTE;
        private DevExpress.XtraEditors.LookUpEdit PatientLE;
        private DevExpress.XtraEditors.LookUpEdit DoctorLE;
        private DevExpress.XtraEditors.MemoEdit DescriptionME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn PresciptionID;
        private DevExpress.XtraGrid.Columns.GridColumn PresciptionDescription;
        private DevExpress.XtraGrid.Columns.GridColumn PresciptionDate;
        private DevExpress.XtraGrid.Columns.GridColumn PresciptionPatient;
        private DevExpress.XtraGrid.Columns.GridColumn PresciptionDoctor;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit NameTE;
        private DevExpress.XtraGrid.Columns.GridColumn PresciptionName;
    }
}