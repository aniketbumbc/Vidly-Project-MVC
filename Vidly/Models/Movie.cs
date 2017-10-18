﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie

    {
        public int Id { get; set; }

        [Required]
        [StringLength (233)]
        public String Name { get; set; }

        public Genre Genre { get; set; }


        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set;}
        [Required]
        public DateTime AddedDate { get; set; }
        [Required]
        [Range(1, 20)]
        public int NumberStock { get; set; }

        //public byte NumberAvailable { get; set; }


    }

}