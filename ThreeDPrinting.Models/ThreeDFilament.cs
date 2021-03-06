﻿namespace ThreeDPrinting.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ThreeDFilament
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Make { get; set; }

        [Required]
        [MaxLength(100)]
        public string Color { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}