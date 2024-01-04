using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        public ComicBook GetComicBook()
        {
            var comicBook = new ComicBook
            {
                seriesTitle = "The Amazing Spider-Man",
                issueNumber = 700,
                descriptionHtml = "<p>Final issue! Witness asdasd asfqwf asdasdasw safsda adasd ...<strong>will Pete</strong></P>",
                Artists = new Artist[]
                {
                    new Artist{name="Dan Solt",role="Script"},
                    new Artist{name="Victor oro",role="Pencils"},
                    new Artist{name="chris brown",role="letters"},
                    new Artist{name="edgar obsa",role="Colors"}
                }
            };

            return comicBook;
        }
    }
}