using sellcar.business.Abstract;
using sellcar.data.Abstract;
using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.business.Concrete
{
    public class IlanManager : IIlanService
    {
        private IIlanRepository _ilanRepository;
        public IlanManager(IIlanRepository ilanRepository)
        {
            _ilanRepository = ilanRepository;
        }
        public void Create(Ilan entity)
        {
            _ilanRepository.Create(entity);
        }
        public void Update(Ilan entity)
        {
            _ilanRepository.Update(entity);
        }
        public void Delete(Ilan entity)
        {
            _ilanRepository.Delete(entity);
        }
        public List<Ilan> Filter(string url, string min_fiyat, string max_fiyat, string min_kilometre, string max_kilometre, string min_yil, string max_yil, string[] yakit_tipi, string[] vites_tipi, string[] kasa_tipi, string min_beygir, string max_beygir, string[] cekis, string[] renk, string kimden, string durumu, string takasli, string[] il)
        {
            return _ilanRepository.Filter(url, min_fiyat, max_fiyat, min_kilometre, max_kilometre, min_yil, max_yil, yakit_tipi, vites_tipi, kasa_tipi, min_beygir, max_beygir, cekis, renk, kimden, durumu, takasli,il);
        }

        public List<Ilan> GetAnasayfaIlanlari()
        {
            return _ilanRepository.GetAnasayfaIlanlari();
        }
        public Ilan GetById(int id)
        {
            return _ilanRepository.GetById(id);
        }
        public Ilan GetIlanDetail(int id)
        {
            return _ilanRepository.GetIlanDetail(id);
        }
        public List<Ilan> GetIlanlar(string url)
        {
            return _ilanRepository.GetIlanlar(url);
        }
        public List<Ilan> GetSearchResult(string searchString)
        {
            return _ilanRepository.GetSearchResult(searchString);
        }
    }
}
