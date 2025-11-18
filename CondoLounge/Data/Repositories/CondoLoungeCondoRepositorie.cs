using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoLoungeCondoRepositorie : CondoLoungeGenericGenericRepository<Condo>, ICondoLoungeCondoRepositorie
    {
        public CondoLoungeCondoRepositorie(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Condo>> logger) : base(db, logger)
        {
        }

        public IEnumerable<Condo> GetCondosInBuilding(int id)
        {
            try
            {
                var condoList = _context.Condo
                    .Where(c => c.CondoIdNumber == id)
                    .ToList();

                return condoList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
