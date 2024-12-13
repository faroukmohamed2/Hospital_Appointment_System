﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.PLACES
{

    enum PlaceType { None,Hospital,Pharmacy,Clinic };
    internal class Place
    {
        private int? _PlaceID;
        private string _PlaceName;
        private string _Email;
        private string _PhoneNumber;
        private string _StartingTime; 
        private string _EndingTime;   
        private bool? _IsAvailable; 
        private string _PlaceLocation;
        private string _OpenDays; 
        private PlaceType _Type; 

        public int? PlaceID
        {
            get { return _PlaceID; }
            set { _PlaceID = value; }
        }

        public string PlaceName
        {
            get { return _PlaceName; }
            set { _PlaceName = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        public string StartingTime
        {
            get { return _StartingTime; }
            set { _StartingTime = value; }
        }

        public string EndingTime
        {
            get { return _EndingTime; }
            set { _EndingTime = value; }
        }

        public bool? IsAvailable
        {
            get { return _IsAvailable; }
            set { _IsAvailable = value; }
        }

        public string PlaceLocation
        {
            get { return _PlaceLocation; }
            set { _PlaceLocation = value; }
        }

        public string OpenDays
        {
            get { return _OpenDays; }
            set { _OpenDays = value; }
        }

        public PlaceType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

      
        public Place(
            int? PlaceID = null,
            string PlaceName = null,
            string Email = null,
            string PhoneNumber = null,
            string StartingTime = null,
            string EndingTime = null,
            bool? IsAvailable = null,
            string PlaceLocation = null,
            string OpenDays = null,
            PlaceType Type = PlaceType.None)
        {
            this.PlaceID = PlaceID;
            this.PlaceName = PlaceName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.StartingTime = StartingTime;
            this.EndingTime = EndingTime;
            this.IsAvailable = IsAvailable;
            this.PlaceLocation = PlaceLocation;
            this.OpenDays = OpenDays;
            this.Type = Type;
        }
    }
}