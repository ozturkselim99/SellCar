using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.data.Abstract
{
    public interface IFavRepository:IRepository<Fav>
    {
        List<Fav> GetFavByUserId(string userId);
    }
}
