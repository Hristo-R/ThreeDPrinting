﻿namespace ThreeDPrinting.Web.Models.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class ThreeDScannerBindingModel
    {
        [Required]
        [MaxLength(100)]
        public string Make { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [Display(Name = "Price in Euro")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Working Range")]
        [StringLength(50)]
        public string WorkingRange { get; set; }

        [Required]
        [Display(Name = "Depth Image Size")]
        [StringLength(50)]
        public string DepthImageSize { get; set; }

        [Required]
        [StringLength(6000)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; set; }
    }
}
