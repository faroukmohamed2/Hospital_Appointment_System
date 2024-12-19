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
    public partial class PharmacyManager : Form
    {
        Form mainform;
        public PharmacyManager(Form mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void manphlabel_hover(object sender, EventArgs e)
        {
            manphlabel.Cursor = Cursors.Hand;
        }

        private void manph_hover(object sender, EventArgs e)
        {
            manph.Cursor = Cursors.Hand;
        }

        private void manmedlabel_hover(object sender, EventArgs e)
        {
            manmedlabel.Cursor = Cursors.Hand;
        }

        private void manmed_hover(object sender, EventArgs e)
        {
            manmed.Cursor = Cursors.Hand;
        }

        private void phman_close(object sender, FormClosedEventArgs e)
        {
            mainform.Close();
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

        private void manph_Click(object sender, EventArgs e)
        {
            ManagePharmacy mph = new ManagePharmacy(this, mainform);
            this.Hide();
            mph.Show();
        }

        private void manphlabel_Click(object sender, EventArgs e)
        {
            ManagePharmacy mph = new ManagePharmacy(this, mainform);
            this.Hide();
            mph.Show();
        }

        private void manmed_Click(object sender, EventArgs e)
        {
            medicines med = new medicines(this, mainform);
            this.Hide();
            med.Show();
        }

        private void manmedlabel_Click(object sender, EventArgs e)
        {
            medicines med = new medicines(this, mainform);
            this.Hide();
            med.Show();
        }
    }
}
