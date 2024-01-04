using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int id { get; set; }
        public int issueNumber { get; set; }
        public string seriesTitle { get; set; }
        public string descriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool favorite { get; set; }

        public string displayText
        {
            get
            {
                return seriesTitle + " #" + issueNumber;
            }
        }

        public string coverImageFileName
        {
            get
            {
                return seriesTitle.Replace(" ", "-").ToLower() +
                    "-" + issueNumber + ".jpg";
            }
        }
    }
}