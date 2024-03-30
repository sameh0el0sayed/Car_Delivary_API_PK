using Car_Delivary_API.DataSetup;
using Microsoft.AspNetCore.Identity;

namespace Car_Delivary_API.Modals
{
    public class ApplicationUser: IdentityUser
    {
        public List<RefreshToken>? RefreshTokens { get; set; }

    }
}
