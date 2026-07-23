
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentRegistrationApp.Data;
using StudentRegistrationApp.Models;

namespace StudentRegistrationApp.Pages.Students
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> StudentList { get; set; } = default!;

        public async Task OnGetAsync()
        {
            StudentList = await _context.Students.ToListAsync();
        }
    }
}