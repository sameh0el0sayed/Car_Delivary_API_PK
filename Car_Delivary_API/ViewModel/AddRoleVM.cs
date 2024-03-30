using System.ComponentModel.DataAnnotations;

namespace Car_Delivary_API.ViewModel
{
    public class AddRoleVM
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
