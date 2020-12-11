using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalMgmt.Data;
using HospitalMgmt.Models;

namespace HospitalMgmt.Pages.Patient
{
    public class DetailsModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public DetailsModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        public PatientDetails PatientDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PatientDetails = await _context.PatientDetails.FirstOrDefaultAsync(m => m.Patient_Id == id);

            if (PatientDetails == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
