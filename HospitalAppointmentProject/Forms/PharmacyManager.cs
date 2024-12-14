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
        public PharmacyManager()
        {
            InitializeComponent();
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
    }
}
