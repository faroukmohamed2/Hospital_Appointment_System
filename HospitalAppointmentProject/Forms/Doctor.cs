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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Appoints_hover(object sender, EventArgs e)
        {
            Appoints.Cursor = Cursors.Hand;
        }

        private void curApplable_hover(object sender, EventArgs e)
        {
            curApplabel.Cursor = Cursors.Hand;
        }

        private void addpre_hover(object sender, EventArgs e)
        {
            addpre.Cursor = Cursors.Hand;
        }

        private void addprelabel_hover(object sender, EventArgs e)
        {
            addprelabel.Cursor = Cursors.Hand;
        }

        private void pinfolabel_hover(object sender, EventArgs e)
        {
            pinfolabel.Cursor = Cursors.Hand;
        }

        private void pInfo_hover(object sender, EventArgs e)
        {
            pInfo.Cursor = Cursors.Hand;
        }

        private void feedbackslabel_hover(object sender, EventArgs e)
        {
            feedbacklabel.Cursor = Cursors.Hand;
        }

        private void feedbacks_hover(object sender, EventArgs e)
        {
            feedbacks.Cursor = Cursors.Hand;
        }
    }
}
