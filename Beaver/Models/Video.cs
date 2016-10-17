using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beaver.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}