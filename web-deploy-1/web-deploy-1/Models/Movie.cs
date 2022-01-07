using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_deploy_1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
        

    }
}