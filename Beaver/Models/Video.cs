using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beaver.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
    }
    public enum Genre
    {
        Comedy = 1,
        Horror,
        Scifi,
        Romance,
        Documentary,
        Kids
    }
}