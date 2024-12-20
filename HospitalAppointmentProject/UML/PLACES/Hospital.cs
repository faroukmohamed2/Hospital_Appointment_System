using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBapplication;
using HospitalAppointmentProject.UML.Appointments;
using HospitalAppointmentProject.UML.USERS;

namespace HospitalAppointmentProject.UML.PLACES
{
    internal class Hospital : Place
    {
        public List<Department> _HospitalsDepartments;
        public List<Doctor> _Doctors;
        public List<HospitalAppointment> _Appointments;

        
        public List<Department> HospitalsDepartments
        {
            get
            {
                return _HospitalsDepartments;
            }
            set
            {
                _HospitalsDepartments = value;
            }
        }

       
        public List<Doctor> Doctors
        {
            get
            {
                return _Doctors;
            }
            set
            {
                _Doctors = value;
            }
        }

        public List<HospitalAppointment> Appointments
        {
            get
            {
                return _Appointments;
            }
            set
            {
                _Appointments = value;
            }
        }

        
        public Hospital(int? PlaceID = null, string PlaceName = null, string Email = null, string PhoneNumber = null,
                        string StartingTime = null, string EndingTime = null, bool? IsAvailable = null,
                        string PlaceLocation = null, string OpenDays = null, List<Department> HospitalsDepartments = null,
                        List<Doctor> Doctors = null, List<HospitalAppointment> Appointments = null)
            : base(PlaceID, PlaceName, Email, PhoneNumber, StartingTime, EndingTime, IsAvailable, PlaceLocation, OpenDays, PlaceType.Hospital)
        {
            this.HospitalsDepartments = HospitalsDepartments;
            this.Doctors = Doctors;
            this.Appointments = Appointments;
        }

        public int inserthospital()
        {
            string q = $"insert into Place values ({_PlaceID},'{_PlaceName}','{_Email}','{_PhoneNumber}','{_StartingTime}','{_EndingTime}','{_IsAvailable}','{_PlaceLocation}','{_OpenDays}') ";
            int resulthos = DataBase.Manager.ExecuteNonQuery(q);
            string hosq = $"insert into Hospital values({_PlaceID});";
            int resulthid = DataBase.Manager.ExecuteNonQuery(hosq);
            if (resulthid == 0 || resulthos == 0)
                return 0;
            return 1;
        }
        public int deletehospital()
        {
            string q = $"DELETE FROM Hospital where HospitalID = {_PlaceID}; ";
            int r = DataBase.Manager.ExecuteNonQuery(q);
            string query = $"DELETE FROM Place WHERE PlaceID = {_PlaceID};";
            int resultPharmacy = DataBase.Manager.ExecuteNonQuery(query);
            if (resultPharmacy == 0 || r == 0)
                return 0;

            return 1;

        }

        public bool CheckIfHospitalExists(int hid)
        {
            string query = $"SELECT COUNT(*) FROM Place WHERE PlaceID = {hid}";
            int c = (int)DataBase.Manager.ExecuteScalar(query);
            return c > 0;
        }
    }
}
