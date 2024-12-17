using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentProject.UML.FeedBacks;
using HospitalAppointmentProject.UML.theMedicalHistory;
using HospitalAppointmentProject.UML.Paper;
using HospitalAppointmentProject.UML.Appointments;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class Patient : sysUser
    {
        public List<MedicalHistory> _MedicalHistories;
        public List<FeedBack> _FeedBacks;
        public List<Bill> _Bills;
        public List<HospitalAppointment> _Appointments;
        public List<Prescription> _PrescriptionList;
        public List<Doctor> _myDoctors;
        public List<ClinicAppointment> _ClinicAppointments;
        public List<MedicalHistory> MedicalHistories
        {
            get
            {
                // add query
                return _MedicalHistories;
            }
            set
            {
                // don't add query
                _MedicalHistories = value;
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

        public List<Bill> Bills
        {
            get
            {
                // add query
                return _Bills;
            }
            set
            {
                // don't add query
                _Bills = value;
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

        public List<Prescription> PrescriptionList
        {
            get
            {
                // add query
                return _PrescriptionList;
            }
            set
            {
                // don't add query
                _PrescriptionList = value;
            }
        }

        public List<Doctor> myDoctors
        {
            get 
            {
                return _myDoctors;
            }
            set 
            {
                _myDoctors = value;
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
        public Patient(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null, List<MedicalHistory> MedicalHistories = null, List<FeedBack> FeedBacks = null, List<Bill> Bills = null, List<HospitalAppointment> Appointments = null, List<Prescription> prescriptions = null, List<Doctor> myDoctors = null,List<ClinicAppointment> ClinicAppointments = null) :
            base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, UserType.Patient)
        {
            this.MedicalHistories = MedicalHistories;
            this.FeedBacks = FeedBacks;
            this._Bills = Bills;
            this.Appointments = Appointments;
            this.PrescriptionList = prescriptions;
            this.myDoctors = myDoctors;
            this.ClinicAppointments = ClinicAppointments;
        }

        public void GetUnBaidBills() { /**load the Bills into the list Bills then use it**/ }
        public void AddFeedBack(int DoctorID) { }

        //add more fubctions as u need
    }
}

