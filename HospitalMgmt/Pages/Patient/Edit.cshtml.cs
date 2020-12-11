using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalMgmt.Data;
using HospitalMgmt.Models;

namespace HospitalMgmt.Pages.Patient
{
    public class EditModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public EditModel(HospitalMgmt.Data.HospitalMgmtContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PatientDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientDetailsExists(PatientDetails.Patient_Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PatientDetailsExists(int id)
        {
            return _context.PatientDetails.Any(e => e.Patient_Id == id);
        }
    }
}
