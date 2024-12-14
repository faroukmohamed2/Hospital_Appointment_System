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
    public partial class HospitalManager : Form
    {
        public HospitalManager()
        {
            InitializeComponent();
        }

        private void manHoslabel_hover(object sender, EventArgs e)
        {
            manHoslabel.Cursor = Cursors.Hand;
        }

        private void manHos_hover(object sender, EventArgs e)
        {
            manHos.Cursor = Cursors.Hand;
        }

        private void adddoclabel_hover(object sender, EventArgs e)
        {
            adddoclabel.Cursor = Cursors.Hand;
        }

        private void adddoc_hover(object sender, EventArgs e)
        {
            addDoc.Cursor = Cursors.Hand;
        }

        private void fireDoc_hover(object sender, EventArgs e)
        {
            fireDoc.Cursor = Cursors.Hand;
        }

        private void fireDoclabel_hover(object sender, EventArgs e)
        {
            fireDoclabel.Cursor = Cursors.Hand;
        }
    }
}
