using System.ComponentModel.DataAnnotations;

namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        public int CondoId { get; set; }

        public string location { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }

        [Required]
        public int CondoNumber { get; set; }

        // Foreign key to building
        public int CondoIdNumber { get; set; }
        public Building Building { get; set; }
    }
}
