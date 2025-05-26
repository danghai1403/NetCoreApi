using System.Net.Mime;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbcontext context);
        {
            _context = context;
        }
        public PersonController(ApplicationDbContext context);
        public async Task<IActionResult> Index()
        {
            var model = await _context.Person.ToListAsync();
            rerturn View(model);
        }
        public IActionResult Creat()
        {
            return View();
        }
        [HttpoPost]
        [ValidateAntiforgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,FullName,Address")] Person person)
        {
            if (ModelState.IsvaValid)
            {
                _context.Add(person);
            
                awit _ context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            }
            return View(person);
        }
        public async Task<IActionResult> Edit(string id)
         {

         }
        [HttpPost]
        [ValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,FullName,Address")] Person person)
        public async Task<IActionResult> Delete(string id)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiforgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        private bool PersonExists(string id)
    }
}
        
