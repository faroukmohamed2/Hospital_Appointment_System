using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML = HospitalAppointmentProject.UML;
namespace HospitalAppointmentSystem
{
    public partial class EditProfile : Form
    {
        Form prevform, mainform;
        int? _UserID;
        UML.USERS.sysUser user;
        public EditProfile(Form prevform , Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            user = new UML.USERS.sysUser(_UserID);
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
