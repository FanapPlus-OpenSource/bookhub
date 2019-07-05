using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookHubDbContext _context;

        public BooksController(BookHubDbContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            return View(await _context.LiteratureSet.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var literature = await _context.LiteratureSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (literature == null)
            {
                return NotFound();
            }

            return View(literature);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Author,Translator,Type")] Literature literature)
        {
            if (ModelState.IsValid)
            {
                _context.Add(literature);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(literature);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var literature = await _context.LiteratureSet.FindAsync(id);
            if (literature == null)
            {
                return NotFound();
            }
            return View(literature);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Author,Translator,Type")] Literature literature)
        {
            if (id != literature.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(literature);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiteratureExists(literature.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(literature);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var literature = await _context.LiteratureSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (literature == null)
            {
                return NotFound();
            }

            return View(literature);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var literature = await _context.LiteratureSet.FindAsync(id);
            _context.LiteratureSet.Remove(literature);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiteratureExists(int id)
        {
            return _context.LiteratureSet.Any(e => e.Id == id);
        }
    }
}
