using System;
using System.Collections.Generic;

namespace TestSQLDatabase.Models
{
    public partial class MovieList
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int? Rating { get; set; }
        public int? ReleaseYear { get; set; }
        public string ImdbLink { get; set; }
    }
}
