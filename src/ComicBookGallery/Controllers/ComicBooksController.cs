using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        private Data.ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new Data.ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            //pt ca am acolo sus ? dupa int nu pot folosi ca argument id, trebuie sa folosesc
            //(int)id sau id.Value
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }
    }
}