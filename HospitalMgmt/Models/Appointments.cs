using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMgmt.Models
{
    public class Appointments
    {


        [Key]

        public int Appointment_Id { get; set; } // This is the primary key

        public string Patient_Name { get; set; } // patient name

        public string Doctor_Name { get; set; } // patient address


        public DateTime Date { get; set; } // this is appointment date


    }
}
