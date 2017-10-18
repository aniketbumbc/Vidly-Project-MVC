﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(233)]
        public string Name { get; set; }

        //public Genre Genre { get; set; }


        [Required]
        public int GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }
        public GenreDto Genre { get; set; }
        public DateTime AddedDate { get; set; }
        [Required]
        [Range(1, 20)]
        public int NumberStock { get; set; }
    }
}