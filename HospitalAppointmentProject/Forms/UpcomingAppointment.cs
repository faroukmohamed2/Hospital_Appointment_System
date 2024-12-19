﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointmentSystem
{

    public partial class UpcomingAppointment : Form
    {
        Form prevform;
        Form mainform;
        public UpcomingAppointment(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
        }

        private void Cancel_hover(object sender, EventArgs e)
        {
            Cancel.Cursor = Cursors.Hand;
        }

        private void cancellabel_hover(object sender, EventArgs e)
        {
            Cancellabel.Cursor = Cursors.Hand;
        }

        private void upAppointments_close(object sender, FormClosedEventArgs e)
        {
            this.Show();
            prevform.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void contactus_Click(object sender, EventArgs e)
        {

            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }
    }
}
