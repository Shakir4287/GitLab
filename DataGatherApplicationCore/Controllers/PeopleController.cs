using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataGatherApplicationCore.Models;

namespace DataGatherApplicationCore.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleContext _context;

        public PeopleController(PeopleContext context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            return View(await _context.peoples.ToListAsync());
        }

        // GET: People/Create
        public IActionResult AddOrEdit(int id=0)
        {
			if (id == 0)
			{
				return View(new People());
			}
			else
			{
				return View(_context.peoples.Find(id));
			}
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PeopleID,PeopleFirstName,PeopleLastName,PeopleProfession,PeoplePhoneNumber,PeopleAddress,PeopleCity,PeopleCountry")] People people)
        {
            if (ModelState.IsValid)
            {
				if (people.PeopleID == 0)
				{
					_context.Add(people);
				}
				else
				{
					_context.Update(people);
				}

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(people);
        }

 
        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
			var ppl = await _context.peoples.FindAsync(id);
			_context.peoples.Remove(ppl);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));

		}

       

       
    }
}
