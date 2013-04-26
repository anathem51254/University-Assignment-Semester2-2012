namespace BookingManagementPackage
{
    partial class ModifyBooking
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
            this.serviceDetailsTxtBox = new System.Windows.Forms.TextBox();
            this.dateTimeTxtBox = new System.Windows.Forms.TextBox();
            this.ServiceDetailsLbl = new System.Windows.Forms.Label();
            this.DateTimeLbl = new System.Windows.Forms.Label();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.BookingDetailsTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serviceDetailsTxtBox
            // 
            this.serviceDetailsTxtBox.Location = new System.Drawing.Point(135, 245);
            this.serviceDetailsTxtBox.MaxLength = 32;
            this.serviceDetailsTxtBox.Name = "serviceDetailsTxtBox";
            this.serviceDetailsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.serviceDetailsTxtBox.TabIndex = 23;
            // 
            // dateTimeTxtBox
            // 
            this.dateTimeTxtBox.Location = new System.Drawing.Point(135, 201);
            this.dateTimeTxtBox.MaxLength = 24;
            this.dateTimeTxtBox.Name = "dateTimeTxtBox";
            this.dateTimeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTxtBox.TabIndex = 22;
            // 
            // ServiceDetailsLbl
            // 
            this.ServiceDetailsLbl.AutoSize = true;
            this.ServiceDetailsLbl.Location = new System.Drawing.Point(12, 248);
            this.ServiceDetailsLbl.Name = "ServiceDetailsLbl";
            this.ServiceDetailsLbl.Size = new System.Drawing.Size(78, 13);
            this.ServiceDetailsLbl.TabIndex = 21;
            this.ServiceDetailsLbl.Text = "Service Details";
            // 
            // DateTimeLbl
            // 
            this.DateTimeLbl.AutoSize = true;
            this.DateTimeLbl.Location = new System.Drawing.Point(13, 204);
            this.DateTimeLbl.Name = "DateTimeLbl";
            this.DateTimeLbl.Size = new System.Drawing.Size(77, 13);
            this.DateTimeLbl.TabIndex = 20;
            this.DateTimeLbl.Text = "Date and Time";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(55, 284);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(155, 23);
            this.saveChangesBtn.TabIndex = 25;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // BookingDetailsTxtBox
            // 
            this.BookingDetailsTxtBox.Location = new System.Drawing.Point(12, 12);
            this.BookingDetailsTxtBox.Multiline = true;
            this.BookingDetailsTxtBox.Name = "BookingDetailsTxtBox";
            this.BookingDetailsTxtBox.ReadOnly = true;
            this.BookingDetailsTxtBox.Size = new System.Drawing.Size(236, 183);
            this.BookingDetailsTxtBox.TabIndex = 27;
            // 
            // ModifyBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 319);
            this.Controls.Add(this.BookingDetailsTxtBox);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.serviceDetailsTxtBox);
            this.Controls.Add(this.dateTimeTxtBox);
            this.Controls.Add(this.ServiceDetailsLbl);
            this.Controls.Add(this.DateTimeLbl);
            this.Name = "ModifyBooking";
            this.Text = "ModifyBooking";
            this.Load += new System.EventHandler(this.ModifyBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serviceDetailsTxtBox;
        private System.Windows.Forms.TextBox dateTimeTxtBox;
        private System.Windows.Forms.Label ServiceDetailsLbl;
        private System.Windows.Forms.Label DateTimeLbl;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.TextBox BookingDetailsTxtBox;
    }
}