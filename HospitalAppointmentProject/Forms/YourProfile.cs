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
    public partial class YourProfile : Form
    {
        public YourProfile()
        {
            InitializeComponent();
        }

        private void upprolabel_hover(object sender, EventArgs e)
        {
            upprolabel.Cursor = Cursors.Hand;
        }

        private void uppro_hover(object sender, EventArgs e)
        {
            uppro.Cursor = Cursors.Hand;
        }

        private void chpass_Click(object sender, EventArgs e)
        {

        }
    }
}
