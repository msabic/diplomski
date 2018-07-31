namespace OrdinacijaDevExpress.FormDoctor
{
    partial class ChangePAsswordFormDcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePAsswordFormDcs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeBTN = new DevExpress.XtraEditors.SimpleButton();
            this.ReTE = new System.Windows.Forms.TextBox();
            this.NewTE = new System.Windows.Forms.TextBox();
            this.OldTE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reenter password";
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.ChangeBTN.Image = ((System.Drawing.Image)(resources.GetObject("ChangeBTN.Image")));
            this.ChangeBTN.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ChangeBTN.Location = new System.Drawing.Point(107, 208);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(55, 50);
            this.ChangeBTN.TabIndex = 6;
            this.ChangeBTN.Click += new System.EventHandler(this.ChangeBTN_Click);
            // 
            // ReTE
            // 
            this.ReTE.Location = new System.Drawing.Point(61, 163);
            this.ReTE.Name = "ReTE";
            this.ReTE.PasswordChar = '*';
            this.ReTE.Size = new System.Drawing.Size(165, 21);
            this.ReTE.TabIndex = 3;
            // 
            // NewTE
            // 
            this.NewTE.Location = new System.Drawing.Point(61, 96);
            this.NewTE.Name = "NewTE";
            this.NewTE.PasswordChar = '*';
            this.NewTE.Size = new System.Drawing.Size(165, 21);
            this.NewTE.TabIndex = 2;
            // 
            // OldTE
            // 
            this.OldTE.Location = new System.Drawing.Point(61, 31);
            this.OldTE.Name = "OldTE";
            this.OldTE.PasswordChar = '*';
            this.OldTE.Size = new System.Drawing.Size(165, 21);
            this.OldTE.TabIndex = 1;
            // 
            // ChangePAsswordFormDcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ChangeBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReTE);
            this.Controls.Add(this.NewTE);
            this.Controls.Add(this.OldTE);
            this.Controls.Add(this.label1);
            this.Name = "ChangePAsswordFormDcs";
            this.Text = "ChangePAsswordFormDcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton ChangeBTN;
        private System.Windows.Forms.TextBox ReTE;
        private System.Windows.Forms.TextBox NewTE;
        private System.Windows.Forms.TextBox OldTE;
    }
}