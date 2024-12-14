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
        public FireDoctor()
        {
            InitializeComponent();
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

        private void updoclabel_hover(object sender, EventArgs e)
        {
            updoclabel.Cursor = Cursors.Hand;
        }
    }
}
