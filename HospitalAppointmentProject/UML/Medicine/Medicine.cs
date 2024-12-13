using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML
{
    internal class Medicine
    {
        private int? _MedicineID;
        private string _MedicineName;
        private string _Active_Ingredinet;
        private int? _Quantity; // needed just for the pharmacy
        private string _Dose; //for Prescriptions

        // add queries to the setters & getters
        public int? MedicineID { get { return _MedicineID; } set { _MedicineID = value; } }
        public string MedicineName { get { return _MedicineName; } set { _MedicineName = value; } }
        public string Active_Ingredinet { get { return _Active_Ingredinet; } set { _Active_Ingredinet = value; } }
        public int? Quantity { get { return _Quantity; } set { _Quantity = value; } }
        
        public string Dose { get { return _Dose; } set { _Dose = value; } }
        public Medicine(int? MedicineID = null, string MedicineName = null,string Active_Ingredinet = null,int? Quantity = null,string Dose = null) 
        {
            this.MedicineID = MedicineID;
            this.MedicineName= MedicineName;
            this.Active_Ingredinet= Active_Ingredinet;
            this.Quantity = Quantity;
            this.Dose = Dose;
        }

        //add more functions as u need
    }
}
