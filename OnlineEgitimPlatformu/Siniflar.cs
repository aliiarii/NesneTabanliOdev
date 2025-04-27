using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEgitimPlatformu
{
    public class SinifOgrenci
    {
        public int ogrenci_id = 0;
        public string ogrenci_ad_soyad = "";
        public string ogrenci_e_posta = "";
        public List<SinifKurs> ogrenci_katildigi_kurslar = new List<SinifKurs>();
    }

    public class SinifEgitmen
    {
        public int egitmen_id = 0;
        public string egitmen_ad_soyad = "";
        public string egitmen_uzmanlik = "";
        public List<SinifKurs> egitmen_verdigi_kurslar = new List<SinifKurs>();
    }

    public class SinifKurs
    {
        public int kurs_id = 0;
        public string kurs_ad = "";
        public SinifEgitmen kurs_egitmen = new SinifEgitmen();
        public string kurs_icerik = "";
        public List<SinifOgrenci> kurs_alan_ogrenciler = new List<SinifOgrenci>();

    }


    public class SinifKursKaydi
    {
        public int kurs_kaydi_id = 0;
        public int kurs_id = 0;
        public int kurs_ogrenci_id = 0;
        public int kurs_egitici_id = 0;

    }

}
