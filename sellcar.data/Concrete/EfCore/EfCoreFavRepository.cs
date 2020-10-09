using Microsoft.EntityFrameworkCore;
using sellcar.data.Abstract;
using sellcar.entity;
using System.Collections.Generic;
using System.Linq;

namespace sellcar.data.Concrete.EfCore
{
    public class EfCoreFavRepository : EfCoreGenericRepository<Fav, SellCarContext>, IFavRepository
    {
        public List<Fav> GetFavByUserId(string userId)
        {
            using (var context = new SellCarContext())
            {
                return context.Favs
                    .Where(i => i.UserId == userId)
                    .Include(i => i.Ilan)
                    .Include(i=>i.Ilan.IlanResimleri)
                    .Include(i=>i.Ilan.Marka)
                    .ToList();
            }
        }
    }
}
