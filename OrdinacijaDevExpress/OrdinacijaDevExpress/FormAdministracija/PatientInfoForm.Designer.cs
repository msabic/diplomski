namespace OrdinacijaDevExpress
{
    partial class PatientInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfoForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.EditBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.NewBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.FatherNameTE = new DevExpress.XtraEditors.TextEdit();
            this.MotherNameTE = new DevExpress.XtraEditors.TextEdit();
            this.AddressTE = new DevExpress.XtraEditors.TextEdit();
            this.PhoneTE = new DevExpress.XtraEditors.TextEdit();
            this.MobileTE = new DevExpress.XtraEditors.TextEdit();
            this.UCIDTE = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RelationshipStatusCB = new System.Windows.Forms.CheckBox();
            this.SmokerCE = new System.Windows.Forms.CheckBox();
            this.PatientInfoGridControl = new DevExpress.XtraGrid.GridControl();
            this.PatientInfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PatientLE = new DevExpress.XtraEditors.LookUpEdit();
            this.PatientInfoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoFatherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoMotherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoUCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoRS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoSmoker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientInfoPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FatherNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotherNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCIDTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DeleteBarItem);
            this.groupBox1.Controls.Add(this.EditBarItem);
            this.groupBox1.Controls.Add(this.NewBarItem);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // DeleteBarItem
            // 
            this.DeleteBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteBarItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBarItem.Image")));
            this.DeleteBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteBarItem.Location = new System.Drawing.Point(105, 17);
            this.DeleteBarItem.Name = "DeleteBarItem";
            this.DeleteBarItem.Size = new System.Drawing.Size(51, 59);
            this.DeleteBarItem.TabIndex = 10;
            this.DeleteBarItem.Text = "Delete";
            this.DeleteBarItem.Click += new System.EventHandler(this.DeleteBarItem_Click);
            // 
            // EditBarItem
            // 
            this.EditBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditBarItem.Image = ((System.Drawing.Image)(resources.GetObject("EditBarItem.Image")));
            this.EditBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.EditBarItem.Location = new System.Drawing.Point(54, 17);
            this.EditBarItem.Name = "EditBarItem";
            this.EditBarItem.Size = new System.Drawing.Size(51, 59);
            this.EditBarItem.TabIndex = 9;
            this.EditBarItem.Text = "Edit";
            this.EditBarItem.Click += new System.EventHandler(this.EditBarItem_Click);
            // 
            // NewBarItem
            // 
            this.NewBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewBarItem.Image = ((System.Drawing.Image)(resources.GetObject("NewBarItem.Image")));
            this.NewBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewBarItem.Location = new System.Drawing.Point(3, 17);
            this.NewBarItem.Name = "NewBarItem";
            this.NewBarItem.Size = new System.Drawing.Size(51, 59);
            this.NewBarItem.TabIndex = 8;
            this.NewBarItem.Text = "New";
            this.NewBarItem.Click += new System.EventHandler(this.NewBarItem_Click);
            // 
            // FatherNameTE
            // 
            this.FatherNameTE.Location = new System.Drawing.Point(11, 108);
            this.FatherNameTE.Name = "FatherNameTE";
            this.FatherNameTE.Size = new System.Drawing.Size(144, 20);
            this.FatherNameTE.TabIndex = 3;
            // 
            // MotherNameTE
            // 
            this.MotherNameTE.Location = new System.Drawing.Point(161, 108);
            this.MotherNameTE.Name = "MotherNameTE";
            this.MotherNameTE.Size = new System.Drawing.Size(144, 20);
            this.MotherNameTE.TabIndex = 4;
            // 
            // AddressTE
            // 
            this.AddressTE.Location = new System.Drawing.Point(311, 108);
            this.AddressTE.Name = "AddressTE";
            this.AddressTE.Size = new System.Drawing.Size(144, 20);
            this.AddressTE.TabIndex = 5;
            // 
            // PhoneTE
            // 
            this.PhoneTE.Location = new System.Drawing.Point(461, 108);
            this.PhoneTE.Name = "PhoneTE";
            this.PhoneTE.Size = new System.Drawing.Size(144, 20);
            this.PhoneTE.TabIndex = 6;
            // 
            // MobileTE
            // 
            this.MobileTE.Location = new System.Drawing.Point(611, 108);
            this.MobileTE.Name = "MobileTE";
            this.MobileTE.Size = new System.Drawing.Size(144, 20);
            this.MobileTE.TabIndex = 7;
            // 
            // UCIDTE
            // 
            this.UCIDTE.Location = new System.Drawing.Point(761, 108);
            this.UCIDTE.Name = "UCIDTE";
            this.UCIDTE.Size = new System.Drawing.Size(144, 20);
            this.UCIDTE.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Father name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mother name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mobile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "UCID";
            // 
            // RelationshipStatusCB
            // 
            this.RelationshipStatusCB.AutoSize = true;
            this.RelationshipStatusCB.Location = new System.Drawing.Point(161, 144);
            this.RelationshipStatusCB.Name = "RelationshipStatusCB";
            this.RelationshipStatusCB.Size = new System.Drawing.Size(81, 17);
            this.RelationshipStatusCB.TabIndex = 15;
            this.RelationshipStatusCB.Text = "In marriage";
            this.RelationshipStatusCB.UseVisualStyleBackColor = true;
            // 
            // SmokerCE
            // 
            this.SmokerCE.AutoSize = true;
            this.SmokerCE.Location = new System.Drawing.Point(311, 144);
            this.SmokerCE.Name = "SmokerCE";
            this.SmokerCE.Size = new System.Drawing.Size(61, 17);
            this.SmokerCE.TabIndex = 16;
            this.SmokerCE.Text = "Smoker";
            this.SmokerCE.UseVisualStyleBackColor = true;
            // 
            // PatientInfoGridControl
            // 
            this.PatientInfoGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientInfoGridControl.Location = new System.Drawing.Point(0, 167);
            this.PatientInfoGridControl.MainView = this.PatientInfoGridView;
            this.PatientInfoGridControl.Name = "PatientInfoGridControl";
            this.PatientInfoGridControl.Size = new System.Drawing.Size(918, 283);
            this.PatientInfoGridControl.TabIndex = 17;
            this.PatientInfoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PatientInfoGridView});
            // 
            // PatientInfoGridView
            // 
            this.PatientInfoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PatientInfoID,
            this.PatientInfoFatherName,
            this.PatientInfoMotherName,
            this.PatientInfoAddress,
            this.PatientInfoPhone,
            this.PatientInfoMobile,
            this.PatientInfoUCID,
            this.PatientInfoRS,
            this.PatientInfoSmoker,
            this.PatientInfoPatient});
            this.PatientInfoGridView.GridControl = this.PatientInfoGridControl;
            this.PatientInfoGridView.Name = "PatientInfoGridView";
            this.PatientInfoGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.PatientInfoGridView_RowClick);
            this.PatientInfoGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.PatientInfoGridView_CustomColumnDisplayText);
            // 
            // PatientLE
            // 
            this.PatientLE.Location = new System.Drawing.Point(11, 142);
            this.PatientLE.Name = "PatientLE";
            this.PatientLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PatientLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name1", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname")});
            this.PatientLE.Size = new System.Drawing.Size(144, 20);
            this.PatientLE.TabIndex = 18;
            // 
            // PatientInfoID
            // 
            this.PatientInfoID.Caption = "ID";
            this.PatientInfoID.FieldName = "ID";
            this.PatientInfoID.Name = "PatientInfoID";
            this.PatientInfoID.OptionsColumn.AllowEdit = false;
            // 
            // PatientInfoFatherName
            // 
            this.PatientInfoFatherName.Caption = "Father name";
            this.PatientInfoFatherName.FieldName = "Father_name";
            this.PatientInfoFatherName.Name = "PatientInfoFatherName";
            this.PatientInfoFatherName.OptionsColumn.AllowEdit = false;
            this.PatientInfoFatherName.Visible = true;
            this.PatientInfoFatherName.VisibleIndex = 0;
            // 
            // PatientInfoMotherName
            // 
            this.PatientInfoMotherName.Caption = "Mother name";
            this.PatientInfoMotherName.FieldName = "Mother_name";
            this.PatientInfoMotherName.Name = "PatientInfoMotherName";
            this.PatientInfoMotherName.OptionsColumn.AllowEdit = false;
            this.PatientInfoMotherName.Visible = true;
            this.PatientInfoMotherName.VisibleIndex = 1;
            // 
            // PatientInfoAddress
            // 
            this.PatientInfoAddress.Caption = "Address";
            this.PatientInfoAddress.FieldName = "Address";
            this.PatientInfoAddress.Name = "PatientInfoAddress";
            this.PatientInfoAddress.OptionsColumn.AllowEdit = false;
            this.PatientInfoAddress.Visible = true;
            this.PatientInfoAddress.VisibleIndex = 2;
            // 
            // PatientInfoPhone
            // 
            this.PatientInfoPhone.Caption = "Phone";
            this.PatientInfoPhone.FieldName = "Phone";
            this.PatientInfoPhone.Name = "PatientInfoPhone";
            this.PatientInfoPhone.OptionsColumn.AllowEdit = false;
            this.PatientInfoPhone.Visible = true;
            this.PatientInfoPhone.VisibleIndex = 3;
            // 
            // PatientInfoMobile
            // 
            this.PatientInfoMobile.Caption = "Mobile";
            this.PatientInfoMobile.FieldName = "Mobile";
            this.PatientInfoMobile.Name = "PatientInfoMobile";
            this.PatientInfoMobile.OptionsColumn.AllowEdit = false;
            this.PatientInfoMobile.Visible = true;
            this.PatientInfoMobile.VisibleIndex = 4;
            // 
            // PatientInfoUCID
            // 
            this.PatientInfoUCID.Caption = "UCID";
            this.PatientInfoUCID.FieldName = "UCID";
            this.PatientInfoUCID.Name = "PatientInfoUCID";
            this.PatientInfoUCID.OptionsColumn.AllowEdit = false;
            this.PatientInfoUCID.Visible = true;
            this.PatientInfoUCID.VisibleIndex = 5;
            // 
            // PatientInfoRS
            // 
            this.PatientInfoRS.Caption = "Relationship status";
            this.PatientInfoRS.FieldName = "Relationship_status";
            this.PatientInfoRS.Name = "PatientInfoRS";
            this.PatientInfoRS.OptionsColumn.AllowEdit = false;
            this.PatientInfoRS.Visible = true;
            this.PatientInfoRS.VisibleIndex = 6;
            // 
            // PatientInfoSmoker
            // 
            this.PatientInfoSmoker.Caption = "Smoker";
            this.PatientInfoSmoker.FieldName = "Smoker";
            this.PatientInfoSmoker.Name = "PatientInfoSmoker";
            this.PatientInfoSmoker.OptionsColumn.AllowEdit = false;
            this.PatientInfoSmoker.Visible = true;
            this.PatientInfoSmoker.VisibleIndex = 7;
            // 
            // PatientInfoPatient
            // 
            this.PatientInfoPatient.Caption = "Patient";
            this.PatientInfoPatient.FieldName = "Patient";
            this.PatientInfoPatient.Name = "PatientInfoPatient";
            this.PatientInfoPatient.OptionsColumn.AllowEdit = false;
            this.PatientInfoPatient.Visible = true;
            this.PatientInfoPatient.VisibleIndex = 8;
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 445);
            this.Controls.Add(this.PatientLE);
            this.Controls.Add(this.PatientInfoGridControl);
            this.Controls.Add(this.SmokerCE);
            this.Controls.Add(this.RelationshipStatusCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UCIDTE);
            this.Controls.Add(this.MobileTE);
            this.Controls.Add(this.PhoneTE);
            this.Controls.Add(this.AddressTE);
            this.Controls.Add(this.MotherNameTE);
            this.Controls.Add(this.FatherNameTE);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientInfoForm";
            this.Text = "PatientInfoForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FatherNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotherNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCIDTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton DeleteBarItem;
        private DevExpress.XtraEditors.SimpleButton EditBarItem;
        private DevExpress.XtraEditors.SimpleButton NewBarItem;
        private DevExpress.XtraEditors.TextEdit FatherNameTE;
        private DevExpress.XtraEditors.TextEdit MotherNameTE;
        private DevExpress.XtraEditors.TextEdit AddressTE;
        private DevExpress.XtraEditors.TextEdit PhoneTE;
        private DevExpress.XtraEditors.TextEdit MobileTE;
        private DevExpress.XtraEditors.TextEdit UCIDTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox RelationshipStatusCB;
        private System.Windows.Forms.CheckBox SmokerCE;
        private DevExpress.XtraGrid.GridControl PatientInfoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PatientInfoGridView;
        private DevExpress.XtraEditors.LookUpEdit PatientLE;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoID;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoFatherName;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoMotherName;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoAddress;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoPhone;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoMobile;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoUCID;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoRS;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoSmoker;
        private DevExpress.XtraGrid.Columns.GridColumn PatientInfoPatient;
    }
}