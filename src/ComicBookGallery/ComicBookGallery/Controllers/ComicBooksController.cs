using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detalis()
        {
            var comicBook = new ComicBook
            {
                seriesTitle = "The Amazing Spider-Man",
                issueNumber = 700,
                descriptionHtml = "<p>Final issue! Witness...<strong>will Pete</strong></P>",
                Artists = new Artist[]
                {
                    new Artist{name="Dan Solt",role="Script"},
                    new Artist{name="Victor oro",role="Pencils"},
                    new Artist{name="chris brown",role="letters"},
                    new Artist{name="edgar obsa",role="Colors"}
                }
            };

            return View(comicBook);
        }
    }
}