using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMgmt.Models
{
    public class Medicines
    {

        [Key]

        public int Medicine_Id { get; set; } // This is the primary key



        public string Medicine_Name{ get; set; } // medicine name

        public string Price { get; set; } // medicine price



        public string Quantity { get; set; } // Quantity of medicine



        public string Disease { get; set; } // Disease of medicines



        // Foreign Key



        public int Doctor_ID { get; set; }



        public Doctor Doctor_obj { get; set; }
    }
}
