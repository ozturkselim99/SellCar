using Microsoft.EntityFrameworkCore;
using sellcar.data.Abstract;
using sellcar.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sellcar.data.Concrete.EfCore
{
    public class EfCoreIlRepository : EfCoreGenericRepository<Il, SellCarContext>, IIlRepository
    {
        public Il enÇokIlanVerilenIl()
        {
            using (var context = new SellCarContext())
            {
                return context.Iller
                    .Include(i => i.Ilanlar)
                    .OrderByDescending(i => i.Ilanlar.Count())
                    .FirstOrDefault();
            }
        }

        public Il enAzIlanVerilenIl()
        {
            using (var context = new SellCarContext())
            {
                return context.Iller
                    .Include(i => i.Ilanlar)
                    .OrderBy(i => i.Ilanlar.Count())
                    .FirstOrDefault();
            }
        }

        public Il GetByIdWithIlanlar(int ilId)
        {
            using (var context = new SellCarContext())
            {
                return context.Iller
                    .Where(i => i.ilId == ilId)
                    .Include(i => i.Ilanlar)
                    .ThenInclude(i => i.Marka)
                    .FirstOrDefault();
            }
        }

        public List<Il> GetIller()
        {
            using (var context = new SellCarContext())
            {
                return context.Iller
                    .Include(i => i.Ilanlar)
                    .OrderBy(i => i.adi)
                    .ToList();

            }
        }
    }
}
