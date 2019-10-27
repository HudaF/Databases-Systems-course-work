CREATE DATABASE Hospital;
Go
USE  Hospital;
Go
CREATE TABLE Physician (
  EmployeeID INTEGER PRIMARY KEY NOT NULL,
  Name TEXT NOT NULL,
  Position TEXT NOT NULL,
  SSN INTEGER NOT NULL
); 

CREATE TABLE Department (
  DepartmentID INTEGER PRIMARY KEY NOT NULL,
  Name TEXT NOT NULL,
  Head INTEGER NOT NULL CONSTRAINT fk_Physician_Emp REFERENCES Physician(EmployeeID)
);

CREATE TABLE Affiliated_With (
  Physician INTEGER NOT NULL
    CONSTRAINT fk_Physician_EmpID REFERENCES Physician(EmployeeID),
  Department INTEGER NOT NULL
    CONSTRAINT fk_Department_DepartmentID REFERENCES Department(DepartmentID),
  PrimaryAffiliation BIT NOT NULL,
  PRIMARY KEY(Physician, Department)
);

CREATE TABLE [Procedure] (
  Code INTEGER PRIMARY KEY NOT NULL,
  Name TEXT NOT NULL,
  Cost REAL NOT NULL
);

CREATE TABLE Trained_In (
  Physician INTEGER NOT NULL CONSTRAINT fk_Physician_EmID REFERENCES Physician(EmployeeID),
  Treatment INTEGER NOT NULL CONSTRAINT fk_Procedure_Code REFERENCES [Procedure](Code),
  CertificationDate DATETIME NOT NULL,
  CertificationExpires DATETIME NOT NULL,
  PRIMARY KEY(Physician , Treatment)
);

CREATE TABLE Patient (
  SSN INTEGER PRIMARY KEY NOT NULL,
  Name TEXT NOT NULL,
  Address TEXT NOT NULL,
  Phone TEXT NOT NULL,
  InsuranceID INTEGER NOT NULL,
  PCP INTEGER NOT NULL
    CONSTRAINT fk_Physician_EID REFERENCES Physician(EmployeeID)
);



CREATE TABLE Appointment (
  AppointmentID INTEGER PRIMARY KEY NOT NULL,
  Patient INTEGER NOT NULL
    CONSTRAINT fk_Patient_SSN REFERENCES Patient(SSN),
  Physician INTEGER NOT NULL
    CONSTRAINT fk_Physician_Employee_ID REFERENCES Physician(EmployeeID),
  [StartDate] DATETIME NOT NULL,
  [EndDate] DATETIME NOT NULL,
  ExaminationRoom TEXT NOT NULL
);

CREATE TABLE Medication (
  Code INTEGER PRIMARY KEY NOT NULL,
  Name TEXT NOT NULL,
  Brand TEXT NOT NULL,
  Description TEXT NOT NULL
);

CREATE TABLE Prescribes (
  Physician INTEGER NOT NULL
    CONSTRAINT fk_Physician_ID REFERENCES Physician(EmployeeID),
  Patient INTEGER NOT NULL
    CONSTRAINT fk_Pat_SSN REFERENCES Patient(SSN),
  Medication INTEGER NOT NULL
    CONSTRAINT fk_Medication_Code REFERENCES Medication(Code),
  Date DATETIME NOT NULL,
  Appointment INTEGER
    CONSTRAINT fk_Appointment_AppointmentID REFERENCES Appointment(AppointmentID),
  Dose TEXT NOT NULL,
  PRIMARY KEY(Physician, Patient, Medication, Date)
);

CREATE TABLE [Block] (
  Floor INTEGER NOT NULL,
  Code INTEGER NOT NULL,
  PRIMARY KEY(Floor, Code)
); 

CREATE TABLE Room (
  Number INTEGER PRIMARY KEY NOT NULL,
  Type TEXT NOT NULL,
  BlockFloor INTEGER NOT NULL, 
  BlockCode INTEGER NOT NULL ,
  Unavailable BIT NOT NULL,
  CONSTRAINT fk_Block_FloorCode FOREIGN KEY (BlockFloor , BlockCode) REFERENCES Block(Floor,Code)
);



CREATE TABLE Stay (
  StayID INTEGER PRIMARY KEY NOT NULL,
  Patient INTEGER NOT NULL
    CONSTRAINT fk_PatientSSN REFERENCES Patient(SSN),
  Room INTEGER NOT NULL
    CONSTRAINT fk_Room_Number REFERENCES Room(Number),
  StartDate DATETIME NOT NULL,
  EndDate DATETIME NOT NULL
);

CREATE TABLE Undergoes (
  Patient INTEGER NOT NULL
    CONSTRAINT fk_P_SSN REFERENCES Patient(SSN),
  [Procedure] INTEGER NOT NULL
    CONSTRAINT fk_Proced_Code REFERENCES [Procedure](Code),
  Stay INTEGER NOT NULL
    CONSTRAINT fk_Stay_StayID REFERENCES Stay(StayID),
  Date DATETIME NOT NULL,
  Physician INTEGER NOT NULL
    CONSTRAINT fk_Physician_EmployeeID REFERENCES Physician(EmployeeID),
  PRIMARY KEY(Patient, [Procedure], Stay, Date)
);