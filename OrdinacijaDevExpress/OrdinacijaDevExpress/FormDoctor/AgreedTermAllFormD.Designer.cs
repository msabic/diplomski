namespace OrdinacijaDevExpress.FormDoctor
{
    partial class AgreedTermAllFormD
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
            this.AgreedTermGridControl = new DevExpress.XtraGrid.GridControl();
            this.AgreedTermGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AgreedTermID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgreedTermDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AgreedTermGridControl
            // 
            this.AgreedTermGridControl.Location = new System.Drawing.Point(-1, 2);
            this.AgreedTermGridControl.MainView = this.AgreedTermGridView;
            this.AgreedTermGridControl.Name = "AgreedTermGridControl";
            this.AgreedTermGridControl.Size = new System.Drawing.Size(606, 457);
            this.AgreedTermGridControl.TabIndex = 1;
            this.AgreedTermGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.AgreedTermGridView});
            this.AgreedTermGridControl.Click += new System.EventHandler(this.AgreedTermGridControl_Click);
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
            this.AgreedTermGridView.OptionsView.ShowAutoFilterRow = true;
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
            // 
            // AgreedTermAllFormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 460);
            this.Controls.Add(this.AgreedTermGridControl);
            this.Name = "AgreedTermAllFormD";
            this.Text = "AgreedTermAllFormD";
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgreedTermGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl AgreedTermGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView AgreedTermGridView;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermID;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermDate;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermTime;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermPatient;
        private DevExpress.XtraGrid.Columns.GridColumn AgreedTermDoctor;
    }
}