using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMgmt.Models
{
    public class Doctor
    {
        [Key]

        public int Doctor_Id { get; set; }// This is the primary key

        public string Doctor_Name { get; set; } // this is the doctor_name

        public string Specialists { get; set; } // doctor specialists for disease

        public string Availability { get; set; } // availabality of doctor
      


        //foreign key





        public int Patient_ID { get; set; }



        public PatientDetails Patient_obj { get; set; }


    }
}
