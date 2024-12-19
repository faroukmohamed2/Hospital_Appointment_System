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

    public partial class Appoint : Form
    {
        Form prevform;
        Form mainform;
        public Appoint(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
        }

        private void Add_hover(object sender, EventArgs e)
        {
            addappoint.Cursor = Cursors.Hand;
        }

        private void addlabel_hover(object sender, EventArgs e)
        {
            Add.Cursor = Cursors.Hand;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            prevform.Show();
            this.Hide();
        }

        private void Appoin_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
            this.Hide();
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

        private void addappoint_Click(object sender, EventArgs e)
        {
            if (Departments.SelectedValue == null)
            {
                MessageBox.Show("please Select a department");
                return;
            }

            if (Hospitals.SelectedValue == null)
            {
                MessageBox.Show("please Select a Hospital");
                return;
            }

            if (Doctors.SelectedValue == null)
            {
                MessageBox.Show("please Select a Doctor");
                return;
            }
            if (times.SelectedValue == null)
            {
                MessageBox.Show("please Select a time to appoint in");
                return;
            }
        }
    }
}
