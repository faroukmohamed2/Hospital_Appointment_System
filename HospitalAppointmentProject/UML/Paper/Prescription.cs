using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.Paper
{
    internal class Prescription
    {
        public int? _PrescriptionID;
        public string _DateAndTime;
        public string _DiseaseName;
        public int? _PatientID;
        public string _DiseaseDescription;
        public int? _DoctorID;
        public List<Medicine> _Medicines;

        // add queries to the setters & getters
        public int? PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }

        public string DateAndTime
        {
            get { return _DateAndTime; }
            set { _DateAndTime = value; }
        }

        public string DiseaseName
        {
            get { return _DiseaseName; }
            set { _DiseaseName = value; }
        }

        public int? PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

        public string DiseaseDescription
        {
            get { return _DiseaseDescription; }
            set { _DiseaseDescription = value; }
        }

        public int? DoctorID
        {
            get { return _DoctorID; }
            set { _DoctorID = value; }
        }

        public List<Medicine> Medicines
        {
            get { return _Medicines; }
            set { _Medicines = value; }
        }
        public Prescription(int? PrescriptionID = null, string DateAndTime = null, string DiseaseName = null, int? PatientID = null, string DiseaseDescription = null, int? DoctorID = null, List<Medicine> Medicines = null)
        {
            this.PrescriptionID = PrescriptionID;
            this.DateAndTime = DateAndTime;
            this.DiseaseName = DiseaseName;
            this.PatientID = PatientID;
            this.DiseaseDescription = DiseaseDescription;
            this.DoctorID = DoctorID;
            this.Medicines = Medicines;
        }

        //add functions as u need
    }
}
