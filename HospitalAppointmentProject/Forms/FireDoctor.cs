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
    public partial class FireDoctor : Form
    {
        Form prevform, mainform;
        public FireDoctor(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
        }

        private void firedoclabel_hover(object sender, EventArgs e)
        {
            firedoclabel.Cursor = Cursors.Hand;
        }

        private void firedoc_hover(object sender, EventArgs e)
        {
            firedoc.Cursor = Cursors.Hand;
        }

        private void updoc_hover(object sender, EventArgs e)
        {
            updoc.Cursor = Cursors.Hand;
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

        private void firedoc_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void updoclabel_hover(object sender, EventArgs e)
        {
            updoclabel.Cursor = Cursors.Hand;
        }
    }
}
