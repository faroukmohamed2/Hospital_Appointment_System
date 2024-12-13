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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void modHos_hover(object sender, EventArgs e)
        {
            modHos.Cursor = Cursors.Hand;
        }

        private void modHoslabel_hover(object sender, EventArgs e)
        {
            modHoslabel.Cursor = Cursors.Hand;
        }

        private void modph_hover(object sender, EventArgs e)
        {
            Modph.Cursor = Cursors.Hand;
        }

        private void Modphlabel_hover(object sender, EventArgs e)
        {
            Modphlabel.Cursor = Cursors.Hand;
        }

        private void log_hover(object sender, EventArgs e)
        {
            log.Cursor = Cursors.Hand;
        }

        private void loglabel_hover(object sender, EventArgs e)
        {
            loglabel.Cursor = Cursors.Hand;
        }

        private void reports_hover(object sender, EventArgs e)
        {
            reports.Cursor = Cursors.Hand;
        }

        private void reportslabel_hover(object sender, EventArgs e)
        {
            reportslabel.Cursor = Cursors.Hand;
        }
    }
}
