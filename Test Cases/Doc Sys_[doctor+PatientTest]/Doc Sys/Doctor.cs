﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc_Sys
{
    class Doctor
    {
        private int doctorID;
        private String gender;
        private String forename;
        private String surname;
        private String street;
        private String town;
        private String county;
        private String dateOfBirth; //would be better as DateTime variable
        private Boolean gardaVetted;

        private static int nextId = 1;

        //constructors
        public Doctor()
        {
            setDoctorID(getNextId());
            setGender("");
            setForename("");
            setSurname("");
            setStreet("");
            setTown("");
            setCounty("");
            setDateofBirth("");
            setGardaVetted(false);
        }


        public Doctor(int doctorID, String gender, String forename, String surname, String street, String town, String county, String dateOfBirth, Boolean gardaVetted)
        {
            setDoctorID(getNextId());
            setGender(gender);
            setForename(forename);
            setSurname(surname);
            setStreet(street);
            setTown(town);
            setCounty(county);
            setDateofBirth(dateOfBirth);
            setGardaVetted(gardaVetted);
        }

        //setters
        public void setDoctorID(int doctorID)
        {
            this.doctorID = doctorID;
        }

        public void setGender(String gender)
        {
            this.gender = gender;
        }

        public void setForename(String forename)
        {
            this.forename = forename;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public void setTown(String town)
        {
            this.town = town;
        }

        public void setCounty(String county)
        {
            this.county = county;
        }

        public void setDateofBirth(String dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        /**
     * can overrule the automatic numbering sequence
      */
        public static void setNextId(int nextId)
        {
            Doctor.nextId = nextId;
        }

        //getters
        public int getDoctorID()
        {
            return doctorID;
        }

        public String getGender()
        {
            return gender;
        }

        public String getForename()
        {
            return forename;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getStreet()
        {
            return street;
        }

        public String getTown()
        {
            return town;
        }

        public String getCounty()
        {
            return county;
        }

        public String getDateOfBirth()
        {
            return dateOfBirth;
        }

        /**
     * returns the next available id number
     */
        public static int getNextId()
        {
            int id = nextId;
            nextId++;
            return id;
        }

        //garda vetted
        public void setGardaVetted(Boolean gardaVetted)
        {
            this.gardaVetted = gardaVetted;
        }


        public Boolean isGardaVetted()
        {
            return gardaVetted;
        }


        //toString    
        public String toString()
        {
            return "DoctorId: " + getDoctorID()
                + "Gender: " + getGender()
                + "\nForename: " + getForename()
                + "\nSurname: " + getSurname()
                + "\nAddress: Street: " + getStreet()
                + "\nTown: " + getTown()
                + "\nCounty: " + getCounty()
                + "\nD.O.B.: " + getDateOfBirth()
                + "\nGarda Vetted: " + isGardaVetted();
        }
    }
}
