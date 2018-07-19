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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FatherNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotherNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCIDTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientInfoGridView)).BeginInit();
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
            this.RelationshipStatusCB.Location = new System.Drawing.Point(11, 144);
            this.RelationshipStatusCB.Name = "RelationshipStatusCB";
            this.RelationshipStatusCB.Size = new System.Drawing.Size(81, 17);
            this.RelationshipStatusCB.TabIndex = 15;
            this.RelationshipStatusCB.Text = "In marriage";
            this.RelationshipStatusCB.UseVisualStyleBackColor = true;
            // 
            // SmokerCE
            // 
            this.SmokerCE.AutoSize = true;
            this.SmokerCE.Location = new System.Drawing.Point(161, 144);
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
            this.PatientInfoGridView.GridControl = this.PatientInfoGridControl;
            this.PatientInfoGridView.Name = "PatientInfoGridView";
            this.PatientInfoGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.PatientInfoGridView_RowClick);
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 445);
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
    }
}