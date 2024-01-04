using ComicBookGallery.Data;
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
        private ComicBookRepository _comicBookRepository = new ComicBookRepository();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detalis()
        {
            return View(_comicBookRepository.GetComicBook());
        }
    }
}