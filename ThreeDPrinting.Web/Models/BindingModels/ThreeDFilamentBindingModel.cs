﻿namespace ThreeDPrinting.Web.Models.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class ThreeDFilamentBindingModel
    {
        [Required]
        [StringLength(100)]
        public string Make { get; set; }

        [Required]
        [StringLength(100)]
        public string Color { get; set; }

        [Range(0, double.MaxValue)]
        [Display(Name = "Price in Euro")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; set; }
    }
}
