using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDB.Models.TVSeries
{
    public class TVSeries
    {

        public DateTime Released { get; set; }
        public string Runtime { get; set; }
        public IList<string> Genres { get; set; }
        public IList<string> Directors { get; set; }
        public IList<string> Actors { get; set; }
    }
}