using DBapplication;
using HospitalAppointmentProject.UML.Appointments;
using HospitalAppointmentProject.UML.FeedBacks;
using HospitalAppointmentProject.UML.Paper;
using HospitalAppointmentProject.UML.PLACES;
using HospitalAppointmentProject.UML.theMedicalHistory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalAppointmentProject.UML.USERS
{
    internal class Doctor : sysUser
    {
        public Hospital _DoctorHospital;
        public List<FeedBack> _FeedBacks;
        public List<Clinic> _Clincs;
        public List<HospitalAppointment> _Appointments;
        public List<Patient> _myPatients;
        public Department _DoctorDepartment;
        public List<ClinicAppointment> _ClinicAppointments;
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

        public List<FeedBack> FeedBacks
        {
            get
            {
                // add query
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

        public List<HospitalAppointment> Appointments
        {
            get
            {
                // add query
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
            List<ActivityLog> ActivityLogs = null,Hospital DoctorHospital = null, List<Clinic> Clincs = null, Department DoctorDepartment = null, List<Bill> Bills = null, List<HospitalAppointment> Appointments = null,List<Patient> myPatients = null,List<ClinicAppointment> ClinicAppointments = null) :
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



     
        public DataTable GetAllAvalibleTimes()
        {
            string GetHospitalID = $"select HospitalID from Doctor where DoctorID={this._UserID}";
            int HospitalID = (int)DataBase.Manager.ExecuteScalar(GetHospitalID);

            string GetAvallableTimws = $"select StartingTime,EndingTime,OpenDays From Place Where PlaceID={HospitalID}";
            


            return null;
        }
        //add more functions as u need
    }
}
