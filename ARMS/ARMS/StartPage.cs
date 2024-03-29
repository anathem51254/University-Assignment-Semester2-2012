﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARMS
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnCMS_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void bookinMngBtn_Click(object sender, EventArgs e)
        {
            BookingManagementMainForm booking = new BookingManagementMainForm();
            booking.ShowDialog();
        }

        private void adminMngSysBtn_Click(object sender, EventArgs e)
        {
            AdministrationManagementPackage admin = new AdministrationManagementPackage();
            admin.ShowDialog();
        }
    }
}
