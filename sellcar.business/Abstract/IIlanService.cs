using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.business.Abstract
{
    public interface IIlanService
    {
        void Create(Ilan entity);
        void Update(Ilan entity);
        void Delete(Ilan entity);
        Ilan GetById(int id);
        Ilan GetIlanDetail(int id);
        List<Ilan> GetAnasayfaIlanlari();
        List<Ilan> GetIlanlar(string url);
        List<Ilan> Filter(string url, string min_fiyat, string max_fiyat, string min_kilometre, string max_kilometre, string min_yil, string max_yil, string[] yakit_tipi, string[] vites_tipi, string[] kasa_tipi, string min_beygir, string max_beygir, string[] cekis, string[] renk, string kimden, string durumu, string takasli,string[]il);
        List<Ilan> GetSearchResult(string searchString);
    }
}
