namespace ARMS
{
    partial class StartPage
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
            this.adminMngSysBtn = new System.Windows.Forms.Button();
            this.bookinMngBtn = new System.Windows.Forms.Button();
            this.btnCMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminMngSysBtn
            // 
            this.adminMngSysBtn.Location = new System.Drawing.Point(127, 60);
            this.adminMngSysBtn.Name = "adminMngSysBtn";
            this.adminMngSysBtn.Size = new System.Drawing.Size(117, 46);
            this.adminMngSysBtn.TabIndex = 0;
            this.adminMngSysBtn.Text = "Administration Management system";
            this.adminMngSysBtn.UseVisualStyleBackColor = true;
            this.adminMngSysBtn.Click += new System.EventHandler(this.adminMngSysBtn_Click);
            // 
            // bookinMngBtn
            // 
            this.bookinMngBtn.Location = new System.Drawing.Point(12, 173);
            this.bookinMngBtn.Name = "bookinMngBtn";
            this.bookinMngBtn.Size = new System.Drawing.Size(115, 48);
            this.bookinMngBtn.TabIndex = 1;
            this.bookinMngBtn.Text = "Booking Management System";
            this.bookinMngBtn.UseVisualStyleBackColor = true;
            this.bookinMngBtn.Click += new System.EventHandler(this.bookinMngBtn_Click);
            // 
            // btnCMS
            // 
            this.btnCMS.Location = new System.Drawing.Point(242, 173);
            this.btnCMS.Name = "btnCMS";
            this.btnCMS.Size = new System.Drawing.Size(118, 48);
            this.btnCMS.TabIndex = 2;
            this.btnCMS.Text = "Customer Management System";
            this.btnCMS.UseVisualStyleBackColor = true;
            this.btnCMS.Click += new System.EventHandler(this.btnCMS_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 362);
            this.Controls.Add(this.btnCMS);
            this.Controls.Add(this.bookinMngBtn);
            this.Controls.Add(this.adminMngSysBtn);
            this.Name = "StartPage";
            this.Text = "Start Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminMngSysBtn;
        private System.Windows.Forms.Button bookinMngBtn;
        private System.Windows.Forms.Button btnCMS;

    }
}

