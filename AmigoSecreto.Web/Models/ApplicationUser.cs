using Microsoft.AspNetCore.Identity;

namespace AmigoSecreto.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string RedeSocial { get; set; } = string.Empty;
        public string RedeSocialUrlPath { get; set; } = string.Empty;
    }
}
