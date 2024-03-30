using System.ComponentModel.DataAnnotations;

namespace Car_Delivary_API.ViewModel
{
    public class TokenVM
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
