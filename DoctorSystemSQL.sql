DROP TABLE APPOINTMENTS;
DROP TABLE DOCTORS;
DROP TABLE PATIENTS;
DROP TABLE POSS_TIMES;

CREATE TABLE Doctors
(Doctor_ID numeric (6)NOT NULL,
Gender varchar(6),
Forename varchar(20) NOT NULL,
Surname varchar(20) NOT NULL,
Street varchar(30),
Town varchar(20),
County varchar(20),
DOB Date,
Garda_Vetted char(1), 
CONSTRAINT pk_Doctor PRIMARY KEY (Doctor_ID));

INSERT INTO DOCTORS
VALUES (1001, 'MALE', 'John', 'Smith', 'aaa', 'bbb', 'ccc','12-JAN-75', 'y'); 


CREATE TABLE Patients
(Patient_ID numeric (6) NOT NULL,
Gender varchar(6),
Forename varchar(20) NOT NULL,
Surname varchar(20) NOT NULL,
Street varchar(30),
Town varchar(20),
County varchar(20),
DOB Date,
CONSTRAINT pk_Patient PRIMARY KEY (Patient_ID)); 

INSERT INTO PATIENTS
VALUES (1001, 'MALE', 'John', 'Smith', 'aaa', 'bbb', 'ccc','12-JAN-75'); 


CREATE TABLE Appointments
(App_ID numeric (6) NOT NULL,
Patient_ID numeric (6) NOT NULL,
Doctor_ID numeric (6) NOT NULL,
App_Time varchar (20),
App_Date Date,
CONSTRAINT pk_Appoint PRIMARY KEY (App_ID),
CONSTRAINT fk_Appoint FOREIGN KEY (Patient_ID) REFERENCES Patients(Patient_ID),
CONSTRAINT fk_Appoints FOREIGN KEY (Doctor_ID) REFERENCES Doctors(Doctor_ID));

INSERT INTO APPOINTMENTS 
VALUES (0001, 1001, 1001, '11:30', '30-APR-15');

--DROP TABLE POSS_TIMES;

  CREATE TABLE POSS_TIMES 
   (	APP_TIME CHAR(5 BYTE) NOT NULL ENABLE, 
	 CONSTRAINT "POSS_TIMES_PK" PRIMARY KEY ("APP_TIME"));
   
   INSERT INTO POSS_TIMES
   Values('10:00');
   INSERT INTO POSS_TIMES
   Values('10:30');
   INSERT INTO POSS_TIMES
   Values('11:00');
   INSERT INTO POSS_TIMES
   Values('11:30');
   INSERT INTO POSS_TIMES
   Values('12:00');
   INSERT INTO POSS_TIMES
   Values('12:30');
   INSERT INTO POSS_TIMES
   Values('14:00');
   INSERT INTO POSS_TIMES
   Values('14:30');
   INSERT INTO POSS_TIMES
   Values('15:00');
   INSERT INTO POSS_TIMES
   Values('15:30');
   INSERT INTO POSS_TIMES
   Values('16:00');
   INSERT INTO POSS_TIMES
   Values('16:30');
   
  
  commit;
  