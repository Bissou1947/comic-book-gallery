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
        private ComicBookRepository _comicBookRepository;
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
                return HttpNotFound();

            return View(_comicBookRepository.GetComicBook(id.Value));
        }
    }
}