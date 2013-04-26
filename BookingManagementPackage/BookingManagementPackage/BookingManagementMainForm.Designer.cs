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
            this.dateTimeTxtBox = new System.Windows.Forms.TextBox();
            this.serviceDetailsTxtBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.textBtn = new System.Windows.Forms.Button();
            this.BookingDetailsTxtBox = new System.Windows.Forms.TextBox();
            this.modifyBookingBtn = new System.Windows.Forms.Button();
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
            this.ServiceDetailsLbl.Location = new System.Drawing.Point(37, 366);
            this.ServiceDetailsLbl.Name = "ServiceDetailsLbl";
            this.ServiceDetailsLbl.Size = new System.Drawing.Size(78, 13);
            this.ServiceDetailsLbl.TabIndex = 13;
            this.ServiceDetailsLbl.Text = "Service Details";
            // 
            // dateTimeTxtBox
            // 
            this.dateTimeTxtBox.Location = new System.Drawing.Point(160, 319);
            this.dateTimeTxtBox.MaxLength = 24;
            this.dateTimeTxtBox.Name = "dateTimeTxtBox";
            this.dateTimeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTxtBox.TabIndex = 18;
            // 
            // serviceDetailsTxtBox
            // 
            this.serviceDetailsTxtBox.Location = new System.Drawing.Point(160, 363);
            this.serviceDetailsTxtBox.MaxLength = 32;
            this.serviceDetailsTxtBox.Name = "serviceDetailsTxtBox";
            this.serviceDetailsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.serviceDetailsTxtBox.TabIndex = 19;
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
            // textBtn
            // 
            this.textBtn.Location = new System.Drawing.Point(349, 400);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(75, 23);
            this.textBtn.TabIndex = 25;
            this.textBtn.Text = "Test";
            this.textBtn.UseVisualStyleBackColor = true;
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
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
            // BookingManagementMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 435);
            this.Controls.Add(this.modifyBookingBtn);
            this.Controls.Add(this.BookingDetailsTxtBox);
            this.Controls.Add(this.textBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.serviceDetailsTxtBox);
            this.Controls.Add(this.dateTimeTxtBox);
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
        private System.Windows.Forms.TextBox dateTimeTxtBox;
        private System.Windows.Forms.TextBox serviceDetailsTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button textBtn;
        private System.Windows.Forms.TextBox BookingDetailsTxtBox;
        private System.Windows.Forms.Button modifyBookingBtn;
    }
}