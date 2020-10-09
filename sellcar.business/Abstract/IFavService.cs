using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.business.Abstract
{
    public interface IFavService
    {
        void Create(Fav entity);
        void Update(Fav entity);
        void Delete(Fav entity);
        Fav GetById(int id);
        List<Fav> GetFavByUserId(string userId);
    }
}
