using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamsWebApp.Data;

namespace TeamsWebApp.Controllers
{
    public class MessagesController : Controller
    {

        private readonly DataContext _context;

        public MessagesController(DataContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> ShowChats()
        {
            return View(await _context.tblDiscussion.OrderBy(d => d.DateTime).ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> ShowChats(DateTime? fromDate, DateTime? toDate)
        {
            var filteredData = await _context.tblDiscussion
                    .Where(d => d.DateTime >= fromDate && d.DateTime <= toDate)
                    .OrderBy(d => d.DateTime)
                    .ToListAsync();
            return View(filteredData);
        }

        private bool MessageExists(int id)
        {
            return _context.tblDiscussion.Any(e => e.MessageId == id);
        }
    }
}
