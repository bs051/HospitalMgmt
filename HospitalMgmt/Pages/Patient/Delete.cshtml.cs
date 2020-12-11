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
    public class DeleteModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public DeleteModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PatientDetails = await _context.PatientDetails.FindAsync(id);

            if (PatientDetails != null)
            {
                _context.PatientDetails.Remove(PatientDetails);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
