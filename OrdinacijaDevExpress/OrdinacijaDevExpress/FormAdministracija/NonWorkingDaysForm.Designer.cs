namespace OrdinacijaDevExpress
{
    partial class NonWorkingDaysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonWorkingDaysForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DateMC = new System.Windows.Forms.MonthCalendar();
            this.NamteTE = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.NonWorkingDaysGridControl = new DevExpress.XtraGrid.GridControl();
            this.NonWorkingDaysGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamteTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonWorkingDaysGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonWorkingDaysGridView)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(619, 143);
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
            // DateMC
            // 
            this.DateMC.Location = new System.Drawing.Point(12, 210);
            this.DateMC.Name = "DateMC";
            this.DateMC.TabIndex = 2;
            // 
            // NamteTE
            // 
            this.NamteTE.Location = new System.Drawing.Point(12, 188);
            this.NamteTE.MenuManager = this.ribbon;
            this.NamteTE.Name = "NamteTE";
            this.NamteTE.Size = new System.Drawing.Size(199, 20);
            this.NamteTE.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name of  day";
            // 
            // NonWorkingDaysGridControl
            // 
            this.NonWorkingDaysGridControl.Location = new System.Drawing.Point(223, 145);
            this.NonWorkingDaysGridControl.MainView = this.NonWorkingDaysGridView;
            this.NonWorkingDaysGridControl.MenuManager = this.ribbon;
            this.NonWorkingDaysGridControl.Name = "NonWorkingDaysGridControl";
            this.NonWorkingDaysGridControl.Size = new System.Drawing.Size(384, 297);
            this.NonWorkingDaysGridControl.TabIndex = 5;
            this.NonWorkingDaysGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.NonWorkingDaysGridView});
            // 
            // NonWorkingDaysGridView
            // 
            this.NonWorkingDaysGridView.GridControl = this.NonWorkingDaysGridControl;
            this.NonWorkingDaysGridView.Name = "NonWorkingDaysGridView";
            this.NonWorkingDaysGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.NonWorkingDaysGridView_RowClick);
            // 
            // NonWorkingDaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 445);
            this.Controls.Add(this.NonWorkingDaysGridControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamteTE);
            this.Controls.Add(this.DateMC);
            this.Controls.Add(this.ribbon);
            this.Name = "NonWorkingDaysForm";
            this.Ribbon = this.ribbon;
            this.Text = "NonWorkingDaysForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamteTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonWorkingDaysGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonWorkingDaysGridView)).EndInit();
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
        private System.Windows.Forms.MonthCalendar DateMC;
        private DevExpress.XtraEditors.TextEdit NamteTE;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl NonWorkingDaysGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView NonWorkingDaysGridView;
    }
}