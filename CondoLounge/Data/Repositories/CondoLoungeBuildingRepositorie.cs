using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeBuildingRepositorie : CondoLoungeGenericGenericRepository<Building>, ICondoLoungeBuildingRepositorie
    {
        public CondoLoungeBuildingRepositorie(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Building>> logger) : base(db, logger)
        {
        }
    }
}
