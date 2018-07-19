namespace OrdinacijaDevExpress
{
    partial class ReferralFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferralFormcs));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DescriptionME = new DevExpress.XtraEditors.MemoEdit();
            this.NameTE = new DevExpress.XtraEditors.TextEdit();
            this.PatientLE = new DevExpress.XtraEditors.LookUpEdit();
            this.DoctorLE = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReferralGridControl = new DevExpress.XtraGrid.GridControl();
            this.ReferralGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ReferralID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferralName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferralDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferralPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferralDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferralGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferralGridView)).BeginInit();
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
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(758, 143);
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
            // DescriptionME
            // 
            this.DescriptionME.Location = new System.Drawing.Point(12, 165);
            this.DescriptionME.MenuManager = this.ribbon;
            this.DescriptionME.Name = "DescriptionME";
            this.DescriptionME.Size = new System.Drawing.Size(482, 121);
            this.DescriptionME.TabIndex = 2;
            // 
            // NameTE
            // 
            this.NameTE.Location = new System.Drawing.Point(553, 164);
            this.NameTE.MenuManager = this.ribbon;
            this.NameTE.Name = "NameTE";
            this.NameTE.Size = new System.Drawing.Size(160, 20);
            this.NameTE.TabIndex = 3;
            // 
            // PatientLE
            // 
            this.PatientLE.Location = new System.Drawing.Point(553, 216);
            this.PatientLE.MenuManager = this.ribbon;
            this.PatientLE.Name = "PatientLE";
            this.PatientLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PatientLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.PatientLE.Size = new System.Drawing.Size(158, 20);
            this.PatientLE.TabIndex = 4;
            // 
            // DoctorLE
            // 
            this.DoctorLE.Location = new System.Drawing.Point(555, 266);
            this.DoctorLE.MenuManager = this.ribbon;
            this.DoctorLE.Name = "DoctorLE";
            this.DoctorLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DoctorLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.DoctorLE.Size = new System.Drawing.Size(158, 20);
            this.DoctorLE.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // ReferralGridControl
            // 
            this.ReferralGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReferralGridControl.Location = new System.Drawing.Point(0, 304);
            this.ReferralGridControl.MainView = this.ReferralGridView;
            this.ReferralGridControl.MenuManager = this.ribbon;
            this.ReferralGridControl.Name = "ReferralGridControl";
            this.ReferralGridControl.Size = new System.Drawing.Size(758, 316);
            this.ReferralGridControl.TabIndex = 10;
            this.ReferralGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ReferralGridView});
            // 
            // ReferralGridView
            // 
            this.ReferralGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ReferralID,
            this.ReferralName,
            this.ReferralDescription,
            this.ReferralPatient,
            this.ReferralDoctor});
            this.ReferralGridView.GridControl = this.ReferralGridControl;
            this.ReferralGridView.Name = "ReferralGridView";
            this.ReferralGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ReferralGridView_RowClick);
            this.ReferralGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.ReferralGridView_CustomColumnDisplayText);
            // 
            // ReferralID
            // 
            this.ReferralID.Caption = "ID";
            this.ReferralID.FieldName = "ID";
            this.ReferralID.Name = "ReferralID";
            this.ReferralID.OptionsColumn.AllowEdit = false;
            // 
            // ReferralName
            // 
            this.ReferralName.Caption = "Name";
            this.ReferralName.FieldName = "Name";
            this.ReferralName.Name = "ReferralName";
            this.ReferralName.OptionsColumn.AllowEdit = false;
            this.ReferralName.Visible = true;
            this.ReferralName.VisibleIndex = 0;
            // 
            // ReferralDescription
            // 
            this.ReferralDescription.Caption = "ReferalDescription";
            this.ReferralDescription.FieldName = "Description";
            this.ReferralDescription.Name = "ReferralDescription";
            this.ReferralDescription.OptionsColumn.AllowEdit = false;
            this.ReferralDescription.Visible = true;
            this.ReferralDescription.VisibleIndex = 1;
            // 
            // ReferralPatient
            // 
            this.ReferralPatient.Caption = "Patient";
            this.ReferralPatient.FieldName = "Patient";
            this.ReferralPatient.Name = "ReferralPatient";
            this.ReferralPatient.OptionsColumn.AllowEdit = false;
            this.ReferralPatient.Visible = true;
            this.ReferralPatient.VisibleIndex = 2;
            // 
            // ReferralDoctor
            // 
            this.ReferralDoctor.Caption = "Doctor";
            this.ReferralDoctor.FieldName = "Doctor";
            this.ReferralDoctor.Name = "ReferralDoctor";
            this.ReferralDoctor.OptionsColumn.AllowEdit = false;
            this.ReferralDoctor.Visible = true;
            this.ReferralDoctor.VisibleIndex = 3;
            // 
            // ReferralFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 614);
            this.Controls.Add(this.ReferralGridControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorLE);
            this.Controls.Add(this.PatientLE);
            this.Controls.Add(this.NameTE);
            this.Controls.Add(this.DescriptionME);
            this.Controls.Add(this.ribbon);
            this.Name = "ReferralFormcs";
            this.Ribbon = this.ribbon;
            this.Text = "ReferralFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferralGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferralGridView)).EndInit();
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
        private DevExpress.XtraEditors.MemoEdit DescriptionME;
        private DevExpress.XtraEditors.TextEdit NameTE;
        private DevExpress.XtraEditors.LookUpEdit PatientLE;
        private DevExpress.XtraEditors.LookUpEdit DoctorLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl ReferralGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ReferralGridView;
        private DevExpress.XtraGrid.Columns.GridColumn ReferralID;
        private DevExpress.XtraGrid.Columns.GridColumn ReferralName;
        private DevExpress.XtraGrid.Columns.GridColumn ReferralDescription;
        private DevExpress.XtraGrid.Columns.GridColumn ReferralPatient;
        private DevExpress.XtraGrid.Columns.GridColumn ReferralDoctor;
    }
}