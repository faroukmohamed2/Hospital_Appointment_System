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
    public partial class HireDoctor : Form
    {
        public HireDoctor()
        {
            InitializeComponent();
        }

        private void adddoclabel_hover(object sender, EventArgs e)
        {
            adddoclabel.Cursor = Cursors.Hand;
        }
    }
}
