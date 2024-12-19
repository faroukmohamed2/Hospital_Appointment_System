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
    public partial class ModifyHospitals : Form
    {
        Form prevform, mainform;
        TextBox []feilds;
        private void Home_Click(object sender, EventArgs e)
        {
            prevform.Show();
            this.Hide();
        }

        private void modHos_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
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
        private bool isfilled(TextBox to)
        {
            if (to.Text == "")
                return false;
            return true;
        }
        private void AddHos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < feilds.Length; i++)
            {
                if (!isfilled(feilds[i]))
                {
                    MessageBox.Show("please fill all feilds");
                    return;
                }
            }

        }

        private void UpHos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < feilds.Length; i++)
            {
                if (!isfilled(feilds[i]))
                {
                    MessageBox.Show("please fill all feilds");
                    return;
                }
            }

        }

        private void delHos_Click(object sender, EventArgs e)
        {
            if (!isfilled(delHosID))
            {
                MessageBox.Show("please write the HospitalID");
                return;
            }
        }

        public ModifyHospitals(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            feilds = new TextBox[] { HosID, HosName, HosPN, HosEmail, HosLocation };
        }
    }
}
