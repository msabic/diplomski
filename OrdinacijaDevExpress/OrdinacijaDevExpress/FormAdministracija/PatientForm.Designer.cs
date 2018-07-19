namespace OrdinacijaDevExpress
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DeletePatientBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.ChangePasswordPatientBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.EditPatientBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.NewPatientBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.NameTE = new DevExpress.XtraEditors.TextEdit();
            this.SurnameTE = new DevExpress.XtraEditors.TextEdit();
            this.EmailTE = new DevExpress.XtraEditors.TextEdit();
            this.ConactTE = new DevExpress.XtraEditors.TextEdit();
            this.DoctorLE = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PatientGridControl = new DevExpress.XtraGrid.GridControl();
            this.PatientGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PatientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConactTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.DeletePatientBarItem);
            this.groupControl1.Controls.Add(this.ChangePasswordPatientBarItem);
            this.groupControl1.Controls.Add(this.EditPatientBarItem);
            this.groupControl1.Controls.Add(this.NewPatientBarItem);
            this.groupControl1.Location = new System.Drawing.Point(1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(641, 90);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Action";
            // 
            // DeletePatientBarItem
            // 
            this.DeletePatientBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeletePatientBarItem.Image = ((System.Drawing.Image)(resources.GetObject("DeletePatientBarItem.Image")));
            this.DeletePatientBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeletePatientBarItem.Location = new System.Drawing.Point(160, 20);
            this.DeletePatientBarItem.Name = "DeletePatientBarItem";
            this.DeletePatientBarItem.Size = new System.Drawing.Size(51, 68);
            this.DeletePatientBarItem.TabIndex = 7;
            this.DeletePatientBarItem.Text = "Delete";
            this.DeletePatientBarItem.Click += new System.EventHandler(this.DeletePatientBarItem_Click);
            // 
            // ChangePasswordPatientBarItem
            // 
            this.ChangePasswordPatientBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChangePasswordPatientBarItem.Image = ((System.Drawing.Image)(resources.GetObject("ChangePasswordPatientBarItem.Image")));
            this.ChangePasswordPatientBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.ChangePasswordPatientBarItem.Location = new System.Drawing.Point(104, 20);
            this.ChangePasswordPatientBarItem.Name = "ChangePasswordPatientBarItem";
            this.ChangePasswordPatientBarItem.Size = new System.Drawing.Size(56, 68);
            this.ChangePasswordPatientBarItem.TabIndex = 6;
            this.ChangePasswordPatientBarItem.Text = "Change\r\npassword";
            // 
            // EditPatientBarItem
            // 
            this.EditPatientBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditPatientBarItem.Image = ((System.Drawing.Image)(resources.GetObject("EditPatientBarItem.Image")));
            this.EditPatientBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.EditPatientBarItem.Location = new System.Drawing.Point(53, 20);
            this.EditPatientBarItem.Name = "EditPatientBarItem";
            this.EditPatientBarItem.Size = new System.Drawing.Size(51, 68);
            this.EditPatientBarItem.TabIndex = 5;
            this.EditPatientBarItem.Text = "Edit";
            this.EditPatientBarItem.Click += new System.EventHandler(this.EditPatientBarItem_Click);
            // 
            // NewPatientBarItem
            // 
            this.NewPatientBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewPatientBarItem.Image = ((System.Drawing.Image)(resources.GetObject("NewPatientBarItem.Image")));
            this.NewPatientBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewPatientBarItem.Location = new System.Drawing.Point(2, 20);
            this.NewPatientBarItem.Name = "NewPatientBarItem";
            this.NewPatientBarItem.Size = new System.Drawing.Size(51, 68);
            this.NewPatientBarItem.TabIndex = 4;
            this.NewPatientBarItem.Text = "New";
            this.NewPatientBarItem.Click += new System.EventHandler(this.NewPatientBarItem_Click);
            // 
            // NameTE
            // 
            this.NameTE.Location = new System.Drawing.Point(9, 116);
            this.NameTE.Name = "NameTE";
            this.NameTE.Size = new System.Drawing.Size(100, 20);
            this.NameTE.TabIndex = 1;
            // 
            // SurnameTE
            // 
            this.SurnameTE.Location = new System.Drawing.Point(115, 116);
            this.SurnameTE.Name = "SurnameTE";
            this.SurnameTE.Size = new System.Drawing.Size(100, 20);
            this.SurnameTE.TabIndex = 2;
            // 
            // EmailTE
            // 
            this.EmailTE.Location = new System.Drawing.Point(221, 116);
            this.EmailTE.Name = "EmailTE";
            this.EmailTE.Size = new System.Drawing.Size(100, 20);
            this.EmailTE.TabIndex = 3;
            // 
            // ConactTE
            // 
            this.ConactTE.Location = new System.Drawing.Point(327, 116);
            this.ConactTE.Name = "ConactTE";
            this.ConactTE.Size = new System.Drawing.Size(100, 20);
            this.ConactTE.TabIndex = 4;
            // 
            // DoctorLE
            // 
            this.DoctorLE.Location = new System.Drawing.Point(433, 116);
            this.DoctorLE.Name = "DoctorLE";
            this.DoctorLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DoctorLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Surname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.DoctorLE.Size = new System.Drawing.Size(100, 20);
            this.DoctorLE.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doctor";
            // 
            // PatientGridControl
            // 
            this.PatientGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientGridControl.Location = new System.Drawing.Point(1, 157);
            this.PatientGridControl.MainView = this.PatientGridView;
            this.PatientGridControl.Name = "PatientGridControl";
            this.PatientGridControl.Size = new System.Drawing.Size(640, 169);
            this.PatientGridControl.TabIndex = 11;
            this.PatientGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PatientGridView});
            // 
            // PatientGridView
            // 
            this.PatientGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PatientID,
            this.PatientName,
            this.PatientSurname,
            this.PatientEmail,
            this.PatientContact,
            this.PatientDoctor});
            this.PatientGridView.GridControl = this.PatientGridControl;
            this.PatientGridView.Name = "PatientGridView";
            this.PatientGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.PatientGridView_RowClick);
            this.PatientGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.PatientGridView_CustomColumnDisplayText);
            // 
            // PatientID
            // 
            this.PatientID.Caption = "ID";
            this.PatientID.FieldName = "ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.OptionsColumn.AllowEdit = false;
            // 
            // PatientName
            // 
            this.PatientName.Caption = "Name";
            this.PatientName.FieldName = "Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.OptionsColumn.AllowEdit = false;
            this.PatientName.Visible = true;
            this.PatientName.VisibleIndex = 0;
            // 
            // PatientSurname
            // 
            this.PatientSurname.Caption = "Surname";
            this.PatientSurname.FieldName = "Surname";
            this.PatientSurname.Name = "PatientSurname";
            this.PatientSurname.OptionsColumn.AllowEdit = false;
            this.PatientSurname.Visible = true;
            this.PatientSurname.VisibleIndex = 1;
            // 
            // PatientEmail
            // 
            this.PatientEmail.Caption = "Email";
            this.PatientEmail.FieldName = "Email";
            this.PatientEmail.Name = "PatientEmail";
            this.PatientEmail.OptionsColumn.AllowEdit = false;
            this.PatientEmail.Visible = true;
            this.PatientEmail.VisibleIndex = 2;
            // 
            // PatientContact
            // 
            this.PatientContact.Caption = "Contact";
            this.PatientContact.FieldName = "Contact";
            this.PatientContact.Name = "PatientContact";
            this.PatientContact.OptionsColumn.AllowEdit = false;
            this.PatientContact.Visible = true;
            this.PatientContact.VisibleIndex = 3;
            // 
            // PatientDoctor
            // 
            this.PatientDoctor.Caption = "Doctor";
            this.PatientDoctor.FieldName = "Doctor";
            this.PatientDoctor.Name = "PatientDoctor";
            this.PatientDoctor.OptionsColumn.AllowEdit = false;
            this.PatientDoctor.Visible = true;
            this.PatientDoctor.VisibleIndex = 4;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 327);
            this.Controls.Add(this.PatientGridControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorLE);
            this.Controls.Add(this.ConactTE);
            this.Controls.Add(this.EmailTE);
            this.Controls.Add(this.SurnameTE);
            this.Controls.Add(this.NameTE);
            this.Controls.Add(this.groupControl1);
            this.Name = "PatientForm";
            this.Text = "Patient";
            this.Deactivate += new System.EventHandler(this.PatientForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConactTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton DeletePatientBarItem;
        private DevExpress.XtraEditors.SimpleButton ChangePasswordPatientBarItem;
        private DevExpress.XtraEditors.SimpleButton EditPatientBarItem;
        private DevExpress.XtraEditors.SimpleButton NewPatientBarItem;
        private DevExpress.XtraEditors.TextEdit NameTE;
        private DevExpress.XtraEditors.TextEdit SurnameTE;
        private DevExpress.XtraEditors.TextEdit EmailTE;
        private DevExpress.XtraEditors.TextEdit ConactTE;
        private DevExpress.XtraEditors.LookUpEdit DoctorLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl PatientGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PatientGridView;
        private DevExpress.XtraGrid.Columns.GridColumn PatientID;
        private DevExpress.XtraGrid.Columns.GridColumn PatientName;
        private DevExpress.XtraGrid.Columns.GridColumn PatientSurname;
        private DevExpress.XtraGrid.Columns.GridColumn PatientEmail;
        private DevExpress.XtraGrid.Columns.GridColumn PatientContact;
        private DevExpress.XtraGrid.Columns.GridColumn PatientDoctor;
    }
}