namespace OrdinacijaDevExpress.FormDoctor
{
    partial class MainFormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormDoctor));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.AgreedTermBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ReferalBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DiagnoseBarItme = new DevExpress.XtraBars.BarButtonItem();
            this.VisitDoctorBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.PatientInfoBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.NewPatientBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditPatientBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeletePatientBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ChangePasswordBarITem = new DevExpress.XtraBars.BarButtonItem();
            this.AgreedTermAllBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.PatientPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Patient = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.PatientGridControl = new DevExpress.XtraGrid.GridControl();
            this.PatientGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamePatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SurnamePatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PasswordPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActivePatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrescriptionBarItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.AgreedTermBarItem,
            this.ReferalBarItem,
            this.DiagnoseBarItme,
            this.VisitDoctorBarItem,
            this.skinRibbonGalleryBarItem1,
            this.PatientInfoBarItem,
            this.NewPatientBarItem,
            this.EditPatientBarItem,
            this.DeletePatientBarItem,
            this.ChangePasswordBarITem,
            this.AgreedTermAllBarItem,
            this.PrescriptionBarItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 22;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PatientPage,
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(815, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // AgreedTermBarItem
            // 
            this.AgreedTermBarItem.Caption = "Agreed term for patient";
            this.AgreedTermBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.AgreedTermBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("AgreedTermBarItem.Glyph")));
            this.AgreedTermBarItem.Id = 5;
            this.AgreedTermBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AgreedTermBarItem.LargeGlyph")));
            this.AgreedTermBarItem.Name = "AgreedTermBarItem";
            this.AgreedTermBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AgreedTermBarItem_ItemClick);
            // 
            // ReferalBarItem
            // 
            this.ReferalBarItem.Caption = "Referral";
            this.ReferalBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ReferalBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ReferalBarItem.Glyph")));
            this.ReferalBarItem.Id = 6;
            this.ReferalBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ReferalBarItem.LargeGlyph")));
            this.ReferalBarItem.Name = "ReferalBarItem";
            this.ReferalBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReferalBarItem_ItemClick);
            // 
            // DiagnoseBarItme
            // 
            this.DiagnoseBarItme.Caption = "Diagnose";
            this.DiagnoseBarItme.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DiagnoseBarItme.Glyph = ((System.Drawing.Image)(resources.GetObject("DiagnoseBarItme.Glyph")));
            this.DiagnoseBarItme.Id = 7;
            this.DiagnoseBarItme.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DiagnoseBarItme.LargeGlyph")));
            this.DiagnoseBarItme.Name = "DiagnoseBarItme";
            this.DiagnoseBarItme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DiagnoseBarItme_ItemClick);
            // 
            // VisitDoctorBarItem
            // 
            this.VisitDoctorBarItem.Caption = "Visit doctor";
            this.VisitDoctorBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.VisitDoctorBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("VisitDoctorBarItem.Glyph")));
            this.VisitDoctorBarItem.Id = 8;
            this.VisitDoctorBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("VisitDoctorBarItem.LargeGlyph")));
            this.VisitDoctorBarItem.Name = "VisitDoctorBarItem";
            this.VisitDoctorBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.VisitDoctorBarItem_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.skinRibbonGalleryBarItem1.Id = 12;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // PatientInfoBarItem
            // 
            this.PatientInfoBarItem.Caption = "Patient info";
            this.PatientInfoBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.PatientInfoBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("PatientInfoBarItem.Glyph")));
            this.PatientInfoBarItem.Id = 15;
            this.PatientInfoBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PatientInfoBarItem.LargeGlyph")));
            this.PatientInfoBarItem.Name = "PatientInfoBarItem";
            this.PatientInfoBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PatientInfoBarItem_ItemClick);
            // 
            // NewPatientBarItem
            // 
            this.NewPatientBarItem.Caption = "New patient";
            this.NewPatientBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.NewPatientBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("NewPatientBarItem.Glyph")));
            this.NewPatientBarItem.Id = 16;
            this.NewPatientBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("NewPatientBarItem.LargeGlyph")));
            this.NewPatientBarItem.Name = "NewPatientBarItem";
            this.NewPatientBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewPatientBarItem_ItemClick);
            // 
            // EditPatientBarItem
            // 
            this.EditPatientBarItem.Caption = "Edit patient";
            this.EditPatientBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.EditPatientBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("EditPatientBarItem.Glyph")));
            this.EditPatientBarItem.Id = 17;
            this.EditPatientBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("EditPatientBarItem.LargeGlyph")));
            this.EditPatientBarItem.Name = "EditPatientBarItem";
            this.EditPatientBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditPatientBarItem_ItemClick);
            // 
            // DeletePatientBarItem
            // 
            this.DeletePatientBarItem.Caption = "Delete patient";
            this.DeletePatientBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DeletePatientBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DeletePatientBarItem.Glyph")));
            this.DeletePatientBarItem.Id = 18;
            this.DeletePatientBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DeletePatientBarItem.LargeGlyph")));
            this.DeletePatientBarItem.Name = "DeletePatientBarItem";
            this.DeletePatientBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeletePatientBarItem_ItemClick);
            // 
            // ChangePasswordBarITem
            // 
            this.ChangePasswordBarITem.Caption = "Change password";
            this.ChangePasswordBarITem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ChangePasswordBarITem.Glyph = ((System.Drawing.Image)(resources.GetObject("ChangePasswordBarITem.Glyph")));
            this.ChangePasswordBarITem.Id = 19;
            this.ChangePasswordBarITem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ChangePasswordBarITem.LargeGlyph")));
            this.ChangePasswordBarITem.Name = "ChangePasswordBarITem";
            this.ChangePasswordBarITem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChangePasswordBarITem_ItemClick);
            // 
            // AgreedTermAllBarItem
            // 
            this.AgreedTermAllBarItem.Caption = "Agreed term";
            this.AgreedTermAllBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.AgreedTermAllBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("AgreedTermAllBarItem.Glyph")));
            this.AgreedTermAllBarItem.Id = 20;
            this.AgreedTermAllBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AgreedTermAllBarItem.LargeGlyph")));
            this.AgreedTermAllBarItem.Name = "AgreedTermAllBarItem";
            this.AgreedTermAllBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AgreedTermAllBarItem_ItemClick);
            // 
            // PatientPage
            // 
            this.PatientPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Patient,
            this.ribbonPageGroup3});
            this.PatientPage.Name = "PatientPage";
            this.PatientPage.Text = "Patient";
            // 
            // Patient
            // 
            this.Patient.ItemLinks.Add(this.NewPatientBarItem);
            this.Patient.ItemLinks.Add(this.EditPatientBarItem);
            this.Patient.ItemLinks.Add(this.DeletePatientBarItem);
            this.Patient.ItemLinks.Add(this.PatientInfoBarItem);
            this.Patient.ItemLinks.Add(this.VisitDoctorBarItem);
            this.Patient.ItemLinks.Add(this.DiagnoseBarItme);
            this.Patient.ItemLinks.Add(this.ReferalBarItem);
            this.Patient.ItemLinks.Add(this.PrescriptionBarItem);
            this.Patient.ItemLinks.Add(this.AgreedTermBarItem);
            this.Patient.Name = "Patient";
            this.Patient.Text = "Patient";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.AgreedTermAllBarItem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "All user";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Options";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ChangePasswordBarITem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Options";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Style";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Style";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.AutoHeight = true;
            this.ribbonStatusBar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 584);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(815, 31);
            // 
            // PatientGridControl
            // 
            this.PatientGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientGridControl.Location = new System.Drawing.Point(0, 188);
            this.PatientGridControl.MainView = this.PatientGridView;
            this.PatientGridControl.MenuManager = this.ribbon;
            this.PatientGridControl.Name = "PatientGridControl";
            this.PatientGridControl.Size = new System.Drawing.Size(815, 400);
            this.PatientGridControl.TabIndex = 2;
            this.PatientGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PatientGridView});
            // 
            // PatientGridView
            // 
            this.PatientGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPatient,
            this.NamePatient,
            this.SurnamePatient,
            this.EmailPatient,
            this.PasswordPatient,
            this.ContactPatient,
            this.DoctorPatient,
            this.ActivePatient});
            this.PatientGridView.GridControl = this.PatientGridControl;
            this.PatientGridView.Name = "PatientGridView";
            this.PatientGridView.OptionsView.ShowAutoFilterRow = true;
            this.PatientGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.PatientGridView_RowClick);
            // 
            // IDPatient
            // 
            this.IDPatient.Caption = "ID";
            this.IDPatient.FieldName = "ID";
            this.IDPatient.Name = "IDPatient";
            this.IDPatient.OptionsColumn.AllowEdit = false;
            // 
            // NamePatient
            // 
            this.NamePatient.Caption = "Name";
            this.NamePatient.FieldName = "Name";
            this.NamePatient.Name = "NamePatient";
            this.NamePatient.OptionsColumn.AllowEdit = false;
            this.NamePatient.Visible = true;
            this.NamePatient.VisibleIndex = 0;
            // 
            // SurnamePatient
            // 
            this.SurnamePatient.Caption = "Surname";
            this.SurnamePatient.FieldName = "Surname";
            this.SurnamePatient.Name = "SurnamePatient";
            this.SurnamePatient.OptionsColumn.AllowEdit = false;
            this.SurnamePatient.Visible = true;
            this.SurnamePatient.VisibleIndex = 1;
            // 
            // EmailPatient
            // 
            this.EmailPatient.Caption = "Email";
            this.EmailPatient.FieldName = "Email";
            this.EmailPatient.Name = "EmailPatient";
            this.EmailPatient.OptionsColumn.AllowEdit = false;
            this.EmailPatient.Visible = true;
            this.EmailPatient.VisibleIndex = 2;
            // 
            // PasswordPatient
            // 
            this.PasswordPatient.Caption = "Password";
            this.PasswordPatient.FieldName = "Password";
            this.PasswordPatient.Name = "PasswordPatient";
            this.PasswordPatient.OptionsColumn.AllowEdit = false;
            // 
            // ContactPatient
            // 
            this.ContactPatient.Caption = "Contact";
            this.ContactPatient.FieldName = "Contact";
            this.ContactPatient.Name = "ContactPatient";
            this.ContactPatient.OptionsColumn.AllowEdit = false;
            this.ContactPatient.Visible = true;
            this.ContactPatient.VisibleIndex = 3;
            // 
            // DoctorPatient
            // 
            this.DoctorPatient.Caption = "Doctor";
            this.DoctorPatient.FieldName = "Doctor";
            this.DoctorPatient.Name = "DoctorPatient";
            this.DoctorPatient.OptionsColumn.AllowEdit = false;
            // 
            // ActivePatient
            // 
            this.ActivePatient.Caption = "Active";
            this.ActivePatient.FieldName = "Active";
            this.ActivePatient.Name = "ActivePatient";
            this.ActivePatient.OptionsColumn.AllowEdit = false;
            this.ActivePatient.Visible = true;
            this.ActivePatient.VisibleIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // PrescriptionBarItem
            // 
            this.PrescriptionBarItem.Caption = "Prescription";
            this.PrescriptionBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.PrescriptionBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("PrescriptionBarItem.Glyph")));
            this.PrescriptionBarItem.Id = 21;
            this.PrescriptionBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PrescriptionBarItem.LargeGlyph")));
            this.PrescriptionBarItem.Name = "PrescriptionBarItem";
            // 
            // MainFormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainFormDoctor";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainFormDoctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainFormDoctor_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormDoctor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem AgreedTermBarItem;
        private DevExpress.XtraBars.BarButtonItem ReferalBarItem;
        private DevExpress.XtraBars.BarButtonItem DiagnoseBarItme;
        private DevExpress.XtraBars.BarButtonItem VisitDoctorBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage PatientPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Patient;
        private DevExpress.XtraGrid.GridControl PatientGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PatientGridView;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn IDPatient;
        private DevExpress.XtraGrid.Columns.GridColumn NamePatient;
        private DevExpress.XtraGrid.Columns.GridColumn SurnamePatient;
        private DevExpress.XtraGrid.Columns.GridColumn EmailPatient;
        private DevExpress.XtraGrid.Columns.GridColumn PasswordPatient;
        private DevExpress.XtraGrid.Columns.GridColumn ContactPatient;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorPatient;
        private DevExpress.XtraGrid.Columns.GridColumn ActivePatient;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem PatientInfoBarItem;
        private DevExpress.XtraBars.BarButtonItem NewPatientBarItem;
        private DevExpress.XtraBars.BarButtonItem EditPatientBarItem;
        private DevExpress.XtraBars.BarButtonItem DeletePatientBarItem;
        private DevExpress.XtraBars.BarButtonItem ChangePasswordBarITem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem AgreedTermAllBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem PrescriptionBarItem;
    }
}