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

namespace HospitalMgmt.Pages.Medicine
{
    public class EditModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public EditModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Medicines Medicines { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicines = await _context.Medicines.FirstOrDefaultAsync(m => m.Medicine_Id == id);

            if (Medicines == null)
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

            _context.Attach(Medicines).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicinesExists(Medicines.Medicine_Id))
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

        private bool MedicinesExists(int id)
        {
            return _context.Medicines.Any(e => e.Medicine_Id == id);
        }
    }
}
