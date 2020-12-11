using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HospitalMgmt.Data;
using HospitalMgmt.Models;

namespace HospitalMgmt.Pages.Medicine
{
    public class DetailsModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public DetailsModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

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
    }
}
