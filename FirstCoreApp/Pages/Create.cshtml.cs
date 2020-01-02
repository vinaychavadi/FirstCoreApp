using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstCoreApp.Pages
{
    public class CreateModel : PageModel
    {
        public AppDbContext _db;
        [BindProperty]
        public Employee Employee { set; get; }
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Employees.Add(Employee);
            await _db.SaveChangesAsync();
           // Message = $"Customer {Employee.name} is added!!";
            //_log.LogCritical(Message);
            return RedirectToPage("/Index");
        }
    }
}