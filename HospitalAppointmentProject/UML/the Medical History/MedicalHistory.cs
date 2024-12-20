﻿using DBapplication;
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
        public int? _PatientID;
        public string _DiseaseDescription;
        public int? _AtYear;
        public bool? _IsCured;
        public List<Prescription> _PrescriptionList;

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
        public int newMedHistory()
        {

            string query = $"insert into MedicalHistory values({_PatientID}, '{_DiseaseDescription}', {_AtYear}, 'F')";
            int res = DataBase.Manager.ExecuteNonQuery(query);
            return res;
        }
        public int updatemedHistpry()
        {
            char cured = 'F';
            if (_IsCured == true)
                cured = 'T';
            string query = $"update MedicalHistory set iscured = 'F' where patientid = {_PatientID} and DiseaseDescription = '{_DiseaseDescription}')";
            int res = DataBase.Manager.ExecuteNonQuery(query);
            return res;
        }
        //add more functions as u need
    }
}
