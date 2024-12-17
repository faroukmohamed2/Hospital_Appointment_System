using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.PLACES
{
    internal class Pharmacy : Place
    {
        public List<Medicine> _Medicines;

        
        public List<Medicine> Medicines
        {
            get
            {
                return _Medicines;
            }
            set
            {
                _Medicines = value;
            }
        }

        
        public Pharmacy(int? PlaceID = null, string PlaceName = null, string Email = null, string PhoneNumber = null,
                        string StartingTime = null, string EndingTime = null, bool? IsAvailable = null,
                        string PlaceLocation = null, string OpenDays = null, List<Medicine> Medicines = null)
            : base(PlaceID, PlaceName, Email, PhoneNumber, StartingTime, EndingTime, IsAvailable, PlaceLocation, OpenDays, PlaceType.Pharmacy)
        {
            this.Medicines = Medicines;
        }

        // Add more methods or functions as needed
    }
}
