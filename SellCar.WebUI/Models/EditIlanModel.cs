using Microsoft.AspNetCore.Http;
using sellcar.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sellcar.webui.Models
{
    public class EditIlanModel
    {
        public int IlanId { get; set; }
        [Required(ErrorMessage = "İlan Başlığı boş bırakılamaz.")]
        public string ilanBasligi { get; set; }
        public string ilanDetay { get; set; }
        [Required(ErrorMessage = "Aracınızın bulunduğu ili belirtiniz.")]
        public string ilId { get; set; }
        [Required(ErrorMessage = "Aracınızın serisini belirtiniz.")]
        public string seri { get; set; }
        [Required(ErrorMessage = "Aracınızın modelini belirtiniz.")]
        public string model { get; set; }
        [Required(ErrorMessage = "Aracınızın kaç model olduğunu belirtiniz.")]
        [Range(1950, 2020,
        ErrorMessage = "Yıl 1950 ile 2020 arasında olmalıdır")]
        public int yil { get; set; }
        [Required(ErrorMessage = "Aracınızın yakıt tipini seçiniz.")]
        public string yakitTipi { get; set; }
        [Required(ErrorMessage = "Aracınızın vites tipini seçiniz.")]
        public string vitesTipi { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public int vitesSayisi { get; set; }
        [Required(ErrorMessage = "Aracınızın kilometresini belirtiniz.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public int kilometre { get; set; }
        [Required(ErrorMessage = "Aracınızın kasa tipini seçiniz.")]
        public string kasaTipi { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public int kapiSayisi { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public int motorGücü { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public int motorHacmi { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public int azamiSurati { get; set; }
        [Range(0, Double.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public double hizlanma { get; set; }
        [Required(ErrorMessage = "Aracınızın çekiş tipini seçiniz..")]
        public string cekisTipi { get; set; }
        [Range(0, Double.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public double sehirIciTuketim { get; set; }
        [Range(0, Double.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public double sehirDisiTuketim { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public double ortalamaTuketim { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public int yakitDepoHacmi { get; set; }
        [Required(ErrorMessage = "Aracınızın rengini seçiniz")]
        public string renk { get; set; }
        [Required(ErrorMessage = "Aracınızın kim tarafından satıldığını seçiniz.")]
        public string kimden { get; set; }
        [Required(ErrorMessage = "Aracın takasa açık olup olmadığını seçiniz.")]
        public string takas { get; set; }
        [Required(ErrorMessage = "Aracınızın durumunu seçiniz.")]
        public string durum { get; set; }
        [Required(ErrorMessage = "Aracınızı satmak istediğiniz fiyatı belirtiniz.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Negatif değer giremezsiniz.")]
        public double fiyat { get; set; }
        [Required(ErrorMessage = "Aracınızın markasını seçiniz.")]
        public string markaId { get; set; }
        public bool anasayfa { get; set; }
        public List<IFormFile> files { get; set; }
        public List<Resim> IlanResimleri { get; set; }
    }
}
