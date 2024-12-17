using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // Add more methods or functions as needed
    }
}
