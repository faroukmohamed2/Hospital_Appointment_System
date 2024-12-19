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
    public partial class medicines : Form
    {
        Form prevform, mainform;
        public medicines(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
        }

        private void greeting_Click(object sender, EventArgs e)
        {

        }

        private void upmedlabel_hover(object sender, EventArgs e)
        {
            upmedlabel.Cursor = Cursors.Hand;
        }

        private void upmed_hover(object sender, EventArgs e)
        {
            upmed.Cursor = Cursors.Hand;

        }

        private void addmedlabel_hover(object sender, EventArgs e)
        {
            addmedlabel.Cursor = Cursors.Hand;
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

        private void Med_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void addmed_hover(object sender, EventArgs e)
        {
            addMed.Cursor = Cursors.Hand;
        }
    }
}
