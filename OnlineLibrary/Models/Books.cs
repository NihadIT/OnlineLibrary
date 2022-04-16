using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Books
    {
        [Key]
        public int IdBook { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public int ReleaseDate { get; set; }
        public int? Favorites { get; set; }
        public string? Url { get; set; }
    }
}
