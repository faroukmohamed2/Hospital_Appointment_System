using DBapplication;
using HospitalAppointmentProject.UML.Appointments;
using HospitalAppointmentProject.UML.FeedBacks;
using HospitalAppointmentProject.UML.Paper;
using HospitalAppointmentProject.UML.PLACES;
using HospitalAppointmentProject.UML.theMedicalHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class Doctor : sysUser
    {
        public Hospital _DoctorHospital;
        public DataTable _FeedBacks;
        public List<Clinic> _Clincs;
        public DataTable _Appointments;
        public List<Patient> _myPatients;
        public Department _DoctorDepartment;
        public List<ClinicAppointment> _ClinicAppointments;
        public char _isavailable;
        Hospital DoctorHospital
        {
            get
            {
                // add queries
                return _DoctorHospital;
            }
            set
            {
                // add queries
                _DoctorHospital = value;
            }
        }
        public char IsAvailable
        {
            get
            {
                string query = $"select ISAvailable from doctor where doctorid = {_UserID}";
                _isavailable = (char)DataBase.Manager.ExecuteScalar(query);
                return _isavailable;
            }
            set
            {
                string query;
                if (_isavailable == 'T')
                    query = $"Update doctor set ISAvailable = 'T' where doctorid = {_UserID}";
                else
                    query = $"Update doctor set ISAvailable = 'F' where doctorid = {_UserID}";

                int res = DataBase.Manager.ExecuteNonQuery(query);
            }
        }
        public DataTable FeedBacks
        {
            get
            {
                // add query
                string query = $"select thefeedback, email from sysUser,feedback where Userid = patientid and Doctorid = {_UserID}";
                _FeedBacks = DataBase.Manager.ExecuteReader(query);
                return _FeedBacks;
            }
            set
            {
                // don't add query
                _FeedBacks = value;
            }
        }

        public List<Clinic> Clincs
        {
            get
            {
                // add query
                return _Clincs;
            }
            set
            {
                // don't add query
                _Clincs = value;
            }
        }

        public DataTable Appointments
        {
            get
            {
                // add query
                string query = $"select DateAndTime, firstname, lastname from HospitalAppointment,sysUSER where Userid = patientid and doctorid = {_UserID}";
                _Appointments = DataBase.Manager.ExecuteReader(query);
                return _Appointments;
            }
            set
            {
                // don't add query
                _Appointments = value;
            }
        }

        public Department DoctorDepartment
        {
            get
            {
                // add query
                return _DoctorDepartment;
            }
            set
            {
                // add query
                _DoctorDepartment = value;
            }
        }

        public List<Patient> myPatients
        {
            get 
            {
                // add query
                return _myPatients;
            }
            set 
            { 
                _myPatients = value;
            }
        }

        public List<ClinicAppointment> ClinicAppointments 
        {
            get
            {
                return _ClinicAppointments;
            }
            set
            {
                _ClinicAppointments = value;
            }
        }

        public Doctor(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null,Hospital DoctorHospital = null, List<Clinic> Clincs = null, Department DoctorDepartment = null, List<Bill> Bills = null, DataTable Appointments = null,List<Patient> myPatients = null,List<ClinicAppointment> ClinicAppointments = null) :
            base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, UserType.Doctor)
        {
            this.myPatients = myPatients;
            this.Clincs = Clincs;
            this.DoctorDepartment = DoctorDepartment;   
            this.DoctorHospital = DoctorHospital;
            this.FeedBacks = FeedBacks;
            this.Appointments = Appointments;
            this.ClinicAppointments = ClinicAppointments;
        }

        //add more functions as u need
    }
}
