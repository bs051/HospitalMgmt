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
    public class IndexModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public IndexModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        public IList<PatientDetails> PatientDetails { get;set; }

        public async Task OnGetAsync()
        {
            PatientDetails = await _context.PatientDetails.ToListAsync();
        }
    }
}
