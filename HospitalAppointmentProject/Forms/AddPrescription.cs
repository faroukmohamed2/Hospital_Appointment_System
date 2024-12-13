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
    public partial class AddPrescription : Form
    {
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void addpre_hover(object sender, EventArgs e)
        {
            addpre.Cursor = Cursors.Hand;
        }

        private void addprelabel_hover(object sender, EventArgs e)
        {
            addprelabel.Cursor = Cursors.Hand;
        }
    }
}
