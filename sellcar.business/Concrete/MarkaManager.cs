using sellcar.business.Abstract;
using sellcar.data.Abstract;
using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.business.Concrete
{
    public class MarkaManager : IMarkaService
    {
        private IMarkaRepository _markaRepository;
        public MarkaManager(IMarkaRepository markaRepository)
        {
            _markaRepository = markaRepository;
        }
        public void Create(Marka entity)
        {
            _markaRepository.Create(entity);
        }
        public void Update(Marka entity)
        {
            _markaRepository.Update(entity);
        }
        public void Delete(Marka entity)
        {
            _markaRepository.Delete(entity);
        }
        public Marka GetById(int id)
        {
            return _markaRepository.GetById(id);
        }
        public Marka GetByIdWithIlanlar(int markaId)
        {
            return _markaRepository.GetByIdWithIlanlar(markaId);
        }
        public List<Marka> GetMarkalar()
        {
            return _markaRepository.GetMarkalar();
        }
    }
}
