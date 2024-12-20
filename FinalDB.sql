create database HospitalAppointmentSystem
use HospitalAppointmentSystem 
Go

SELECT * FROM sys.foreign_keys

CREATE TABLE sysUSER (
    UserID INT PRIMARY KEY,        
    Email VARCHAR(255) NOT NULL,    
    userPassword VARCHAR(36) NOT NULL, 
    Age INT,                       
    Gender CHAR(1),               
    FirstName VARCHAR(25),        
    LastName VARCHAR(25)          
);

CREATE TABLE ActivityLogs(
	UserID INT,
	DateAndTime DATETIME NOT NULL,
	ActivityType VARCHAR(25),
	primary key (UserID,DateAndTime),
	foreign key (UserID) REFERENCES sysUser 
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE sysAdmin(
	AdminID int PRIMARY KEY,
	foreign key (AdminID) references sysUSER
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

Create Table Patient(
	PatientID int primary key,
	foreign key (PatientID) references sysUser
		ON DELETE CASCADE
		ON UPDATE CASCADE
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

CREATE TABLE Place (
    PlaceID INT PRIMARY KEY,           
    PlaceName VARCHAR(40),        
    Email VARCHAR(255),                
    PhoneNumber VARCHAR(15),           
	StartingTime TIME,                 
    EndingTime TIME,                  
    IsAvailable varchar(1),   
    PlaceLocation VARCHAR(255),
	OpenDays varchar(21)
);

CREATE TABLE Hospital(
	HospitalID INT PRIMARY KEY,
	foreign key (HospitalID) references place
);

CREATE TABLE Pharmacy(
	PharmacyID INT PRIMARY KEY,
	foreign key (PharmacyID) references place
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

Create Table Doctor(
	DoctorID int primary key,
	ISAvailable varchar(1),
	DepartmentID int, 
	HospitalID int, 

	foreign key (DoctorID) references sysUser
		ON DELETE CASCADE
		ON UPDATE CASCADE,

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
		ON DELETE NO ACTION --CASCADE
		ON UPDATE NO ACTION --CASCADE
	 
);


CREATE TRIGGER trg_cascade_delete
ON Patient
FOR DELETE
AS
BEGIN
    DELETE FROM Feedback WHERE PatientID IN (SELECT PatientID FROM DELETED);
END;


Create Table Clinic(
	ClinicID int PRIMARY KEY,
	DoctorID int,

	foreign key (DoctorID) references Doctor
		ON DELETE SET NULL
		ON UPDATE CASCADE
);

Create Table ModifyingMedicalHistory(
	DoctorID int,
	PatientID int,
	DiseaseDescription varchar(100),

	primary key (DoctorID,PatientID,DiseaseDescription),

	foreign key (PatientID,DiseaseDescription) references MedicalHistory
		ON DELETE CASCADE
		ON UPDATE CASCADE,

		foreign key (DoctorID) references Doctor
		ON DELETE NO ACTION --CASCADE
		ON UPDATE NO ACTION --CASCADE
);

CREATE TRIGGER trg_delete_doctor
ON Doctor
FOR DELETE
AS
BEGIN
    DELETE FROM ModifyingMedicalHistory 
    WHERE DoctorID IN (SELECT DoctorID FROM DELETED);
END;



Create Table HospitalManager(
	ManagerID int PRIMARY KEY,
	HospitalID int,

	foreign key (ManagerID) references sysUser 
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	
	foreign key (HospitalID) references Hospital
		ON DELETE SET NULL
		ON UPDATE CASCADE
);

Create Table PharmacyManager(
	ManagerID int PRIMARY KEY,
	PharmacyID int,

	foreign key (ManagerID) references sysUser 
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	
	foreign key (PharmacyID) references Pharmacy
		ON DELETE SET NULL
		ON UPDATE CASCADE
);

Create Table ClinicAppointment(
	ClinicAppointmentID int PRIMARY KEY,
	DateAndTime DATETIME NOT NULL UNIQUE,
	PatientID int,
	ClinicID int,

	foreign key (ClinicID) references Clinic
		ON DELETE CASCADE
		ON UPDATE CASCADE,
		
	foreign key (PatientID) references Patient
		ON DELETE NO ACTION --CASCADE
		ON UPDATE NO ACTION --CASCADE
);

CREATE TRIGGER trg_delete_patient
ON Patient
FOR DELETE
AS
BEGIN
    DELETE FROM ClinicAppointment 
    WHERE PatientID IN (SELECT PatientID FROM DELETED);
END;

Create Table HospitalAppointment(
	HospitalAppointmentID int PRIMARY KEY,
	DateAndTime DATETIME NOT NULL,
	DoctorID int,
	PatientID int,

	UNIQUE(DateAndTime,DoctorID),

	
	foreign key (PatientID) references Patient
		ON DELETE CASCADE
		ON UPDATE CASCADE,	
	
	foreign key (DoctorID) references Doctor
		ON DELETE NO ACTION --CASCADE
		ON UPDATE NO ACTION --CASCADE
);

CREATE TRIGGER trg_delete_doctor_hospital_appointment
ON Doctor
FOR DELETE
AS
BEGIN
    DELETE FROM HospitalAppointment
    WHERE DoctorID IN (SELECT DoctorID FROM DELETED);
END;



CREATE TABLE Bill(
	BillID int PRIMARY KEY,
	Price float,
	DateAndTime DATETIME,
	PlaceID int,
	PatientID int,
	IsPaid varchar(1),

	foreign key (PlaceID) references Place
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
	
	foreign key (DoctorID) references Doctor
		ON DELETE SET NULL
		ON UPDATE CASCADE,

	foreign key (PatientID,DiseaseDescription) references MedicalHistory
		ON DELETE NO ACTION --CASCADE
		ON UPDATE NO ACTION	--CASCADE
);

CREATE TRIGGER trg_delete_medical_history
ON MedicalHistory
FOR DELETE
AS
BEGIN
    DELETE FROM Prescription
    WHERE PatientID IN (SELECT PatientID FROM DELETED)
      AND DiseaseDescription IN (SELECT DiseaseDescription FROM DELETED);
END;
GO



Create Table Medicine(
	MedicineID int PRIMARY KEY,
	MedicineName varchar(100),
	Active_Ingredinet varchar(100)
);

Create Table MedicinePrescription(
	MedicineID int,
	PrescriptionID int,
	Dose varchar(60),

	primary key (MedicineID,PrescriptionID);
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

-- the final trigger wont work the logic would be implimented in C#

