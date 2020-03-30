using System.ComponentModel.DataAnnotations;

namespace HHZ.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}