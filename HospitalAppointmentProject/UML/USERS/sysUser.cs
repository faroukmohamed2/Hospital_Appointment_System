﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DBapplication;
namespace HospitalAppointmentProject.UML.USERS
{
    enum UserType { None,Patient,Doctor,Manager,PharmacyManager, HospitalManager,Admin };
   
    internal class sysUser
    {
        
        public UserType user_type;

        public int? _UserID;
        public string _Email;
        public string _UserPassword;
        public int? _Age;
        public char? _Gender;
        public string _First_Name;
        public string _Last_Name;
        public List<ActivityLog> _ActivityLogs;

        
        public int? UserID
        {
            get
            {
                // Add query or logic (e.g., log access)
                return _UserID;
            }
            set
            {
                // Add validation or query
                _UserID = value;
            }
        }

        public string Email
        {
            get
            {
                // Add query or logic
                return _Email;
            }
            set
            {
                // Add validation or query
                _Email = value;
            }
        }

        public string UserPassword
        {
            get
            {
                // Add query or logic
                return _UserPassword;
            }
            set
            {
                // Add validation or query
                _UserPassword = value;
            }
        }

        public int? Age
        {
            get
            {
                // Add query or logic
                return _Age;
            }
            set
            {
                // Add validation or query
                if (value.HasValue && value < 0)
                    throw new ArgumentException("Age cannot be negative.");
                _Age = value;
            }
        }

        public char? Gender
        {
            get
            {
                // Add query or logic
                return _Gender;
            }
            set
            {
                // Add validation or query
                if (value.HasValue &&  value != 'M' && value != 'F' && value != 'O')
                    throw new ArgumentException("Gender must be 'M', 'F', or 'O'.");
                _Gender = value;
            }
        }

        public string First_Name
        {
            get
            {
                // Add query or logic
                return _First_Name;
            }
            set
            {
                // Add validation or query
                _First_Name = value;
            }
        }
        public string Last_Name
        {
            get
            {
                // Add query or logic
                return _Last_Name;
            }
            set
            {
                // Add validation or query
                _Last_Name = value;
            }
        }

        public List<ActivityLog> ActivityLogs 
        { 
            get
            {
                // Add query or logic
                return _ActivityLogs;
            }
            set
            {
                // don't add queries
                _ActivityLogs = value;
            }
        }

        public sysUser(int? UserID = null, string Email = null, string UserPassword = null, int? Age = null, char? Gender = null, string First_Name = null, string Last_Name = null,
            List<ActivityLog> ActivityLogs = null, UserType user_type = UserType.None)
        {
            this.UserID = UserID;
            this.Email = Email;
            this.UserPassword = UserPassword;
            this.Age = Age;
            this.Gender = Gender;
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.ActivityLogs = ActivityLogs;
            this.user_type = user_type;
        }

        public UserType LogIn() {
            string query = $"select UserID, password from sysUser where Email = {_Email}";
            DataTable id = DataBase.Manager.ExecuteReader(query);
            string password;
            if (id != null){
                _UserID = (int)id.Rows[0]["UserID"];
                password = id.Rows[0]["Password"].ToString();
            }
            else
                return UserType.None;//put a message please
            if (password != _UserPassword)
                return UserType.None;
            string chechpatient = $"select patientid from patient where patientid = {_UserID}";
            object patcheck = DataBase.Manager.ExecuteScalar(chechpatient);
            if (patcheck != null && patcheck != DBNull.Value){
                return UserType.Patient;}
            string chechdoctor = $"select doctorid from doctor where doctorid = {_UserID}";
            object doccheck = DataBase.Manager.ExecuteScalar(chechdoctor);
            if (doccheck != null && doccheck != DBNull.Value)
                return UserType.Doctor;
            string chechAdmin = $"select Adminid from admin where adminid = {_UserID}";
            object admcheck = DataBase.Manager.ExecuteScalar(chechAdmin);
            if (admcheck != null && admcheck != DBNull.Value)
                return UserType.Admin;
            string chechPHman = $"select ManagerID from PharmacyManager where ManagerID = {_UserID}";
            object manPHcheck = DataBase.Manager.ExecuteScalar(chechPHman);
            if (manPHcheck != null && manPHcheck != DBNull.Value)
                return UserType.PharmacyManager;
            string chechhosman = $"select ManagerID from HospitalManager where ManagerID = {_UserID}";
            object manhoscheck = DataBase.Manager.ExecuteScalar(chechhosman);
            if (manhoscheck != null && manhoscheck != DBNull.Value)
                return UserType.HospitalManager;
            return UserType.None;
        }
        public int SignUp() {
            string maxid = "select max(patientid) from patient";
            object id = DataBase.Manager.ExecuteScalar(maxid);
            if (id != null && id != DBNull.Value)
                _UserID = (int)id + 1;
            else
                return 0;

            string query = $"insert into sysuser values({_UserID}, '{_Email}' , '{_UserPassword}', {_Age}, '{_Gender}', '{_First_Name}', '{_Last_Name}'); ";
            int userRes = DataBase.Manager.ExecuteNonQuery(query);
            string patquery = $"insert into patient values({_UserID});";
            int patres = DataBase.Manager.ExecuteNonQuery(patquery);
            if (patres == 0 || userRes == 0)
                return 0;
            return 1;
        }

        //add more functions as u need
    }
}
