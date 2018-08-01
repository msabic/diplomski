﻿namespace OrdinacijaDevExpress.FormDoctor
{
    partial class DiagnoseFormD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnoseFormD));
            this.DiagnosisGridControl = new DevExpress.XtraGrid.GridControl();
            this.DiagnosisGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DiagnosisID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiagnosisName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiagnosisDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiagnosisPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiagnosisDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTE = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionME = new DevExpress.XtraEditors.MemoEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // DiagnosisGridControl
            // 
            this.DiagnosisGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiagnosisGridControl.Location = new System.Drawing.Point(12, 276);
            this.DiagnosisGridControl.MainView = this.DiagnosisGridView;
            this.DiagnosisGridControl.Name = "DiagnosisGridControl";
            this.DiagnosisGridControl.Size = new System.Drawing.Size(746, 326);
            this.DiagnosisGridControl.TabIndex = 29;
            this.DiagnosisGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DiagnosisGridView});
            // 
            // DiagnosisGridView
            // 
            this.DiagnosisGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DiagnosisID,
            this.DiagnosisName,
            this.DiagnosisDescription,
            this.DiagnosisPatient,
            this.DiagnosisDoctor});
            this.DiagnosisGridView.GridControl = this.DiagnosisGridControl;
            this.DiagnosisGridView.Name = "DiagnosisGridView";
            this.DiagnosisGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.DiagnosisGridView_RowClick);
            // 
            // DiagnosisID
            // 
            this.DiagnosisID.Caption = "ID";
            this.DiagnosisID.FieldName = "ID";
            this.DiagnosisID.Name = "DiagnosisID";
            this.DiagnosisID.OptionsColumn.AllowEdit = false;
            // 
            // DiagnosisName
            // 
            this.DiagnosisName.Caption = "Name";
            this.DiagnosisName.FieldName = "Name";
            this.DiagnosisName.Name = "DiagnosisName";
            this.DiagnosisName.OptionsColumn.AllowEdit = false;
            this.DiagnosisName.Visible = true;
            this.DiagnosisName.VisibleIndex = 0;
            // 
            // DiagnosisDescription
            // 
            this.DiagnosisDescription.Caption = "Description";
            this.DiagnosisDescription.FieldName = "Description";
            this.DiagnosisDescription.Name = "DiagnosisDescription";
            this.DiagnosisDescription.OptionsColumn.AllowEdit = false;
            this.DiagnosisDescription.Visible = true;
            this.DiagnosisDescription.VisibleIndex = 1;
            // 
            // DiagnosisPatient
            // 
            this.DiagnosisPatient.Caption = "Patient";
            this.DiagnosisPatient.FieldName = "Patient";
            this.DiagnosisPatient.Name = "DiagnosisPatient";
            this.DiagnosisPatient.OptionsColumn.AllowEdit = false;
            // 
            // DiagnosisDoctor
            // 
            this.DiagnosisDoctor.Caption = "Doctor";
            this.DiagnosisDoctor.FieldName = "Doctor";
            this.DiagnosisDoctor.Name = "DiagnosisDoctor";
            this.DiagnosisDoctor.OptionsColumn.AllowEdit = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // NameTE
            // 
            this.NameTE.Location = new System.Drawing.Point(547, 208);
            this.NameTE.Name = "NameTE";
            this.NameTE.Size = new System.Drawing.Size(160, 20);
            this.NameTE.TabIndex = 22;
            // 
            // DescriptionME
            // 
            this.DescriptionME.Location = new System.Drawing.Point(12, 162);
            this.DescriptionME.Name = "DescriptionME";
            this.DescriptionME.Size = new System.Drawing.Size(482, 121);
            this.DescriptionME.TabIndex = 21;
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
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
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
            // DiagnoseFormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 614);
            this.Controls.Add(this.DiagnosisGridControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTE);
            this.Controls.Add(this.DescriptionME);
            this.Controls.Add(this.ribbon);
            this.Name = "DiagnoseFormD";
            this.Ribbon = this.ribbon;
            this.Text = "DiagnoseFormD";
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl DiagnosisGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DiagnosisGridView;
        private DevExpress.XtraGrid.Columns.GridColumn DiagnosisID;
        private DevExpress.XtraGrid.Columns.GridColumn DiagnosisName;
        private DevExpress.XtraGrid.Columns.GridColumn DiagnosisDescription;
        private DevExpress.XtraGrid.Columns.GridColumn DiagnosisPatient;
        private DevExpress.XtraGrid.Columns.GridColumn DiagnosisDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit NameTE;
        private DevExpress.XtraEditors.MemoEdit DescriptionME;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem NewBarItem;
        private DevExpress.XtraBars.BarButtonItem EditBarItem;
        private DevExpress.XtraBars.BarButtonItem DeleteBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}