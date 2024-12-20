using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML = HospitalAppointmentProject.UML;

namespace HospitalAppointmentSystem
{

    public partial class Appoint : Form
    {
        Form prevform;
        Form mainform;
        int? patientID;
        UML.Appointments.HospitalAppointment Appointment;
        UML.Department Department;
        UML.PLACES.Hospital hospital;
        UML.USERS.Doctor doctor;
        public Appoint(Form prevform, Form mainform, int? patientID)
        {
            InitializeComponent();
            this.prevform = prevform;
            this.mainform = mainform;
            this.patientID = patientID;
            Appointment = new UML.Appointments.HospitalAppointment();
            Department = new UML.Department();
            hospital = new UML.PLACES.Hospital();
            doctor = new UML.USERS.Doctor();
            DataTable dataTable = Department.GetDepartments();
            Departments.ValueMember = "DepartmentID";
            Departments.DisplayMember = "DepartmentName";
            Hospitals.ValueMember = "PlaceID";
            Hospitals.DisplayMember = "PlaceName";
            Doctors.ValueMember = "UserID";
            Doctors.DisplayMember = "FirstName";
            datetoAppoint.Enabled = false;
            Departments.DataSource = dataTable;
        }

        private void Add_hover(object sender, EventArgs e)
        {
            addappoint.Cursor = Cursors.Hand;
        }

        private void addlabel_hover(object sender, EventArgs e)
        {
            Add.Cursor = Cursors.Hand;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            prevform.Show();
            this.Hide();
        }

        private void Appoin_close(object sender, FormClosedEventArgs e)
        {
            prevform.Show();
            this.Hide();
        }

        private void exitprogram_Click(object sender, EventArgs e)
        {
            mainform.Close();
        }

        private void contactus_Click(object sender, EventArgs e)
        {

            ContactUs cu = new ContactUs(this, mainform);
            this.Hide();
            cu.Show();
        }

        private void addappoint_Click(object sender, EventArgs e)
        {
            if (Departments.SelectedValue == null)
            {
                MessageBox.Show("please Select a department");
                return;
            }

            if (Hospitals.SelectedValue == null)
            {
                MessageBox.Show("please Select a Hospital");
                return;
            }

            if (Doctors.SelectedValue == null)
            {
                MessageBox.Show("please Select a Doctor");
                return;
            }
            if (times.SelectedValue == null)
            {
                MessageBox.Show("please Select a time to appoint in");
                return;
            }
        }

        private void Departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Departments.SelectedIndex < 0)
            {
                Hospitals.Enabled = false;
                return;
            }
            Hospitals.Enabled = true;
            Department._DepartmentID = (int)(Departments.SelectedValue);
            DataTable dt = Department.GetAllHospitals();
            Hospitals.DataSource = dt;


        }

        private void Hospitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Hospitals.Enabled || Hospitals.SelectedIndex < 0) {
                Doctors.Enabled = false;
                return;
            }
            Doctors.Enabled = true;
            hospital._PlaceID = (int)(Hospitals.SelectedValue);
            DataTable dt = hospital.GetDoctorsInDepartment((int)(Departments.SelectedValue));
            Doctors.DataSource = dt;
        }

        private void Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            datetoAppoint.Enabled = Doctors.Enabled && Doctors.SelectedIndex >= 0;
        }

        private void datetoAppoint_ValueChanged(object sender, EventArgs e)
        {
            if (datetoAppoint.Value < DateTime.Now)
            {
                times.DataSource = null;
                return;
            }
            DataTable dt = doctor.GetAllAvalibleTimes();
            times.DataSource = dt;
        }
    }
}
