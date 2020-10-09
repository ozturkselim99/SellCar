using sellcar.data.Abstract;
using sellcar.entity;
using System.Linq;

namespace sellcar.data.Concrete.EfCore
{
    public class EfCoreResimRepository : EfCoreGenericRepository<Resim, SellCarContext>, IResimRepository
    {
        public Resim GetByUrl(string url)
        {
            using (var context = new SellCarContext())
            {
                return context.Resimler.Where(i => i.url == url).FirstOrDefault();
            }
        }
    }
}
