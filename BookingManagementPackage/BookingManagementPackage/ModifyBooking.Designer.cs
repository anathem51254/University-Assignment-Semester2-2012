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
            this.ServiceDetailsLbl = new System.Windows.Forms.Label();
            this.DateTimeLbl = new System.Windows.Forms.Label();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.BookingDetailsTxtBox = new System.Windows.Forms.TextBox();
            this.ServiceDetailsComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
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
            // ServiceDetailsComboBox
            // 
            this.ServiceDetailsComboBox.FormattingEnabled = true;
            this.ServiceDetailsComboBox.Items.AddRange(new object[] {
            "General Service",
            "Oil Change",
            "Tire Change",
            "Wheel Alignment",
            "Stereo Install",
            "Glass Replacement",
            "Light Replacement",
            "Battery Replacement",
            "Lock Change",
            "Spark Plug Replacement"});
            this.ServiceDetailsComboBox.Location = new System.Drawing.Point(96, 243);
            this.ServiceDetailsComboBox.Name = "ServiceDetailsComboBox";
            this.ServiceDetailsComboBox.Size = new System.Drawing.Size(155, 21);
            this.ServiceDetailsComboBox.TabIndex = 33;
            this.ServiceDetailsComboBox.Text = "General Service";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(96, 201);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(155, 20);
            this.DateTimePicker.TabIndex = 32;
            // 
            // ModifyBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 319);
            this.Controls.Add(this.ServiceDetailsComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.BookingDetailsTxtBox);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.ServiceDetailsLbl);
            this.Controls.Add(this.DateTimeLbl);
            this.Name = "ModifyBooking";
            this.Text = "ModifyBooking";
            this.Load += new System.EventHandler(this.ModifyBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceDetailsLbl;
        private System.Windows.Forms.Label DateTimeLbl;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.TextBox BookingDetailsTxtBox;
        private System.Windows.Forms.ComboBox ServiceDetailsComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}