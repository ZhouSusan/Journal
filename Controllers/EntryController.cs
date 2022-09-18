using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Journal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Journal.Controllers
{
    public class EntryController : Controller
    {
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool loggedIn 
        {
            get{
                return uid != null;
            }
        }

        private JournalContext db;
        public EntryController( JournalContext context)
        {
            db = context;
        }

        [HttpGet("/entries/all")]
        public IActionResult All()
        {
            if (!loggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            int ? userId = HttpContext.Session.GetInt32("UserId");
            ViewBag.CurrentUser = db.Users.
                                FirstOrDefault(u => u.UserId == userId);
            List <Entry> AllEntries = db.Entries
                                .Where(p => p.UserId == userId).ToList();
            return View("All", AllEntries);
        }

    [HttpGet("/entries/{entryId}")]
        public IActionResult Details(int entryId)
        {
            if (!loggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Entry entry = db.Entries
                .FirstOrDefault(e => e.EntryId == entryId);

            if (entry == null)
            {
                return RedirectToAction("All");
            }

            return View("Detail", entry);
        }

        [HttpGet("/entries/new")]
        public IActionResult New()
        {
            if (!loggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("New");
        }

        [HttpPost("/entries/create")]
        public IActionResult Create(Entry newEntry)
        {
            if (ModelState.IsValid == false)
            {
                return View("New");
            }

            newEntry.UserId = (int)uid;
            db.Entries.Add(newEntry);
            db.SaveChanges();
            return RedirectToAction("Details", new { entryId = newEntry.EntryId });
        }

    }
}
