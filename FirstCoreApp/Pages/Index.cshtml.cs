using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FirstCoreApp.Pages
{
    public class IndexModel : PageModel
    {
     public AppDbContext _db;
        public IList<Employee> Employees { set; get; }
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }
        
        public async Task OnGetAsync()
        {
            Employees = await _db.Employees.AsNoTracking().ToListAsync();
        }
    }
}
