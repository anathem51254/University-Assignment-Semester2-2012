namespace BookingManagementPackage
{
    partial class BookingManagementMainForm
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.bookingIdTxtBox = new System.Windows.Forms.TextBox();
            this.bookingIdLbl = new System.Windows.Forms.Label();
            this.DateTimeLbl = new System.Windows.Forms.Label();
            this.ServiceDetailsLbl = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.BookingDetailsTxtBox = new System.Windows.Forms.TextBox();
            this.modifyBookingBtn = new System.Windows.Forms.Button();
            this.deleteBookingBtn = new System.Windows.Forms.Button();
            this.autoCreateBtn = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ServiceDetailsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(266, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bookingIdTxtBox
            // 
            this.bookingIdTxtBox.Location = new System.Drawing.Point(160, 22);
            this.bookingIdTxtBox.MaxLength = 8;
            this.bookingIdTxtBox.Name = "bookingIdTxtBox";
            this.bookingIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bookingIdTxtBox.TabIndex = 1;
            // 
            // bookingIdLbl
            // 
            this.bookingIdLbl.AutoSize = true;
            this.bookingIdLbl.Location = new System.Drawing.Point(96, 25);
            this.bookingIdLbl.Name = "bookingIdLbl";
            this.bookingIdLbl.Size = new System.Drawing.Size(58, 13);
            this.bookingIdLbl.TabIndex = 3;
            this.bookingIdLbl.Text = "Booking Id";
            // 
            // DateTimeLbl
            // 
            this.DateTimeLbl.AutoSize = true;
            this.DateTimeLbl.Location = new System.Drawing.Point(38, 322);
            this.DateTimeLbl.Name = "DateTimeLbl";
            this.DateTimeLbl.Size = new System.Drawing.Size(77, 13);
            this.DateTimeLbl.TabIndex = 12;
            this.DateTimeLbl.Text = "Date and Time";
            // 
            // ServiceDetailsLbl
            // 
            this.ServiceDetailsLbl.AutoSize = true;
            this.ServiceDetailsLbl.Location = new System.Drawing.Point(37, 361);
            this.ServiceDetailsLbl.Name = "ServiceDetailsLbl";
            this.ServiceDetailsLbl.Size = new System.Drawing.Size(78, 13);
            this.ServiceDetailsLbl.TabIndex = 13;
            this.ServiceDetailsLbl.Text = "Service Details";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(80, 400);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(155, 23);
            this.createBtn.TabIndex = 24;
            this.createBtn.Text = "Create Booking";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // BookingDetailsTxtBox
            // 
            this.BookingDetailsTxtBox.Location = new System.Drawing.Point(99, 68);
            this.BookingDetailsTxtBox.Multiline = true;
            this.BookingDetailsTxtBox.Name = "BookingDetailsTxtBox";
            this.BookingDetailsTxtBox.ReadOnly = true;
            this.BookingDetailsTxtBox.Size = new System.Drawing.Size(242, 224);
            this.BookingDetailsTxtBox.TabIndex = 26;
            // 
            // modifyBookingBtn
            // 
            this.modifyBookingBtn.Location = new System.Drawing.Point(347, 255);
            this.modifyBookingBtn.Name = "modifyBookingBtn";
            this.modifyBookingBtn.Size = new System.Drawing.Size(75, 37);
            this.modifyBookingBtn.TabIndex = 27;
            this.modifyBookingBtn.Text = "Modify Booking";
            this.modifyBookingBtn.UseVisualStyleBackColor = true;
            this.modifyBookingBtn.Click += new System.EventHandler(this.modifyBookingBtn_Click);
            // 
            // deleteBookingBtn
            // 
            this.deleteBookingBtn.Location = new System.Drawing.Point(347, 22);
            this.deleteBookingBtn.Name = "deleteBookingBtn";
            this.deleteBookingBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBookingBtn.TabIndex = 28;
            this.deleteBookingBtn.Text = "Delete";
            this.deleteBookingBtn.UseVisualStyleBackColor = true;
            this.deleteBookingBtn.Click += new System.EventHandler(this.deleteBookingBtn_Click);
            // 
            // autoCreateBtn
            // 
            this.autoCreateBtn.Location = new System.Drawing.Point(283, 400);
            this.autoCreateBtn.Name = "autoCreateBtn";
            this.autoCreateBtn.Size = new System.Drawing.Size(149, 23);
            this.autoCreateBtn.TabIndex = 29;
            this.autoCreateBtn.Text = "Auto Create Bookings";
            this.autoCreateBtn.UseVisualStyleBackColor = true;
            this.autoCreateBtn.Click += new System.EventHandler(this.autoCreateBtn_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(121, 316);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(155, 20);
            this.DateTimePicker.TabIndex = 30;
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
            this.ServiceDetailsComboBox.Location = new System.Drawing.Point(121, 358);
            this.ServiceDetailsComboBox.Name = "ServiceDetailsComboBox";
            this.ServiceDetailsComboBox.Size = new System.Drawing.Size(155, 21);
            this.ServiceDetailsComboBox.TabIndex = 31;
            this.ServiceDetailsComboBox.Text = "General Service";
            // 
            // BookingManagementMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 435);
            this.Controls.Add(this.ServiceDetailsComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.autoCreateBtn);
            this.Controls.Add(this.deleteBookingBtn);
            this.Controls.Add(this.modifyBookingBtn);
            this.Controls.Add(this.BookingDetailsTxtBox);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.ServiceDetailsLbl);
            this.Controls.Add(this.DateTimeLbl);
            this.Controls.Add(this.bookingIdLbl);
            this.Controls.Add(this.bookingIdTxtBox);
            this.Controls.Add(this.searchBtn);
            this.Name = "BookingManagementMainForm";
            this.Text = "Booking Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox bookingIdTxtBox;
        private System.Windows.Forms.Label bookingIdLbl;
        private System.Windows.Forms.Label DateTimeLbl;
        private System.Windows.Forms.Label ServiceDetailsLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox BookingDetailsTxtBox;
        private System.Windows.Forms.Button modifyBookingBtn;
        private System.Windows.Forms.Button deleteBookingBtn;
        private System.Windows.Forms.Button autoCreateBtn;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ComboBox ServiceDetailsComboBox;
    }
}