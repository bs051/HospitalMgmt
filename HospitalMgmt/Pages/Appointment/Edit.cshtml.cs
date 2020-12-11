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

namespace HospitalMgmt.Pages.Appointment
{
    public class EditModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public EditModel(HospitalMgmt.Data.HospitalMgmtContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Appointments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppointmentsExists(Appointments.Appointment_Id))
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

        private bool AppointmentsExists(int id)
        {
            return _context.Appointments.Any(e => e.Appointment_Id == id);
        }
    }
}
