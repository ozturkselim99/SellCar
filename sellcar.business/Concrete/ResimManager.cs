using sellcar.business.Abstract;
using sellcar.data.Abstract;
using sellcar.entity;

namespace sellcar.business.Concrete
{
    public class ResimManager : IResimService
    {
        private IResimRepository _resimRepository;
        public ResimManager(IResimRepository resimRepository)
        {
            _resimRepository = resimRepository;
        }
        public void Create(Resim entity)
        {
            _resimRepository.Create(entity);
        }
        public void Update(Resim entity)
        {
            _resimRepository.Update(entity);
        }
        public void Delete(Resim entity)
        {
            _resimRepository.Delete(entity);
        }
        public Resim GetById(int id)
        {
            return _resimRepository.GetById(id);
        }
        public Resim GetByUrl(string url)
        {
            return _resimRepository.GetByUrl(url);
        }
    }
}
