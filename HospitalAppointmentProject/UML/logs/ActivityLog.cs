using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.USERS
{
    internal class ActivityLog
    {
        public int? _UserID;
        public string _DatenTime;
        public string _ActivityType;


        // add queries to the setters & getters
        public string ActivityType { get { return _ActivityType; } set { _ActivityType = value; } }
        public int? UserID { get { return _UserID; } set { _UserID = value; } }
        public string DatenTime { get { return _DatenTime; } set { _DatenTime = value; } }


        public ActivityLog(int? UserID = null,string DatenTime = null,string ActivityType = null) 
        {
            this.ActivityType = ActivityType;
            this.DatenTime = DatenTime ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Default to current time in standard format
            this.UserID = UserID;
        }

        //add more functions as u need
    }
}
