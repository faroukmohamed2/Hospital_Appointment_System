create database HospitalAppointmentSystemModified5
Go
use HospitalAppointmentSystemModified5
------------------------------------------------
/* Admin */
CREATE TABLE sysAdmin(
	AdminID int PRIMARY KEY,        
    Email VARCHAR(255) NOT NULL,    
    userPassword VARCHAR(36) NOT NULL, 
    Age INT,                       
    Gender CHAR(1),               
    FirstName VARCHAR(25),        
    LastName VARCHAR(25)
);

Create TABLE AdminReport(
	AdminID int DEFAULT 0,
	ReportNum int,
	Report varchar(2000),

	primary key (AdminID,ReportNum),
	foreign key (AdminID) references sysAdmin
		ON DELETE SET DEFAULT
		ON UPDATE CASCADE
);
------------------------------------------------
/* patient */
Create Table Patient(
	PatientID int primary key,        
    Email VARCHAR(255) NOT NULL,    
    userPassword VARCHAR(36) NOT NULL, 
    Age INT,                       
    Gender CHAR(1),               
    FirstName VARCHAR(25),        
    LastName VARCHAR(25)
);

Create Table MedicalHistory(
	PatientID int,
	DiseaseDescription varchar(100),
	AtYear int,
	IsCured varchar(1),

	primary key (PatientID,DiseaseDescription),
	foreign key (PatientID) references Patient
		ON DELETE CASCADE
		ON UPDATE CASCADE
);
CREATE TABLE Hospital(
	HospitalID INT PRIMARY KEY,
    PlaceName VARCHAR(40),        
    Email VARCHAR(255),                
    PhoneNumber VARCHAR(15),           
	StartingTime TIME,                 
    EndingTime TIME,                  
    IsAvailable varchar(1),   
    PlaceLocation VARCHAR(255),
	OpenDays varchar(21)
);

CREATE TABLE Pharmacy(
	PharmacyID INT PRIMARY KEY,
    PlaceName VARCHAR(40),        
    Email VARCHAR(255),                
    PhoneNumber VARCHAR(15),           
	StartingTime TIME,                 
    EndingTime TIME,                  
    IsAvailable varchar(1),   
    PlaceLocation VARCHAR(255),
	OpenDays varchar(21)
);

Create Table Department(
	DepartmentID int PRIMARY KEY,
	DepartmentName varchar(100)
);

Create Table HospitalDepartment(
	HospitalID int,
	DepartmentID int,
	DepartmentLocation varchar(255),

	primary key (HospitalID,DepartmentID),

	foreign key (HospitalID) references Hospital
		ON DELETE CASCADE
		ON UPDATE CASCADE,

	foreign key (DepartmentID) references Department
		ON DELETE CASCADE
		ON UPDATE CASCADE
);
------------------------------------------------
/* Doctor */
Create Table Doctor(
	DoctorID int primary key,
    Email VARCHAR(255) NOT NULL,    
    userPassword VARCHAR(36) NOT NULL, 
    Age INT,                       
    Gender CHAR(1),               
    FirstName VARCHAR(25),        
    LastName VARCHAR(25),
	ISAvailable varchar(1),
	DepartmentID int, 
	HospitalID int, 

	foreign key (HospitalID) references Hospital
		ON DELETE SET NULL
		ON UPDATE CASCADE,

	foreign key (DepartmentID) references Department
		ON DELETE SET NULL
		ON UPDATE CASCADE
);

Create Table Feedback(
	FeedbackID int PRIMARY KEY,
	DoctorID int,
	PatientID int,
	theFeedback varchar(2000),

	foreign key (DoctorID) references Doctor
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	
	foreign key (PatientID) references Patient
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	 
);

Create Table Clinc(
	ClincID int PRIMARY KEY,
	DoctorID int,

	foreign key (DoctorID) references Doctor
		ON DELETE SET NULL
		ON UPDATE CASCADE
);

Create Table ModifyingMedicalHistory(
	DoctorID int DEFAULT 0,
	PatientID int,
	DiseaseDescription varchar(100),

	primary key (DoctorID,PatientID,DiseaseDescription),
	foreign key (DoctorID) references Doctor
		ON DELETE SET DEFAULT
		ON UPDATE CASCADE,

	foreign key (PatientID,DiseaseDescription) references MedicalHistory
		ON DELETE CASCADE
		ON UPDATE CASCADE
);
------------------------------------------------
/* Manager */
Create Table HospitalManager(
	ManagerID int PRIMARY KEY,
	HospitalID int,
    Email VARCHAR(255) NOT NULL,    
    userPassword VARCHAR(36) NOT NULL, 
    Age INT,                       
    Gender CHAR(1),               
    FirstName VARCHAR(25),        
    LastName VARCHAR(25) ,
	
	foreign key (HospitalID) references Hospital
		ON DELETE SET NULL
		ON UPDATE CASCADE
);

Create Table PharmacyManager(
	ManagerID int PRIMARY KEY,
	PharmacyID int,        
    Email VARCHAR(255) NOT NULL,    
    userPassword VARCHAR(36) NOT NULL, 
    Age INT,                       
    Gender CHAR(1),               
    FirstName VARCHAR(25),        
    LastName VARCHAR(25),
	
	foreign key (PharmacyID) references Pharmacy
		ON DELETE SET NULL
		ON UPDATE CASCADE
);
------------------------------------------------
------------------------------------------------


CREATE TABLE PatientActivityLogs(
	patientID INT,
	DateAndTime DATETIME NOT NULL,
	ActivityType VARCHAR(25),
	primary key (PatientID,DateAndTime),
	foreign key (PatientID) REFERENCES Patient
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);
CREATE TABLE DoctorActivityLogs(
	DoctorID INT,
	DateAndTime DATETIME NOT NULL,
	ActivityType VARCHAR(25),
	primary key (DoctorID,DateAndTime),
	foreign key (DoctorID) REFERENCES Doctor
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);
CREATE TABLE AdminActivityLogs(
	AdminID INT,
	DateAndTime DATETIME NOT NULL,
	ActivityType VARCHAR(25),
	primary key (AdminID,DateAndTime),
	foreign key (AdminID) REFERENCES sysAdmin
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);
CREATE TABLE HospitalManagerActivityLogs(
	ManagerID INT,
	DateAndTime DATETIME NOT NULL,
	ActivityType VARCHAR(25),
	primary key (ManagerID,DateAndTime),
	foreign key (managerID) REFERENCES HospitalManager
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);
CREATE TABLE PharmacyManagerActivityLogs(
	ManagerID INT,
	DateAndTime DATETIME NOT NULL,
	ActivityType VARCHAR(25),
	primary key (ManagerID,DateAndTime),
	foreign key (ManagerID) REFERENCES PharmacyManager
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);

Create Table ClinicAppointment(
	ClinicAppointmentID int PRIMARY KEY,
	DateAndTime DATETIME NOT NULL UNIQUE,
	PatientID int,
	ClincID int,

	foreign key (PatientID) references Patient
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	foreign key (ClincID) references Clinc
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

Create Table HospitalAppointment(
	HospitalAppointmentID int PRIMARY KEY,
	DateAndTime DATETIME NOT NULL,
	DoctorID int,
	-- HospitalID int, --
	PatientID int,

	UNIQUE(DateAndTime,DoctorID),

	foreign key (PatientID) references Patient
		ON DELETE CASCADE
		ON UPDATE CASCADE,	
	
	foreign key (DoctorID) references Doctor
		ON DELETE CASCADE
		ON UPDATE CASCADE
	-- foreign key (HospitalID) references Hospital --
);

CREATE TABLE Bill(
	BillID int PRIMARY KEY,
	Price float,
	DateAndTime DATETIME,
	HospitalID int,
	PatientID int,
	IsPaid varchar(1),

	foreign key (HospitalID) references Hospital
		ON DELETE SET NULL
		ON UPDATE CASCADE,
	foreign key (PatientID) references Patient 
		ON DELETE CASCADE 
		ON UPDATE CASCADE
);


Create Table Prescription(
	PrescriptionID int PRIMARY KEY,
	DateAndTime DATETIME,
	DiseaseName varchar(30),
	PatientID int,
	DiseaseDescription varchar(100),
	DoctorID int,

	foreign key (PatientID) references Patient
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	
	foreign key (DoctorID) references Doctor
		ON DELETE SET NULL
		ON UPDATE CASCADE,

	/*foreign key (PatientID, DiseaseDescription) references MedicalHistory(paientID, DiseaseDescription)
		ON DELETE CASCADE
		ON UPDATE CASCADE*/
);

Create Table Medicine(
	MedicineID int PRIMARY KEY,
	MedicineName varchar(100),
	Active_Ingredinet varchar(100)
);

Create Table MedicinePrescription(
	MedicineID int,
	PrescriptionID int,
	Dose varchar(60),

	foreign key (MedicineID) references Medicine
		ON DELETE SET NULL
		ON UPDATE CASCADE,
	
	foreign key (PrescriptionID) references Prescription
		ON DELETE CASCADE
		ON UPDATE CASCADE	
);

Create Table StoreMedicine(
	MedicineID int,
	PharmacyID int,
	Quantity int,

	primary key (MedicineID,PharmacyID),
	foreign key (MedicineID) references Medicine
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	foreign key (PharmacyID) references Pharmacy
		ON DELETE CASCADE
		ON UPDATE CASCADE
);




