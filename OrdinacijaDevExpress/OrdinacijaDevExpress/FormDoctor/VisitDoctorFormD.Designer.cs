namespace OrdinacijaDevExpress.FormDoctor
{
    partial class VisitDoctorFormD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitDoctorFormD));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.EditBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.AddBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.VisitDoctorGridControl = new DevExpress.XtraGrid.GridControl();
            this.VisitDoctorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VisitDoctorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitDoctorDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTE = new DevExpress.XtraEditors.DateEdit();
            this.DescriptionME = new DevExpress.XtraEditors.MemoEdit();
            this.ReasonME = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReasonME.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.EditBarItem,
            this.DeleteBarItem,
            this.AddBarItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1199, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // EditBarItem
            // 
            this.EditBarItem.Caption = "Edit";
            this.EditBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.EditBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("EditBarItem.Glyph")));
            this.EditBarItem.Id = 1;
            this.EditBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("EditBarItem.LargeGlyph")));
            this.EditBarItem.Name = "EditBarItem";
            this.EditBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditBarItem_ItemClick);
            // 
            // DeleteBarItem
            // 
            this.DeleteBarItem.Caption = "Delete";
            this.DeleteBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DeleteBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DeleteBarItem.Glyph")));
            this.DeleteBarItem.Id = 2;
            this.DeleteBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DeleteBarItem.LargeGlyph")));
            this.DeleteBarItem.Name = "DeleteBarItem";
            this.DeleteBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBarItem_ItemClick);
            // 
            // AddBarItem
            // 
            this.AddBarItem.Caption = "Add";
            this.AddBarItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.AddBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("AddBarItem.Glyph")));
            this.AddBarItem.Id = 3;
            this.AddBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AddBarItem.LargeGlyph")));
            this.AddBarItem.Name = "AddBarItem";
            this.AddBarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddBarItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.AddBarItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EditBarItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteBarItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Action";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 663);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1199, 31);
            // 
            // VisitDoctorGridControl
            // 
            this.VisitDoctorGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitDoctorGridControl.Location = new System.Drawing.Point(0, 328);
            this.VisitDoctorGridControl.MainView = this.VisitDoctorGridView;
            this.VisitDoctorGridControl.Name = "VisitDoctorGridControl";
            this.VisitDoctorGridControl.Size = new System.Drawing.Size(1199, 354);
            this.VisitDoctorGridControl.TabIndex = 24;
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
            // 
            // VisitDoctorDoctor
            // 
            this.VisitDoctorDoctor.Caption = "Doctor";
            this.VisitDoctorDoctor.FieldName = "Doctor";
            this.VisitDoctorDoctor.Name = "VisitDoctorDoctor";
            this.VisitDoctorDoctor.OptionsColumn.AllowEdit = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1038, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reason";
            // 
            // DateTE
            // 
            this.DateTE.EditValue = null;
            this.DateTE.Location = new System.Drawing.Point(1041, 247);
            this.DateTE.Name = "DateTE";
            this.DateTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTE.Size = new System.Drawing.Size(100, 20);
            this.DateTE.TabIndex = 18;
            // 
            // DescriptionME
            // 
            this.DescriptionME.Location = new System.Drawing.Point(513, 192);
            this.DescriptionME.Name = "DescriptionME";
            this.DescriptionME.Size = new System.Drawing.Size(500, 130);
            this.DescriptionME.TabIndex = 15;
            // 
            // ReasonME
            // 
            this.ReasonME.Location = new System.Drawing.Point(7, 192);
            this.ReasonME.Name = "ReasonME";
            this.ReasonME.Size = new System.Drawing.Size(500, 130);
            this.ReasonME.TabIndex = 14;
            // 
            // VisitDoctorFormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 694);
            this.Controls.Add(this.VisitDoctorGridControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTE);
            this.Controls.Add(this.DescriptionME);
            this.Controls.Add(this.ReasonME);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "VisitDoctorFormD";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "VisitDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitDoctorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReasonME.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem EditBarItem;
        private DevExpress.XtraBars.BarButtonItem DeleteBarItem;
        private DevExpress.XtraBars.BarButtonItem AddBarItem;
        private DevExpress.XtraGrid.GridControl VisitDoctorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView VisitDoctorGridView;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorID;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorReason;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorDescription;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorDate;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorPatient;
        private DevExpress.XtraGrid.Columns.GridColumn VisitDoctorDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit DateTE;
        private DevExpress.XtraEditors.MemoEdit DescriptionME;
        private DevExpress.XtraEditors.MemoEdit ReasonME;
    }
}