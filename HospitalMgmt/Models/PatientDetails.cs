using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMgmt.Models
{
    public class PatientDetails
    {
        [Key]

        public int Patient_Id { get; set; } // This is the primary key



        public string Patient_Name { get; set; } // this is the name of patient



        public string Patient_Address { get; set; } // this is the  patient address



        public string Patient_Mobile { get; set; } // this is pateint mobile



        public string Patient_Email { get; set; } // this is patient email



        public string Patient_Age { get; set; } // patient age

        //foreign key





        public int Appointments_ID { get; set; }



        public Appointments Appointment_obj { get; set; }
    }
}
