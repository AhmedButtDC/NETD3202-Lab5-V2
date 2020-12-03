using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETD3202_Lab5_V2.Models;

namespace NETD3202_Lab5_V2.Controllers
{
    public class MoreDetailsController : Controller
    {
        private readonly VideoGameContext _context;

        public MoreDetailsController(VideoGameContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.MoreDetails.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moreDetails = await _context.MoreDetails
                .FirstOrDefaultAsync(m => m.gID == id);
            if (moreDetails == null)
            {
                return NotFound();
            }

            return View(moreDetails);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("gID,description")] MoreDetail moreDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moreDetail);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    return RedirectToAction(nameof(UnknownID));
                }
                return RedirectToAction(nameof(Index));
            }
            return View(moreDetail);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moreDetail = await _context.MoreDetails.FindAsync(id);

            if (moreDetail == null)
            {
                return NotFound();
            }

            return View(moreDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("gID,description")] MoreDetail moreDetail)
        {
            if (id != moreDetail.gID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(moreDetail);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoreDetailExists(moreDetail.gID))
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
            return View(moreDetail);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moreDetail = await _context.MoreDetails
                .FirstOrDefaultAsync(m => m.gID == id);
            if (moreDetail == null)
            {
                return NotFound();
            }

            return View(moreDetail);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moreDetail = await _context.MoreDetails.FindAsync(id);
            _context.MoreDetails.Remove(moreDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UnknownID()
        {
            return View();
        }

        private bool MoreDetailExists(int id)
        {
            return _context.MoreDetails.Any(e => e.gID == id);
        }
    }
}
