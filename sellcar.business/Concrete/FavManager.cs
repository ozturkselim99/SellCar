using sellcar.business.Abstract;
using sellcar.data.Abstract;
using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.business.Concrete
{
    public class FavManager : IFavService
    {
        private IFavRepository _favRepository;
        public FavManager(IFavRepository favRepository)
        {
            _favRepository = favRepository;
        }
        public void Create(Fav entity)
        {
            _favRepository.Create(entity);
        }
        public void Update(Fav entity)
        {
            _favRepository.Update(entity);
        }
        public void Delete(Fav entity)
        {
            _favRepository.Delete(entity);
        }

        public Fav GetById(int id)
        {
            return _favRepository.GetById(id);
        }
        public List<Fav> GetFavByUserId(string userId)
        {
            return _favRepository.GetFavByUserId(userId);
        }
    }
}
