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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.PatientPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.AgreedTermBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ReferalBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DiagnoseBarItme = new DevExpress.XtraBars.BarButtonItem();
            this.VisitDoctorBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.Patient = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PatientGridControl = new DevExpress.XtraGrid.GridControl();
            this.PatientGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.skinRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PatientPage,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(763, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 415);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(763, 31);
            // 
            // PatientPage
            // 
            this.PatientPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Patient});
            this.PatientPage.Name = "PatientPage";
            this.PatientPage.Text = "Patient";
            // 
            // AgreedTermBarItem
            // 
            this.AgreedTermBarItem.Caption = "Agreed term";
            this.AgreedTermBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.AgreedTermBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("AgreedTermBarItem.Glyph")));
            this.AgreedTermBarItem.Id = 5;
            this.AgreedTermBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AgreedTermBarItem.LargeGlyph")));
            this.AgreedTermBarItem.Name = "AgreedTermBarItem";
            // 
            // ReferalBarItem
            // 
            this.ReferalBarItem.Caption = "Referral";
            this.ReferalBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ReferalBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ReferalBarItem.Glyph")));
            this.ReferalBarItem.Id = 6;
            this.ReferalBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ReferalBarItem.LargeGlyph")));
            this.ReferalBarItem.Name = "ReferalBarItem";
            // 
            // DiagnoseBarItme
            // 
            this.DiagnoseBarItme.Caption = "Diagnose";
            this.DiagnoseBarItme.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DiagnoseBarItme.Glyph = ((System.Drawing.Image)(resources.GetObject("DiagnoseBarItme.Glyph")));
            this.DiagnoseBarItme.Id = 7;
            this.DiagnoseBarItme.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DiagnoseBarItme.LargeGlyph")));
            this.DiagnoseBarItme.Name = "DiagnoseBarItme";
            // 
            // VisitDoctorBarItem
            // 
            this.VisitDoctorBarItem.Caption = "Visit doctor";
            this.VisitDoctorBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.VisitDoctorBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("VisitDoctorBarItem.Glyph")));
            this.VisitDoctorBarItem.Id = 8;
            this.VisitDoctorBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("VisitDoctorBarItem.LargeGlyph")));
            this.VisitDoctorBarItem.Name = "VisitDoctorBarItem";
            // 
            // Patient
            // 
            this.Patient.ItemLinks.Add(this.VisitDoctorBarItem);
            this.Patient.ItemLinks.Add(this.DiagnoseBarItme);
            this.Patient.ItemLinks.Add(this.ReferalBarItem);
            this.Patient.ItemLinks.Add(this.AgreedTermBarItem);
            this.Patient.Name = "Patient";
            this.Patient.Text = "Patient";
            // 
            // PatientGridControl
            // 
            this.PatientGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientGridControl.Location = new System.Drawing.Point(0, 192);
            this.PatientGridControl.MainView = this.PatientGridView;
            this.PatientGridControl.MenuManager = this.ribbon;
            this.PatientGridControl.Name = "PatientGridControl";
            this.PatientGridControl.Size = new System.Drawing.Size(763, 227);
            this.PatientGridControl.TabIndex = 2;
            this.PatientGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PatientGridView});
            // 
            // PatientGridView
            // 
            this.PatientGridView.GridControl = this.PatientGridControl;
            this.PatientGridView.Name = "PatientGridView";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 166);
            this.textEdit1.MenuManager = this.ribbon;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(148, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
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
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.skinRibbonGalleryBarItem1.Id = 12;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // MainFormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.PatientGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainFormDoctor";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainFormDoctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}