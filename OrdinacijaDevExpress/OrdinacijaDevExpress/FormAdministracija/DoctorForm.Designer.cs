namespace OrdinacijaDevExpress
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.DoctorGridControl = new DevExpress.XtraGrid.GridControl();
            this.DoctorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DoctorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorWorkingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTE = new DevExpress.XtraEditors.TextEdit();
            this.SurnameTE = new DevExpress.XtraEditors.TextEdit();
            this.ContactTE = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTE = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DeleteDoctorBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.EditDoctorBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.NewDoctorBarItem = new DevExpress.XtraEditors.SimpleButton();
            this.WorkingTimeLE = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingTimeLE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorGridControl
            // 
            this.DoctorGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorGridControl.Location = new System.Drawing.Point(0, 133);
            this.DoctorGridControl.MainView = this.DoctorGridView;
            this.DoctorGridControl.Name = "DoctorGridControl";
            this.DoctorGridControl.Size = new System.Drawing.Size(632, 229);
            this.DoctorGridControl.TabIndex = 0;
            this.DoctorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DoctorGridView});
            // 
            // DoctorGridView
            // 
            this.DoctorGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DoctorID,
            this.DoctorName,
            this.DoctorSurname,
            this.DoctorEmail,
            this.DoctorPassword,
            this.DoctorContact,
            this.DoctorWorkingTime});
            this.DoctorGridView.GridControl = this.DoctorGridControl;
            this.DoctorGridView.Name = "DoctorGridView";
            this.DoctorGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.DoctorGridView_RowClick);
            this.DoctorGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.DoctorGridView_CustomColumnDisplayText);
            // 
            // DoctorID
            // 
            this.DoctorID.Caption = "ID";
            this.DoctorID.FieldName = "ID";
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.OptionsColumn.AllowEdit = false;
            // 
            // DoctorName
            // 
            this.DoctorName.Caption = "Name";
            this.DoctorName.FieldName = "Name";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.OptionsColumn.AllowEdit = false;
            this.DoctorName.Visible = true;
            this.DoctorName.VisibleIndex = 0;
            // 
            // DoctorSurname
            // 
            this.DoctorSurname.Caption = "Surname";
            this.DoctorSurname.FieldName = "Surname";
            this.DoctorSurname.Name = "DoctorSurname";
            this.DoctorSurname.OptionsColumn.AllowEdit = false;
            this.DoctorSurname.Visible = true;
            this.DoctorSurname.VisibleIndex = 1;
            // 
            // DoctorEmail
            // 
            this.DoctorEmail.Caption = "Email";
            this.DoctorEmail.FieldName = "Email";
            this.DoctorEmail.Name = "DoctorEmail";
            this.DoctorEmail.OptionsColumn.AllowEdit = false;
            this.DoctorEmail.Visible = true;
            this.DoctorEmail.VisibleIndex = 2;
            // 
            // DoctorPassword
            // 
            this.DoctorPassword.Caption = "Password";
            this.DoctorPassword.FieldName = "Password";
            this.DoctorPassword.Name = "DoctorPassword";
            this.DoctorPassword.OptionsColumn.AllowEdit = false;
            // 
            // DoctorContact
            // 
            this.DoctorContact.Caption = "Contact";
            this.DoctorContact.FieldName = "Contact";
            this.DoctorContact.Name = "DoctorContact";
            this.DoctorContact.OptionsColumn.AllowEdit = false;
            this.DoctorContact.Visible = true;
            this.DoctorContact.VisibleIndex = 4;
            // 
            // DoctorWorkingTime
            // 
            this.DoctorWorkingTime.Caption = "Working time";
            this.DoctorWorkingTime.FieldName = "Working_time";
            this.DoctorWorkingTime.Name = "DoctorWorkingTime";
            this.DoctorWorkingTime.OptionsColumn.AllowEdit = false;
            this.DoctorWorkingTime.Visible = true;
            this.DoctorWorkingTime.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(123, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(371, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            // 
            // NameTE
            // 
            this.NameTE.Location = new System.Drawing.Point(5, 107);
            this.NameTE.Name = "NameTE";
            this.NameTE.Size = new System.Drawing.Size(115, 20);
            this.NameTE.TabIndex = 4;
            // 
            // SurnameTE
            // 
            this.SurnameTE.Location = new System.Drawing.Point(126, 107);
            this.SurnameTE.Name = "SurnameTE";
            this.SurnameTE.Size = new System.Drawing.Size(115, 20);
            this.SurnameTE.TabIndex = 5;
            // 
            // ContactTE
            // 
            this.ContactTE.Location = new System.Drawing.Point(368, 107);
            this.ContactTE.Name = "ContactTE";
            this.ContactTE.Size = new System.Drawing.Size(115, 20);
            this.ContactTE.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(247, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // EmailTE
            // 
            this.EmailTE.Location = new System.Drawing.Point(247, 107);
            this.EmailTE.Name = "EmailTE";
            this.EmailTE.Size = new System.Drawing.Size(115, 20);
            this.EmailTE.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(489, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Working time";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.DeleteDoctorBarItem);
            this.groupControl1.Controls.Add(this.EditDoctorBarItem);
            this.groupControl1.Controls.Add(this.NewDoctorBarItem);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(632, 88);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Action";
            // 
            // DeleteDoctorBarItem
            // 
            this.DeleteDoctorBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteDoctorBarItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDoctorBarItem.Image")));
            this.DeleteDoctorBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteDoctorBarItem.Location = new System.Drawing.Point(104, 20);
            this.DeleteDoctorBarItem.Name = "DeleteDoctorBarItem";
            this.DeleteDoctorBarItem.Size = new System.Drawing.Size(51, 66);
            this.DeleteDoctorBarItem.TabIndex = 3;
            this.DeleteDoctorBarItem.Text = "Delete";
            this.DeleteDoctorBarItem.Click += new System.EventHandler(this.DeleteDoctorBarItem_Click);
            // 
            // EditDoctorBarItem
            // 
            this.EditDoctorBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditDoctorBarItem.Image = ((System.Drawing.Image)(resources.GetObject("EditDoctorBarItem.Image")));
            this.EditDoctorBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.EditDoctorBarItem.Location = new System.Drawing.Point(53, 20);
            this.EditDoctorBarItem.Name = "EditDoctorBarItem";
            this.EditDoctorBarItem.Size = new System.Drawing.Size(51, 66);
            this.EditDoctorBarItem.TabIndex = 1;
            this.EditDoctorBarItem.Text = "Edit";
            this.EditDoctorBarItem.Click += new System.EventHandler(this.EditDoctorBarItem_Click);
            // 
            // NewDoctorBarItem
            // 
            this.NewDoctorBarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewDoctorBarItem.Image = ((System.Drawing.Image)(resources.GetObject("NewDoctorBarItem.Image")));
            this.NewDoctorBarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewDoctorBarItem.Location = new System.Drawing.Point(2, 20);
            this.NewDoctorBarItem.Name = "NewDoctorBarItem";
            this.NewDoctorBarItem.Size = new System.Drawing.Size(51, 66);
            this.NewDoctorBarItem.TabIndex = 0;
            this.NewDoctorBarItem.Text = "New";
            this.NewDoctorBarItem.Click += new System.EventHandler(this.NewDoctorBarItem_Click);
            // 
            // WorkingTimeLE
            // 
            this.WorkingTimeLE.Location = new System.Drawing.Point(489, 107);
            this.WorkingTimeLE.Name = "WorkingTimeLE";
            this.WorkingTimeLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkingTimeLE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Odd_Even", "Odd_Even"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Morning_Afternoon", "Morning_Afternoon")});
            this.WorkingTimeLE.Properties.DisplayMember = "Odd_Even";
            this.WorkingTimeLE.Properties.ValueMember = "ID";
            this.WorkingTimeLE.Size = new System.Drawing.Size(100, 20);
            this.WorkingTimeLE.TabIndex = 12;
            // 
            // DoctorForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 361);
            this.Controls.Add(this.WorkingTimeLE);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContactTE);
            this.Controls.Add(this.SurnameTE);
            this.Controls.Add(this.NameTE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorGridControl);
            this.Name = "DoctorForm";
            this.Text = "Doctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.DoctorForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkingTimeLE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DoctorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DoctorGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit NameTE;
        private DevExpress.XtraEditors.TextEdit SurnameTE;
        private DevExpress.XtraEditors.TextEdit ContactTE;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit EmailTE;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton DeleteDoctorBarItem;
        private DevExpress.XtraEditors.SimpleButton EditDoctorBarItem;
        private DevExpress.XtraEditors.SimpleButton NewDoctorBarItem;
        private DevExpress.XtraEditors.LookUpEdit WorkingTimeLE;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorID;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorName;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorSurname;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorEmail;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorPassword;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorContact;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorWorkingTime;
    }
}