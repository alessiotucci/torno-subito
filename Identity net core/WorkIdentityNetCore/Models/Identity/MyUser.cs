using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using System.ComponentModel.DataAnnotations;

namespace WorkIdentityNetCore.Models.Identity
{
    public class MyUser : IdentityUser
    {
        [StringLength(16)] // this is the decorator 
        public string CodiceFiscale { get; set; }


    }
    

   
}
