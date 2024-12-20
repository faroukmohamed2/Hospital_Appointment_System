using HospitalAppointmentProject.UML.PLACES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML = HospitalAppointmentProject.UML;

namespace HospitalAppointmentSystem
{
    public partial class ModifyPharmacies : Form
    {
        Form prevform, mainform;
        UML.PLACES.Pharmacy pharmacy;
        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
            pharmacy = new UML.PLACES.Pharmacy();
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

        private void addPh_Click(object sender, EventArgs e)
        {
            
        }

        private void Updateph_Click(object sender, EventArgs e)
        {
        }

        public ModifyPharmacies(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.prevform = prevform;
        }



    }
}
