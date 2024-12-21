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
    public partial class HireDoctor : Form
    {
        Form prevform, mainform;
        public HireDoctor(Form prevform, Form mainform)
        {

            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
        }

        private void adddoclabel_hover(object sender, EventArgs e)
        {
            adddoclabel.Cursor = Cursors.Hand;
        }

        private void adddoc_Click(object sender, EventArgs e)
        {

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

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }

        private void Hiredos_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void DocID_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YourProfile yp = new YourProfile(this, mainform, null);
            this.Hide();
            yp.Show();
        }

        private void adddoc_hover(object sender, EventArgs e)
        {
            adddoc.Cursor = Cursors.Hand;
        }
    }
}
