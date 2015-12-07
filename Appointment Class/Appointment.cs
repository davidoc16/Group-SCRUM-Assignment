using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc_Sys
{
    class Appointment
    {
        private int appointmentID;
        private int patientID;
        private int doctorID;
        private String appointmentDate; // DateTime?
        private String appointmentTime; // DateTime?
        

        private static int nextId = 1;
        

        //constructors
        public Appointment()
        {
            setAppointmentID(getNextId());
            setPatientID(0);
            setDoctorID(0);            
            setAppointmentDate("");
            setAppointmentTime("");
            
        }


        public Appointment(int appointmentID, int patientID, int doctorID, String appointmentDate, String appointmentTime)
        {
            setAppointmentID(getNextId());
            setPatientID(patientID);
            setDoctorID(doctorID);
            setAppointmentDate(appointmentDate);
            setAppointmentTime(appointmentTime);
            
        }

        //setters
        public void setAppointmentID(int appointmentID)
        {
            this.appointmentID = appointmentID;
        }

         public void setPatientID(int patientID)
        {
            this.patientID = patientID;
        }

        public void setDoctorID(int doctorID)
        {
            this.doctorID = doctorID;
        }

        public void setAppointmentDate(String appointmentDate)
        {
            this.appointmentDate = appointmentDate;
        }

        public void setAppointmentTime(String appointmentTime)
        {
            this.appointmentTime = appointmentTime;
        }

        /**
     * can overrule the automatic numbering sequence
      */
        public static void setNextId(int nextId)
        {
            Appointment.nextId = nextId;
        }

        //getters
        public int getAppointmentID()
        {
            return appointmentID;
        }

        public int getPatientID()
        {
            return patientID;
        }

        public int getDoctorID()
        {
            return doctorID;
        }

        public String getAppointmentDate()
        {
            return appointmentDate;
        }

    

        public String getAppointmentTime()
        {
            return appointmentTime;
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


        //toString    
        public String toString()
        {
            return "AppointmentID: " + getAppointmentID()
                + "\nPatientID: " + getPatientID()
                + "\nDoctorID: " + getDoctorID()
                + "\nAppointment Date: " + getAppointmentDate()
                + "\nAppointment Time: " + getAppointmentTime();
        }
    }
}