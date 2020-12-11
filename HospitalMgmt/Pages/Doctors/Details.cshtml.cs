using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalMgmt.Data;
using HospitalMgmt.Models;

namespace HospitalMgmt.Pages.Doctors
{
    public class DetailsModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public DetailsModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        public Doctor Doctor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctor = await _context.Doctor.FirstOrDefaultAsync(m => m.Doctor_Id == id);

            if (Doctor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
