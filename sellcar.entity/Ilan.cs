using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Cache;
using System.Reflection;
using System.Text;

namespace sellcar.entity
{
    public class Ilan
    {
        [Key]
        public int IlanId { get; set; }
        public string ilanBasligi { get; set; }
        public string ilanDetay { get; set; }
        public DateTime ilanTarihi { get; set; }
        public string seri { get; set; }
        public string model { get; set; }
        public int yil { get; set; }
        public string yakitTipi { get; set; }
        public string vitesTipi { get; set; }
        public int vitesSayisi { get; set; }
        public int kilometre { get; set; }
        public string kasaTipi { get; set; }
        public int kapiSayisi { get; set; }
        public int motorGücü { get; set; }
        public int motorHacmi { get; set; }
        public int azamiSurati { get; set; }
        public double hizlanma { get; set; }
        public string cekisTipi { get; set; }
        public double sehirIciTuketim { get; set; }
        public double sehirDisiTuketim { get; set; }
        public double ortalamaTuketim { get; set; }
        public int yakitDepoHacmi { get; set; }
        public string renk { get; set; }
        public string kimden { get; set; }
        public string takas { get; set; }
        public string durum { get; set; }
        public bool anasayfa { get; set; }
        public double fiyat { get; set; }
        public string userId { get; set; }

        public int ilId { get; set; }
        public  Il Il { get; set; }

        public int markaId { get; set; }
        public Marka Marka { get; set; }

        public List<Resim> IlanResimleri { get; set; }
    }
}
