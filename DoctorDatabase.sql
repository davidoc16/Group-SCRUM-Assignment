--DocSYS.sql
DROP TABLE Doctor;


CREATE TABLE Doctor
(Doctor_ID numeric (6)NOT NULL,
Gender varchar(6),
Forename varchar(20) NOT NULL,
Surname varchar(20) NOT NULL,
Street varchar(30),
Town varchar(20),
County varchar(20),
DOB varchar(25),
Garda_Vetted char(1), 
CONSTRAINT pk_Doctor PRIMARY KEY (Doctor_ID));
