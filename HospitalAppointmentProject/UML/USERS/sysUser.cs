using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointmentProject.UML.USERS
{
    enum UserType { None,Patient,Doctor,Manager,Admin };
    internal class sysUser
    {
        
        public UserType user_type;

        private int? _UserID;
        private string _Email;
        private string _UserPassword;
        private int? _Age;
        private char? _Gender;
        private string _First_Name;
        private string _Last_Name;
        private List<ActivityLog> _ActivityLogs;

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

        public void LogIn() {}
        public void SignUp() {}

        //add more functions as u need
    }
}
