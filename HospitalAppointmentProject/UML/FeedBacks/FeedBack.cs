using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.FeedBacks
{
    internal class FeedBack
    {
        private int? _FeedBackID;
        private string _theFeedBack;
        private int? _PatientID;
        private int? _DoctorID;

        //add queries to the next setters & getters
        public int? FeedBackID { get { return _FeedBackID; } set { _FeedBackID = value; } }
        public int? PatientID { get { return _PatientID; } set { _PatientID = value; } }
        public int? DoctorID { get { return _DoctorID; } set { _DoctorID = value; } }
        public string theFeedBack { get { return _theFeedBack; } set { _theFeedBack = value; } }

        FeedBack(int? FeedBackID = null,string theFeedBack = null, int? PatientID = null, int? DoctorID = null) 
        {
            this.PatientID = PatientID;
            this.FeedBackID = FeedBackID;
            this.theFeedBack = theFeedBack;
            this.DoctorID = DoctorID;
        }

        //add more functions as u need
    }
}
