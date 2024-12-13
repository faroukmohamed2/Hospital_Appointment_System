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
    public partial class Appoint : Form
    {
        public Appoint()
        {
            InitializeComponent();
        }

        private void Add_hover(object sender, EventArgs e)
        {
            addappoint.Cursor = Cursors.Hand;
        }

        private void addlabel_hover(object sender, EventArgs e)
        {
            Add.Cursor = Cursors.Hand;
        }
    }
}
