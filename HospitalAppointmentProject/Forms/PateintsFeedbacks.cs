using System;
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
    public partial class PateintsFeedbacks : Form
    {
        Form prevform, mainform;
        public PateintsFeedbacks(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
        }

        private void contactus_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void feedback_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }
    }
}
