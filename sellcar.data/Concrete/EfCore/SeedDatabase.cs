using Microsoft.EntityFrameworkCore;
using sellcar.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace sellcar.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new SellCarContext();
          
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Iller.Count() == 0)
                {
                    for (int i = 0; i < iller.Length; i++)
                    {
                        context.Iller.Add(iller[i]);
                    }
                    context.SaveChanges();
                }
                if (context.Markalar.Count() == 0)
                {
                    for (int i = 0; i < markalar.Length; i++)
                    {
                        context.Markalar.Add(markalar[i]);
                        context.SaveChanges();
                    }
                }
                if (context.Ilanlar.Count() == 0)
                {
                    for (int i = 0; i < ilanlar.Length; i++)
                    {
                        context.Ilanlar.Add(ilanlar[i]);
                    }
                    context.SaveChanges();
                }
                if (context.Resimler.Count()==0)
                {
                    for (int i = 0; i < resimler.Length; i++)
                    {
                        context.Resimler.Add(resimler[i]);
                    }
                    context.SaveChanges();
                }
            }
        }
        private static Il[] iller =
        {
            new Il(){adi="Adana"},
            new Il(){adi="Adıyaman"},
            new Il(){adi="Afyonkarahisar"},
            new Il(){adi="Ağrı"},
            new Il(){adi="Amasya" },
            new Il(){adi="Ankara"},
            new Il(){adi="Antalya"},
            new Il(){adi="Artvin"},
            new Il(){adi="Aydın"},
            new Il(){adi="Balıkesir"},
            new Il(){adi="Bilecik",},
            new Il(){adi="Bingöl"},
            new Il(){adi="Bitlis"},
            new Il(){adi="Bolu"},
            new Il(){adi="Burdur"},
            new Il(){adi="Bursa"},
            new Il(){adi="Çanakkale"},
            new Il(){adi="Çankırı"},
            new Il(){adi="Çorum"},
            new Il(){adi="Denizli"},
            new Il(){adi="Diyarbakır"},
            new Il(){adi="Edirne"},
            new Il(){adi="Elazığ"},
            new Il(){adi="Erzincan"},
            new Il(){adi="Erzurum"},
            new Il(){adi="Eskişehir"},
            new Il(){adi="Gaziantep"},
            new Il(){adi="Giresun"},
            new Il(){adi="Gümüşhane"},
            new Il(){adi="Hakkari"},
            new Il(){adi="Hatay"},
            new Il(){adi="Isparta"},
            new Il(){adi="Mersin"},
            new Il(){adi="İstanbul"},
            new Il(){adi="İzmir"},
            new Il(){adi="Kars"},
            new Il(){adi="Kastamonu"},
            new Il(){adi="Kayseri"},
            new Il(){adi="Kırklareli"},
            new Il(){adi="Kırşehir"},
            new Il(){adi="Kocaeli"},
            new Il(){adi="Konya"},
            new Il(){adi="Kütahya"},
            new Il(){adi="Malatya"},
            new Il(){adi="Manisa"},
            new Il(){adi="Mardin"},
            new Il(){adi="Muğla"},
            new Il(){adi="Muş"},
            new Il(){adi="Nevşehir"},
            new Il(){adi="Niğde"},
            new Il(){adi="Ordu"},
            new Il(){adi="Rize"},
            new Il(){adi="Sakarya"},
            new Il(){adi="Samsun"},
            new Il(){adi="Siirt"},
            new Il(){adi="Sinop"},
            new Il(){adi="Sivas"},
            new Il(){adi="Tekirdağ"},
            new Il(){adi="Tokat"},
            new Il(){adi="Trabzon"},
            new Il(){adi="Tunceli"},
            new Il(){adi="Şanlıurfa"},
            new Il(){adi="Uşak"},
            new Il(){adi="Van"},
            new Il(){adi="Yozgat"},
            new Il(){adi="Zonguldak"},
            new Il(){adi="Aksaray"},
            new Il(){adi="Bayburt"},
            new Il(){adi="Karaman"},
            new Il(){adi="Kırıkkale"},
            new Il(){adi="Batman"},
            new Il(){adi="Şırnak"},
            new Il(){adi="Bartın"},
            new Il(){adi="Ardahan"},
            new Il(){adi="Iğdır"},
            new Il(){adi="Yalova"},
            new Il(){adi="Karabük"},
            new Il(){adi="Kilis"},
            new Il(){adi="Osmaniye"},
            new Il(){adi="Düzce"},
          
        };
        private static Marka[] markalar =
        {
            new Marka(){adi="Alfa Romeo",url="alfa-romeo"},
            new Marka(){adi="Alpine",url="alpine",},
            new Marka(){adi="Anadol",url="anadol"},
            new Marka(){adi="Aston Martin",url="aston-martin"},
            new Marka(){adi="Audi",url="audi"},
            new Marka(){adi="Bentley",url="bentley"},
            new Marka(){adi="BMW",url="bmw"},
            new Marka(){adi="Bugatti",url="bugatti"},
            new Marka(){adi="Buick",url="buic"},
            new Marka(){adi="Cadillac",url="cadillac"},
            new Marka(){adi="Caterham",url="caterham"},
            new Marka(){adi="Chery",url="chery"},
            new Marka(){adi="Chevrolet",url="chevrolet"},
            new Marka(){adi="Chrysler",url="chrysler"},
            new Marka(){adi="Citroen",url="citroen"},
            new Marka(){adi="Dacia",url="dacia"},
            new Marka(){adi="Daewoo",url="daewoo"},
            new Marka(){adi="Daihatsu",url="daihatsu"},
            new Marka(){adi="Dodge",url="dodge"},
            new Marka(){adi="Ds Automobiles",url="ds-automobiles"},
            new Marka(){adi="Ferrari",url="ferrari"},
            new Marka(){adi="Fiat",url="fiat"},
            new Marka(){adi="Ford",url="ford"},
            new Marka(){adi="Geely",url="geely"},
            new Marka(){adi="Honda",url="honda"},
            new Marka(){adi="Hyundai",url="hyundai"},
            new Marka(){adi="Ikco",url="ikco"},
            new Marka(){adi="Infiniti",url="infiniti"},
            new Marka(){adi="Isuzu",url="ısuzu"},
            new Marka(){adi="Jaguar",url="jaguar"},
            new Marka(){adi="Kia",url="kia"},
            new Marka(){adi="Lada",url="lada"},
            new Marka(){adi="Lamborghini",url="lamborghini"},
            new Marka(){adi="Lancia",url="lancia"},
            new Marka(){adi="Lexus",url="lexus"},
            new Marka(){adi="Lincoln",url="lincoln"},
            new Marka(){adi="Lotus",url="lotus"},
            new Marka(){adi="Marcos",url="marcos"},
            new Marka(){adi="Maserati",url="maserati"},
            new Marka(){adi="Mazda",url="mazda"},
            new Marka(){adi="McLaren",url="mclaren"},
            new Marka(){adi="Mercedes Benz",url="mercedes-benz"},
            new Marka(){adi="MG",url="mg"},
            new Marka(){adi="Mini",url="mini"},
            new Marka(){adi="Mitsubishi",url="mitsubishi"},
            new Marka(){adi="Nissan",url="nissan"},
            new Marka(){adi="Oldsmobile",url="oldsmobile"},
            new Marka(){adi="Opel",url="opel"},
            new Marka(){adi="Peugeot",url="peugot"},
            new Marka(){adi="Plymouth",url="plymouth"},
            new Marka(){adi="Pontiac",url="pontiac"},
            new Marka(){adi="Porsche",url="porsche"},
            new Marka(){adi="Proton",url="proton"},
            new Marka(){adi="Renault",url="renault"},
            new Marka(){adi="Rolls Royce",url="rolls-royce"},
            new Marka(){adi="Rover",url="rover"},
            new Marka(){adi="Saab",url="saab"},
            new Marka(){adi="Seat",url="seat"},
            new Marka(){adi="Skoda",url="skoda"},
            new Marka(){adi="Smart",url="smart"},
            new Marka(){adi="Subaru",url="subaru"},
            new Marka(){adi="Suzuki",url="suzuki"},
            new Marka(){adi="Tesla",url="tesla"},
            new Marka(){adi="Tofaş",url="tofas"},
            new Marka(){adi="Toyota",url="toyota"},
            new Marka(){adi="Volkswagen",url="volkswagen"},
            new Marka(){adi="Volvo",url="volvo"},

        };
        private static Ilan[] ilanlar =
         {
            new Ilan(){ilanBasligi="GARDEN2008 SKY WİNDOW SELESPEED KIRMIZI",ilanDetay="Aracın tüm bakımları yeni yapılmıştır.",ilanTarihi=DateTime.Now,seri="Brera",model="2.2 JTS Sky Window",yil=2008,yakitTipi="Benzin",vitesTipi="Yarı Otomatik",vitesSayisi=6,kilometre=168368,kasaTipi="Coupe",kapiSayisi=2,motorGücü=185,motorHacmi=2198 ,azamiSurati=222 ,hizlanma=8.6,cekisTipi="Arkadan İtiş",sehirIciTuketim=13,sehirDisiTuketim=7.3,ortalamaTuketim=9.4,yakitDepoHacmi=70,renk="Kırmızı",kimden="Galeriden",takas="Evet",durum="İkinci El",anasayfa=false,markaId=1,IlanId=1,ilId=6,fiyat=365000,userId="1"},
            new Ilan(){ilanBasligi="2013 BMW Z4 sDrive 2.0i Luxury Line",ilanDetay="Borusan Oto Avcılar 2013 Aralık çıkışlıdır. (Makyajlı kasa, yeni tip)",ilanTarihi=DateTime.Now,ilId=34,seri="Z Serisi",model="Z4 2.0i sDrive Luxury",yil=2013,yakitTipi="Benzin",vitesTipi="Yarı Otomatik",vitesSayisi=8,kilometre=77250,kasaTipi="Cabrio",kapiSayisi=2,motorGücü=184,motorHacmi=1997 ,azamiSurati=232 ,hizlanma=7.2,cekisTipi="Arkadan İtiş",sehirIciTuketim=9.1,sehirDisiTuketim=5.5,ortalamaTuketim=6.8,yakitDepoHacmi=55,renk="Mavi",kimden="Sahibinden",takas="Evet",durum="İkinci El",anasayfa=true,markaId=7,IlanId=2,fiyat=435000,userId="1"},
            new Ilan(){ilanBasligi="NASYONEL BAYİ V8 585 HP SPOR KOLTUK BURMESTER KARBON SPOR EGZ",ilanDetay="http://nasyonel.sahibinden.com/ Araç bakımlı",ilanTarihi=DateTime.Now,ilId=35,seri="AMG GT",model="4.0",yil=2017,yakitTipi="Benzin",vitesTipi="Otomatik",vitesSayisi=7,kilometre=149,kasaTipi="Coupe",kapiSayisi=2,motorGücü=585,motorHacmi=3982 ,azamiSurati=318 ,hizlanma=3.6,cekisTipi="Arkadan İtiş",sehirIciTuketim=15.1,sehirDisiTuketim=9.0,ortalamaTuketim=11.4,yakitDepoHacmi=65,renk="Gri",kimden="Galeriden",takas="Evet",durum="İkinci El",anasayfa=true,markaId=42,IlanId=3,fiyat=4350000,userId="1"},
            new Ilan(){ilanBasligi="SS MOTORS 2019 A7 50 TDI QUATTRO-S LINE-DISTRONIC-3D 360-BAYİ",ilanDetay="Tüm bakımları zamanında yapılmıştır. Sorunsuz bir araçtır.",ilanTarihi=DateTime.Now,ilId=7,seri="A7",model="3.0 TDI",yil=2019,yakitTipi="Dizel",vitesTipi="Otomatik",vitesSayisi=8,kilometre=16747,kasaTipi="Sedan",kapiSayisi=5,motorGücü=286,motorHacmi=3001 ,azamiSurati=256 ,hizlanma=7.2,cekisTipi="Arkadan İtiş",sehirIciTuketim=9.1,sehirDisiTuketim=5.5,ortalamaTuketim=6.8,yakitDepoHacmi=65,renk="Füme",kimden="Galeirden",takas="Evet",durum="İkinci El",anasayfa=true,markaId=5,IlanId=4,fiyat=2190000,userId="1"},
            new Ilan(){ilanBasligi="MLHMOTORS FORD MUSTANG V6",ilanDetay="MLH MOTORS FORD MUSTANG V6 4.0 212 HP",ilanTarihi=DateTime.Now,ilId=6,seri="Mustang",model="4.0",yil=2005,yakitTipi="Benzin",vitesTipi="Otomatik",vitesSayisi=6,kilometre=118000,kasaTipi="Coupe",kapiSayisi=2,motorGücü=225,motorHacmi=4000 ,azamiSurati=247 ,hizlanma=6.2,cekisTipi="Arkadan İtiş",sehirIciTuketim=9.1,sehirDisiTuketim=5.5,ortalamaTuketim=6.8,yakitDepoHacmi=60,renk="Mavi",kimden="Galeriden",takas="Hayır",durum="İkinci El",anasayfa=true,markaId=23,IlanId=5,fiyat=310000,userId="1"},

        };

        private static Resim[] resimler =
        {
            new Resim() { url = "1.jpg", IlanId = 1},
            new Resim() { url = "2.jpg", IlanId = 1 },
            new Resim() { url = "3.jpg", IlanId = 1 },
            new Resim() { url = "4.jpg", IlanId = 1 },
            new Resim() { url = "5.jpg", IlanId = 1 },

            new Resim() { url = "11.jpg", IlanId = 2},
            new Resim() { url = "12.jpg", IlanId = 2 },
            new Resim() { url = "13.jpg", IlanId = 2 },
            new Resim() { url = "14.jpg", IlanId = 2 },
            new Resim() { url = "15.jpg", IlanId = 2 },

            new Resim() { url = "16.jpg", IlanId = 3},
            new Resim() { url = "17.jpg", IlanId = 3 },
            new Resim() { url = "18.jpg", IlanId = 3 },
            new Resim() { url = "19.jpg", IlanId = 3 },
            new Resim() { url = "20.jpg", IlanId = 3 },

            new Resim() { url = "21.jpg", IlanId = 4},
            new Resim() { url = "22.jpg", IlanId = 4 },
            new Resim() { url = "23.jpg", IlanId = 4 },
            new Resim() { url = "24.jpg", IlanId = 4 },
            new Resim() { url = "25.jpg", IlanId = 4 },

            new Resim() { url = "26.jpg", IlanId = 5},
            new Resim() { url = "27.jpg", IlanId = 5 },
            new Resim() { url = "28.jpg", IlanId = 5 },
            new Resim() { url = "29.jpg", IlanId = 5 },
            new Resim() { url = "30.jpg", IlanId = 5 },
        };
    }
}