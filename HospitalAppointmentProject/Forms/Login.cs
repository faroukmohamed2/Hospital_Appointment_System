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
        Form prevform, mainform;
        TextBox[] signUpAllboxes, loginAllboxes;
        Label[] loginlabels, signUpLabels;
        public login(Form prevform, Form mainform)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            signUpAllboxes = new TextBox[]{ Fname, LName, SignupEmail, SetPassword, confirmPass, Age};
            loginAllboxes = new TextBox[] { Email, Password };
            loginlabels = new Label[] { signuplabel, passloglabel, Eloglabel };
            signUpLabels = new Label[] { FNlabel, LNlabel, Euplabel, passuplabel, conpasslabel, agelabel, genderlabel, retloginlabel };

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
        private void showlabel(Label toshow)
        {
            toshow.Visible = true;
            toshow.Enabled = true;
        }
        private void showTextbox(TextBox tochange)
        {
            tochange.Visible = true;
            tochange.Enabled = true;
        }
        private void hidelabel(Label toshow)
        {
            toshow.Visible = false;
            toshow.Enabled = false;
        }
        private void hideTextbox(TextBox tochange)
        {
            tochange.Visible = false;
            tochange.Enabled = false;
        }

        private void hide_login()
        {
            for (int i = 0; i < loginlabels.Length; i++)
            {
                hidelabel(loginlabels[i]);
            }
            for (int i = 0; i < loginAllboxes.Length; i++)
            {
                hideTextbox(loginAllboxes[i]);
            }
            log_in_here.Visible = false;
            log_in_here.Enabled = false;
            signup.Visible = false;
            signup.Enabled = false;
            showpass.Enabled = false;
            showpass.Visible = false;
        }
        private void show_login()
        {
            for (int i = 0; i < loginlabels.Length; i++)
            {
                showlabel (loginlabels[i]);
            }
            for (int i = 0; i < loginAllboxes.Length; i++)
            {
                showTextbox(loginAllboxes[i]);
            }
            log_in_here.Visible = true;
            log_in_here.Enabled = true;
            signup.Visible = true;
            signup.Enabled = true;
            showpass.Enabled = true;
            showpass.Visible = true;
        }

        private void hide_signup()
        {
            for (int i = 0; i < signUpLabels.Length; i++)
            {
                hidelabel(signUpLabels[i]);
            }
            for (int i = 0; i < signUpAllboxes.Length; i++)
            {
                hideTextbox(signUpAllboxes[i]);
            }
            retlogin.Visible = false;
            retlogin.Enabled = false;
            upshowpass.Visible = false;
            upshowpass.Enabled = false;
            Submit.Enabled = false;
            Submit.Visible = false;
        }
        private void show_signup()
        {
            for (int i = 0; i < signUpLabels.Length; i++)
            {
                showlabel(signUpLabels[i]);
            }
            for (int i = 0; i < signUpAllboxes.Length; i++)
            {
                showTextbox(signUpAllboxes[i]);
            }
            retlogin.Visible = true;
            retlogin.Enabled = true;
            upshowpass.Visible = true;
            upshowpass.Enabled = true;
            Submit.Enabled = true;
            Submit.Visible = true;

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

        private void login_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
        }

        private void retlogin_Click(object sender, EventArgs e)
        {
            hide_signup();
            show_login();
        }
        private bool isfilled(TextBox fill)
        {
            if (fill.Text != "")
                return true;
            return false;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevform.Show();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void log_in_here_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < loginAllboxes.Length; i++)
            {
                if (!isfilled(loginAllboxes[i]))
                {
                    MessageBox.Show("please fill all fields");
                    return;
                }
            }
            Patient pat = new Patient(mainform);
            this.Hide();
            pat.Show();
        }

        private void contactus_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < signUpAllboxes.Length; i++)
            {
                if (!isfilled(signUpAllboxes[i])){
                    MessageBox.Show("please fill all fields");
                    return;
                }
            }
        }

        private void upshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (upshowpass.Checked)
            {
                SetPassword.PasswordChar = '\0';
                confirmPass.PasswordChar = '\0';
            }
            else
            {
                SetPassword.PasswordChar = '*';
                confirmPass.PasswordChar = '*';
            }
        }
    }
}
