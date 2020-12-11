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
    public class IndexModel : PageModel
    {
        private readonly HospitalMgmt.Data.HospitalMgmtContext _context;

        public IndexModel(HospitalMgmt.Data.HospitalMgmtContext context)
        {
            _context = context;
        }

        public IList<Appointments> Appointments { get;set; }

        public async Task OnGetAsync()
        {
            Appointments = await _context.Appointments.ToListAsync();
        }
    }
}
