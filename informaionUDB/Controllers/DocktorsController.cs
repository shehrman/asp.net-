using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using informaionUDB.Data;
using informaionUDB.Data.Model;
using informaionUDB.Data.Interface;

namespace informaionUDB.Controllers
{
    public class DocktorsController : Controller
    {
        private readonly IDocktorRepository _docktorRepository;
        public DocktorsController(IDocktorRepository docktorRepository)
        {
            _docktorRepository = docktorRepository;
        }

        // GET: Docktors
        public IActionResult Index()
        {
            var model = _docktorRepository.GetAll();

            return View(model);
        }

        // GET: Docktors/Details/5
        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docktor =  _docktorRepository.GetById(id);
                
            if (docktor == null)
            {
                return NotFound();
            }

            return View(docktor);
        }

        // GET: Docktors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Docktors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create( Docktor docktor)
        {
            if (ModelState.IsValid)
            {
                _docktorRepository.Create(docktor);
                return RedirectToAction(nameof(Index));
            }
            return View(docktor);
        }

        // GET: Docktors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var docktor = await _context.Docktors.FindAsync(id);
            //if (docktor == null)
            //{
            //    return NotFound();
            //}
            return View(/*docktor*/);
        }

        // POST: Docktors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Docktor docktor)
        {
            //if (id != docktor.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(docktor);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!DocktorExists(docktor.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            return View(/*docktor*/);
        }

        // GET: Docktors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var docktor = await _context.Docktors
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (docktor == null)
            //{
            //    return NotFound();
            //}

            return View(/*docktor*/);
        }

        // POST: Docktors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var docktor = await _context.Docktors.FindAsync(id);
            //_context.Docktors.Remove(docktor);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return null;
        }

        private bool DocktorExists(int id)
        {
            //return _context.Docktors.Any(e => e.Id == id);
            return false;
        }
    }
}
