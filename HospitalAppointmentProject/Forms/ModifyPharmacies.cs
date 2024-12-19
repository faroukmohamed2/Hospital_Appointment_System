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
    public partial class ModifyPharmacies : Form
    {
        Form prevform, mainform;

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

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }

        private void modph_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        public ModifyPharmacies(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.prevform = prevform;
        }
    }
}
