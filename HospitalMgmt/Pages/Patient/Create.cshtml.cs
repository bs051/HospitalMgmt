﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HospitalMgmt.Data;
using HospitalMgmt.Models;

namespace HospitalMgmt.Pages.Patient
{
    public class CreateModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public CreateModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PatientDetails PatientDetails { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PatientDetails.Add(PatientDetails);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
