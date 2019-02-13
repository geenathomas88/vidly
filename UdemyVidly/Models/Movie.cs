﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UdemyVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }
    }
}