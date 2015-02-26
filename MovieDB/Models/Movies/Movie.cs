using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDB.Models.Movies
{
    public class Movie
    {
        public DateTime Released { get; set; }
        public string Plot { get; set; }
        public string Runtime { get; set; }

        public IList<string> Genres { get; set; }
        public IList<string> Directors { get; set; }
        public IList<string> Actors { get; set; }

        public IList<string> Countries { get; set; }

        public string PosterIMageUrl { get; set; }
    }
}