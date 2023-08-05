using Microsoft.AspNetCore.Identity;

namespace WorkIdentityNetCore.Models.Identity
{
    public class MyUser : IdentityUser
    {
        public string CodiceFiscale { get; set; }
    }
}
