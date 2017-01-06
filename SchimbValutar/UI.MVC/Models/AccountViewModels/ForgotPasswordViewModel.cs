using System.ComponentModel.DataAnnotations;

namespace Domain_Entities.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
