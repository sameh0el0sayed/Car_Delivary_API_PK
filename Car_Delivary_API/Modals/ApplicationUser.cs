using Car_Delivary_API.Database;
using Microsoft.AspNetCore.Identity;

namespace Car_Delivary_API.Modals
{
    public class ApplicationUser: IdentityUser
    {
        public List<RefreshToken>? RefreshTokens { get; set; }

    }
}
