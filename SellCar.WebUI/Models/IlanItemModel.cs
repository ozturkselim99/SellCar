namespace sellcar.webui.Models
{
    public class IlanItemModel
    {
        public int IlanId { get; set; }
        public string ilanBasligi { get; set; }
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
        public double fiyat { get; set; }
        public int markaId { get; set; }
        public string resimUrl { get; set; }
        public string markaAdi { get; set; }

    }
}
