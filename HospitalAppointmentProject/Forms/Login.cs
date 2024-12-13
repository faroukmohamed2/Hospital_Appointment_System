using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointmentSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        ///////////////////////////////////////////////
        ///                                         ///
        ///     switch between sign up and log in   /// 
        ///                                         ///
        ///////////////////////////////////////////////
        private void hide_login()
        {
            Eloglabel.Visible = false; Eloglabel.Enabled = false;
            Email.Enabled = false; Email.Visible = false;
            Password.Visible = false; Password.Visible = false;
            passloglabel.Visible = false; passloglabel.Enabled = false;
            signuplabel.Visible = false; signuplabel.Enabled = false;
            signup.Enabled = false; signup.Visible = false;
            log_in_here.Visible = false; log_in_here.Enabled = false;
            showpass.Enabled = false; showpass.Visible = false;
        }
        private void show_signup()
        {
            FNlabel.Visible = true; FNlabel.Enabled = true;
            Fname.Visible = true; Fname.Enabled = true;
            LNlabel.Visible = true; LNlabel.Enabled = true;
            LName.Visible = true; LName.Enabled = true;
            Euplabel.Visible = true; Euplabel.Enabled = true;
            SignupEmail.Enabled = true; SignupEmail.Visible = true;
            passuplabel.Visible = true; passuplabel.Enabled = true;
            SetPassword.Enabled = true; SetPassword.Visible = true;
            conpasslabel.Visible = true; conpasslabel.Enabled = true;
            confirmPass.Visible = true; confirmPass.Enabled = true;
            agelabel.Visible = true; agelabel.Enabled = true;
            Age.Visible = true; Age.Enabled = true;
            genderlabel.Visible = true; genderlabel.Enabled = true;
            Gender.Enabled = true; Gender.Visible = true;
            Submit.Visible = true; Submit.Enabled = true;
        }
        /////////////////////////////////////////////////////////////////
 
        private void signup_Click(object sender, EventArgs e)
        {
            hide_login();
            show_signup();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
