using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CondoLounge.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public int UserId { get; set; }
        public ICollection<Condo> Condos { get; set; }
    }
}
