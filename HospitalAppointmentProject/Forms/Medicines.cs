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
    public partial class Medicines : Form
    {
        public Medicines()
        {
            InitializeComponent();
        }

        private void greeting_Click(object sender, EventArgs e)
        {

        }

        private void upmedlabel_hover(object sender, EventArgs e)
        {
            upmedlabel.Cursor = Cursors.Hand;
        }

        private void upmed_hover(object sender, EventArgs e)
        {
            upmed.Cursor = Cursors.Hand;

        }

        private void addmedlabel_hover(object sender, EventArgs e)
        {
            addmedlabel.Cursor = Cursors.Hand;
        }

        private void addmed_hover(object sender, EventArgs e)
        {
            addMed.Cursor = Cursors.Hand;
        }
    }
}
