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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void uppass_hover(object sender, EventArgs e)
        {
            uppass.Cursor = Cursors.Hand;
        }

        private void uppasslabel_hover(object sender, EventArgs e)
        {
            uppasslabel.Cursor = Cursors.Hand;
        }
    }
}
