using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDB.Models.Movies
{
    public class Latest
    {
        public IList<Movie> latestMovies { get; set; }
    }
}