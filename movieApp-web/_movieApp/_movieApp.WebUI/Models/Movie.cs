using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _movieApp.WebUI.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime LoadTime { get; set; }
    }
}
