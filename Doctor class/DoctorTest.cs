using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc_Sys
{
    class DoctorTest
    {
        public static void main(String[] args)
        {

            //test constructors
            Doctor d1 = new Doctor(2, "male", "Kyle", "Reese", "10 Main St.", "Tralee", "Kerry", "12/01/1950", 'y');
            Doctor d2 = new Doctor();
            //test set methods 
            Doctor d3 = new Doctor();
            d3.setDoctorID(3);
            d3.setGender("female");
            d3.setForename("Sarah");
            d3.setSurname("Connor");
            d3.setStreet("1 Long Avenue");
            d3.setTown("Bantry");
            d3.setCounty("Cork");
            d3.setDateofBirth("29/08/1997");
            d3.setGardaVetted('n');

            //get methods
            
            Console.Write(d3.getForename() + d3.getSurname());
        

           //test to string
            Console.Write(d1.toString() + "\n" + d2.toString());

        }
    }
}
