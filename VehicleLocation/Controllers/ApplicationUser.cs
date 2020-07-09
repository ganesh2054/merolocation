using Microsoft.AspNetCore.Identity;

namespace VehicleLocation.Controllers
{
    internal class ApplicationUser : IdentityUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}