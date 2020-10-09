using Microsoft.EntityFrameworkCore;
using sellcar.data.Abstract;
using sellcar.entity;
using System.Collections.Generic;
using System.Linq;

namespace sellcar.data.Concrete.EfCore
{
    public class EfCoreMarkaRepository : EfCoreGenericRepository<Marka, SellCarContext>, IMarkaRepository
    {
        public Marka GetByIdWithIlanlar(int markaId)
        {
            using (var context = new SellCarContext())
            {
                return context.Markalar
                    .Where(i => i.MarkaId == markaId)
                    .Include(i => i.Ilanlar)
                    .ThenInclude(i => i.Il)
                    .FirstOrDefault();
            }
        }
        public List<Marka> GetMarkalar()
        {
            using (var context = new SellCarContext())
            {
                return context.Markalar
                    .Include(i => i.Ilanlar)
                    .OrderBy(i => i.adi)
                    .ToList();
            }
        }
    }
}
