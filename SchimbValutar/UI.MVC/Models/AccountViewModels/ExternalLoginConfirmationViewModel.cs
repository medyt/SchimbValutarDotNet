using System.ComponentModel.DataAnnotations;

namespace Domain_Entities.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
