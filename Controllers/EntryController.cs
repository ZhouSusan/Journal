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
                                .Include(c => c.CreatedAt)
                                .Where(p => p.UserId == userId).ToList();
            return View("All", AllEntries);
        }
    }
}
