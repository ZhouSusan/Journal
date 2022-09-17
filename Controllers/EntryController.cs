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
        private JournalContext db;
        public EntryController( JournalContext context)
        {
            db = context;
        }

        [HttpGet("/entries/all")]
        public IActionResult All()
        {
            return View("All");
        }
    }
}
