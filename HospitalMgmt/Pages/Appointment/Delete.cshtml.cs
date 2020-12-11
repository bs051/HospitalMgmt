using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalMgmt.Data;
using HospitalMgmt.Models;

namespace HospitalMgmt.Pages.Appointment
{
    public class DeleteModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public DeleteModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Appointments Appointments { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointments = await _context.Appointments.FirstOrDefaultAsync(m => m.Appointment_Id == id);

            if (Appointments == null)
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

            Appointments = await _context.Appointments.FindAsync(id);

            if (Appointments != null)
            {
                _context.Appointments.Remove(Appointments);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
