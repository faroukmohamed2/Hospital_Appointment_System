using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.Paper
{
    internal class Bill
    {
        public int? _BillID;
        public float? _Price;
        public string _DatenTime;
        public int? _PatientID;
        public int? _PlaceID;
        bool _IsPaid;


        // add queries to the setters & getters
        public int? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        public float? Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string DatenTime
        {
            get { return _DatenTime; }
            set { _DatenTime = value; }
        }

        public int? PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

        public int? PlaceID
        {
            get { return _PlaceID; }
            set { _PlaceID = value; }
        }

        public bool IsPaid
        {
            get { return _IsPaid; }
            set { _IsPaid = value; }
        }

        public Bill(int? BillID = null, float? Price = null, string DatenTime = null, int? PatientID = null, int? PlaceID = null, bool IsPaid = false)
        {
            this.BillID = BillID;
            this.Price = Price;
            this.DatenTime = DatenTime;
            this.PatientID = PatientID;
            this.PlaceID = PlaceID;
            this.IsPaid = IsPaid;
        }

        //add more functions as u need
    }
}
