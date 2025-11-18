using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeBuildingRepositorie : CondoLoungeGenericGenericRepository<Building>, ICondoLoungeBuildingRepositorie
    {
        public CondoLoungeBuildingRepositorie(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Building>> logger) : base(db, logger)
        {
        }
    }
}
