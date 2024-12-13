using HospitalAppointmentProject.UML.PLACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class PharmacyManager : Manager
    {
        public PharmacyManager(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null, List<Place> ManagedPlace = null) :
            base(UserID, Email, UserPassword, Age, Gender, First_Name, Last_Name, ActivityLogs, ManagedPlace)
        {
        }

        //add more functions as u need
    }
}
