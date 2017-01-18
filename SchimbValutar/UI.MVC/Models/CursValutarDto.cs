using System;
using System.ComponentModel.DataAnnotations;

namespace UI.MVC.Models
{
    public class CursValutarDto
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "One Euro to Ron")]
        public float BuyingEuroToRon { get; set; }

        [Required]
        [Display(Name = "One Usd to Ron")]
        public float BuyingUsdToRon { get; set; }

        [Required]
        [Display(Name = "One Gbp to Ron")]
        public float BuyingGbpToRon { get; set; }

        [Required]
        [Display(Name = "One Euro to Ron")]
        public float SellingEuroToRon { get; set; }

        [Required]
        [Display(Name = "One Usd to Ron")]
        public float SellingUsdToRon { get; set; }

        [Required]
        [Display(Name = "One Gbp to Ron")]
        public float SellingGbpToRon { get; set; }
        public bool IsDeleted { get; set; }
    }
}
