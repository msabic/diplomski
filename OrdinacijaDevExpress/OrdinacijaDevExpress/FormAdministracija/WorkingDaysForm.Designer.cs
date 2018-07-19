namespace OrdinacijaDevExpress
{
    partial class WorkingDaysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingDaysForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Odd_EvenCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Morning_AfternoonCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkingTimeGridControl = new DevExpress.XtraGrid.GridControl();
            this.WorkingTimeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odd_EvenCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Morning_AfternoonCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingTimeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingTimeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbon.Dock = System.Windows.Forms.DockStyle.None;
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
            this.ribbon.Size = new System.Drawing.Size(442, 143);
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
            // Odd_EvenCB
            // 
            this.Odd_EvenCB.EditValue = "Select";
            this.Odd_EvenCB.Location = new System.Drawing.Point(12, 172);
            this.Odd_EvenCB.MenuManager = this.ribbon;
            this.Odd_EvenCB.Name = "Odd_EvenCB";
            this.Odd_EvenCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Odd_EvenCB.Properties.Items.AddRange(new object[] {
            "Select",
            "Odd ( Neparni )",
            "Even ( Parni )"});
            this.Odd_EvenCB.Size = new System.Drawing.Size(100, 20);
            this.Odd_EvenCB.TabIndex = 2;
            // 
            // Morning_AfternoonCB
            // 
            this.Morning_AfternoonCB.EditValue = "Select";
            this.Morning_AfternoonCB.Location = new System.Drawing.Point(139, 172);
            this.Morning_AfternoonCB.MenuManager = this.ribbon;
            this.Morning_AfternoonCB.Name = "Morning_AfternoonCB";
            this.Morning_AfternoonCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Morning_AfternoonCB.Properties.Items.AddRange(new object[] {
            "Select",
            "Morning ( Jutro )",
            "Afternoon ( Posljepodne )"});
            this.Morning_AfternoonCB.Size = new System.Drawing.Size(100, 20);
            this.Morning_AfternoonCB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odd/Even";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morning/Afternoon";
            // 
            // WorkingTimeGridControl
            // 
            this.WorkingTimeGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkingTimeGridControl.Location = new System.Drawing.Point(0, 198);
            this.WorkingTimeGridControl.MainView = this.WorkingTimeGridView;
            this.WorkingTimeGridControl.MenuManager = this.ribbon;
            this.WorkingTimeGridControl.Name = "WorkingTimeGridControl";
            this.WorkingTimeGridControl.Size = new System.Drawing.Size(442, 246);
            this.WorkingTimeGridControl.TabIndex = 8;
            this.WorkingTimeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.WorkingTimeGridView});
            // 
            // WorkingTimeGridView
            // 
            this.WorkingTimeGridView.GridControl = this.WorkingTimeGridControl;
            this.WorkingTimeGridView.Name = "WorkingTimeGridView";
            this.WorkingTimeGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.WorkingTimeGridView_RowClick);
            // 
            // WorkingDaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 445);
            this.Controls.Add(this.WorkingTimeGridControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Morning_AfternoonCB);
            this.Controls.Add(this.Odd_EvenCB);
            this.Controls.Add(this.ribbon);
            this.Name = "WorkingDaysForm";
            this.Ribbon = this.ribbon;
            this.Text = "WorkingDaysForm";
            this.Deactivate += new System.EventHandler(this.WorkingDaysForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odd_EvenCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Morning_AfternoonCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingTimeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingTimeGridView)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit Odd_EvenCB;
        private DevExpress.XtraEditors.ComboBoxEdit Morning_AfternoonCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl WorkingTimeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView WorkingTimeGridView;
    }
}