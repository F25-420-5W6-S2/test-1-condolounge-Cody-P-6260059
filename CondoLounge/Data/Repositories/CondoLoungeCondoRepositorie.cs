using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeCondoRepositorie : CondoLoungeGenericGenericRepository<Condo>, ICondoLoungeCondoRepositorie
    {
        public CondoLoungeCondoRepositorie(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Condo>> logger) : base(db, logger)
        {
        }
    }
}
