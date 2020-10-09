using Microsoft.EntityFrameworkCore;
using sellcar.data.Abstract;
using sellcar.entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sellcar.data.Concrete.EfCore
{
    public class EfCoreIlanRepository : EfCoreGenericRepository<Ilan, SellCarContext>, IIlanRepository
    {
        public List<Ilan> Filter(string url, string min_fiyat, string max_fiyat, string min_kilometre, string max_kilometre, string min_yil, string max_yil, string[] yakit_tipi, string[] vites_tipi, string[] kasa_tipi, string min_beygir, string max_beygir, string[] cekis, string[] renk, string kimden, string durumu, string takasli, string[] il)
        {
            using (var context = new SellCarContext())
            {
                var ilanlar = context.Ilanlar
                    .Include(i => i.Marka)
                    .Include(i => i.IlanResimleri)
                    .Include(i => i.Il)
                    .ToList().AsQueryable();

                if (!string.IsNullOrEmpty(url))
                {
                    ilanlar = ilanlar
                        .Include(i => i.Marka)
                        .Include(i => i.IlanResimleri)
                        .Where(i => i.Marka.url == url);
                }
                if (!string.IsNullOrEmpty(min_fiyat))
                {
                    ilanlar = ilanlar.Where(i => i.fiyat > Convert.ToDouble(min_fiyat));
                }
                if (!string.IsNullOrEmpty(max_fiyat))
                {
                    ilanlar = ilanlar.Where(i => i.fiyat < Convert.ToDouble(max_fiyat));
                }
                if (!string.IsNullOrEmpty(min_kilometre))
                {
                    ilanlar = ilanlar.Where(i => i.kilometre > Convert.ToInt32(min_kilometre));
                }
                if (!string.IsNullOrEmpty(max_kilometre))
                {
                    ilanlar = ilanlar.Where(i => i.kilometre < Convert.ToInt32(max_kilometre));
                }
                if (!string.IsNullOrEmpty(min_yil))
                {
                    ilanlar = ilanlar.Where(i => i.yil > Convert.ToInt32(min_yil));
                }
                if (!string.IsNullOrEmpty(max_yil))
                {
                    ilanlar = ilanlar.Where(i => i.yil < Convert.ToInt32(max_yil));
                }
                if (!string.IsNullOrEmpty(min_beygir))
                {
                    ilanlar = ilanlar.Where(i => i.motorGücü > Convert.ToInt32(min_beygir));
                }
                if (!string.IsNullOrEmpty(max_beygir))
                {
                    ilanlar = ilanlar.Where(i => i.motorGücü < Convert.ToInt32(max_beygir));
                }
                if (il.Length!=0)
                {
                    ilanlar = ilanlar.Where(i => il.Contains(i.Il.adi));
                }
                if (renk.Length != 0)
                {
                    ilanlar = ilanlar.Where(i => renk.Contains(i.renk));

                }
                if (cekis.Length != 0)
                {
                    ilanlar = ilanlar.Where(i => cekis.Contains(i.cekisTipi));

                }
                if (yakit_tipi.Length != 0)
                {
                    ilanlar = ilanlar.Where(i => yakit_tipi.Contains(i.yakitTipi));

                }
                if (vites_tipi.Length != 0)
                {
                    ilanlar = ilanlar.Where(i => vites_tipi.Contains(i.vitesTipi));

                }
                if (kasa_tipi.Length != 0)
                {
                    ilanlar = ilanlar.Where(i => kasa_tipi.Contains(i.kasaTipi));

                }
                if (!string.IsNullOrEmpty(takasli))
                {
                    ilanlar = ilanlar.Where(i => i.takas == takasli);
                }
                if (!string.IsNullOrEmpty(kimden))
                {
                    ilanlar = ilanlar.Where(i => i.kimden == kimden);
                }
                if (!string.IsNullOrEmpty(durumu))
                {
                    ilanlar = ilanlar.Where(i => i.durum == durumu);
                }

                return ilanlar.ToList();

            }
        }
        public List<Ilan> GetAnasayfaIlanlari()
        {
            using (var context = new SellCarContext())
            {
                return context.Ilanlar
                    .Where(i => i.anasayfa == true)
                    .Include(i => i.Marka)
                    .Include(i => i.IlanResimleri)
                    .ToList();
            }
        }
        public Ilan GetIlanDetail(int id)
        {
            using (var context = new SellCarContext())
            {
                return context.Ilanlar
                    .Include(i => i.IlanResimleri)
                    .Include(i => i.Marka)
                     .Include(i => i.Il)
                    .FirstOrDefault(i => i.IlanId == id);
            }
        }
        public List<Ilan> GetIlanlar(string url)
        {
            using (var context = new SellCarContext())
            {
                var ilanlar = context.Ilanlar
                       .Include(i => i.Marka)
                       .Include(i => i.IlanResimleri)
                        .Include(i => i.Il)
                       .ToList().AsQueryable();

                if (!string.IsNullOrEmpty(url))
                {
                    ilanlar = ilanlar
                        .Include(i => i.Marka)
                        .Include(i => i.IlanResimleri)
                        .Where(i => i.Marka.url == url);
                }
                return ilanlar.ToList();
            }
        }
        public List<Ilan> GetSearchResult(string searchString)
        {
            using (var context = new SellCarContext())
            {
                var ilanlar = context
                    .Ilanlar
                    .Include(i => i.Marka)
                    .Include(i => i.IlanResimleri)
                    .Where(i => (i.ilanBasligi.ToLower().Contains(searchString.ToLower()) ||/* i.il.ToLower().Contains(searchString.ToLower()) ||*/ i.durum.ToLower().Contains(searchString.ToLower()) || i.kasaTipi.ToLower().Contains(searchString.ToLower())
                    || i.Marka.adi.ToLower().Contains(searchString.ToLower()) || i.kimden.ToLower().Contains(searchString.ToLower()) || i.renk.ToLower().Contains(searchString.ToLower()) || i.vitesTipi.ToLower().Contains(searchString.ToLower())
                    || i.yakitTipi.ToLower().Contains(searchString.ToLower()) || i.cekisTipi.ToLower().Contains(searchString.ToLower())
                    ))
                    .AsQueryable();

                return ilanlar.ToList();
            }
        }
    }
}
