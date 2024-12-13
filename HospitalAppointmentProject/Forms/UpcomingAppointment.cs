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
    public partial class UpcomingAppointment : Form
    {
        public UpcomingAppointment()
        {
            InitializeComponent();
        }

        private void Cancel_hover(object sender, EventArgs e)
        {
            Cancel.Cursor = Cursors.Hand;
        }

        private void cancellabel_hover(object sender, EventArgs e)
        {
            Cancellabel.Cursor = Cursors.Hand;
        }
    }
}
