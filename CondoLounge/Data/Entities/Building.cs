using System.ComponentModel.DataAnnotations;

namespace CondoLounge.Data.Entities
{
    public class Building
    {
        public int BuildingId { get; set; }

        public ICollection<Condo> Condos { get; set; }
    }
}
