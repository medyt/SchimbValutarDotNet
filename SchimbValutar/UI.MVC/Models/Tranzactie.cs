using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UI.MVC.Models
{
    public enum TipOperatie { Cumparare = 1, Vanzare = 2}
    public enum Moneda { RON = 1, USD = 2, EUR = 3, GBP = 4}
    public enum TipActIdentitate { CarteDeIdentitate = 1, Pasaport = 2, PermisDeConducere = 3}
    public class Tranzactie
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Tipul Operatiunii")]
        public TipOperatie TipOperatie { get; set; }
        [Required]
        public Moneda Din { get; set; }
        [Required]
        public Moneda In { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Suma Tranzactionata")]
        public decimal SumaTranzationata { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Suma Datorata")]
        public decimal SumaDatorata { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{13}$")]
        [Display(Name = "CNP")]
        public string Cnp { get; set; }
        [Required]
        public TipActIdentitate ActIdentitate { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]{2}$")]
        public string Seria { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{6}$")]
        public string Numarul { get; set; }
        public bool IsDeleted { get; set; }
    }
}
