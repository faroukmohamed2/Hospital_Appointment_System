using HospitalAppointmentProject.UML.Paper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentProject.UML.theMedicalHistory
{
    internal class MedicalHistory
    {
        private int? _PatientID;
        private string _DiseaseDescription;
        private int? _AtYear;
        private bool? _IsCured;
        private List<Prescription> _PrescriptionList;

        public int? PatientID
        { 
            get 
            { 
                // add query
                return _PatientID;
            }
            set 
            {
                // add query if needed
                _PatientID = value;
            }
        }

        public string DiseaseDescription
        {
            get
            {
                // add query
                return _DiseaseDescription;
            }
            set 
            {
                // add query
                _DiseaseDescription = value;
            }
        }

        int? AtYear
        {
            get
            {
                // add query
                return _AtYear;
            }
            set
            {
                // add query
                _AtYear = value;
            }
        }

        public bool? IsCured
        {
            get
            {
                // add query
                return _IsCured;
            }
            set 
            {
                // add query
                _IsCured = value;
            }
        }

        public List<Prescription> PrescriptionList
        {
            get
            {
                // add query
                return _PrescriptionList;
            }
            set
            {
                // don't add query
                _PrescriptionList = value;
            }
        }

        public MedicalHistory(int? PatientID = null,string DiseaseDescription = null, int? AtYear = null, bool? IsCured = null, List<Prescription> PrescriptionList = null) 
        {
            this.PatientID = PatientID;
            this.DiseaseDescription= DiseaseDescription;    
            this.AtYear = AtYear;
            this.IsCured = IsCured;
            this.PrescriptionList = PrescriptionList;
        }

        //add more functions as u need
    }
}
