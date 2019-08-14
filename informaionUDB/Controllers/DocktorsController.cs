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
    // Controller is a class that handles user requests . it retrieves data from the model and renders view as response .... 
    // the asp.net mvc framework maps requested urls to the classes that are referred to as controllers .
    // controller 
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
        public  IActionResult Details(int id)
        {

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
        public IActionResult Edit(int id)
        {
          
            var docktor =  _docktorRepository.Find(x=> x.Id==id).FirstOrDefault();
            if (docktor == null)
            {
                return NotFound();
            }
            return View(docktor);
        }

        // POST: Docktors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Edit(Docktor docktor)
        {
            _docktorRepository.Update(docktor);
             return RedirectToAction(nameof(Index));
        }

        // GET: Docktors/Delete/5
        public  IActionResult Delete(int id)
        {
          

            var docktor =  _docktorRepository.GetById(id);

            if (docktor == null)
            {
                return NotFound();
            }
            return View(docktor);
        }

        // POST: Docktors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
            var docktor = _docktorRepository.GetById(id);
            _docktorRepository.Delete(docktor);
            return RedirectToAction(nameof(Index));
        }

        private bool DocktorExists(int id)
        {
            //return _context.Docktors.Any(e => e.Id == id);
            return false;
        }
    }
}
