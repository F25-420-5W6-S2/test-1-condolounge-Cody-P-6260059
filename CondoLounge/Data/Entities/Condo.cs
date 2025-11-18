using System.ComponentModel.DataAnnotations;

namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        public int CondoId { get; set; }

        public string location { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }

        // Foreign key to building
        [Required]
        public int CondoNumber { get; set; }
        public Building Building { get; set; }
    }
}
