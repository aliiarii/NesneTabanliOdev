using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    public class SinifHasta
    {
        public int hasta_id = 0;
        public string hasta_ad_soyad = "";
        public string hasta_tc_kimlik_no = "";

        public List<SinifRandevu> randevu_gecmisi = new List<SinifRandevu>();

        public SinifHasta(int hasta_id , string ad_soyad , string tc_kimlik_no)
        {
            this.hasta_id = hasta_id;
            this.hasta_ad_soyad = ad_soyad;
            this.hasta_tc_kimlik_no = tc_kimlik_no;
        }
    }

    public class SinifDoktor
    {
        public int doktor_id = 0;
        public string doktor_ad_soyad = "";
        public string doktor_uzmanlik = "";

        public List<SinifRandevu> randevu_listesi = new List<SinifRandevu>();

        public SinifDoktor(int doktor_id , string ad_soyad, string uzmanlik)
        {
            this.doktor_id = doktor_id;
            this.doktor_ad_soyad = ad_soyad;
            this.doktor_uzmanlik = uzmanlik;
        }

        public bool Durum(DateTime tarih)
        {
            for(int i = 0; i < randevu_listesi.Count; i ++)
            {
                if (randevu_listesi[i].tarih == tarih)
                    return false;
            }

            return true;
        }
    }


    public class SinifRandevu
    {
        public int randevu_id = 0;
        public SinifDoktor doktor;
        public SinifHasta hasta;
        public DateTime tarih = DateTime.MinValue;

        public List<SinifRandevu> randevu_gecmisi = new List<SinifRandevu>();

        public SinifRandevu(int randevu_id, SinifDoktor doktor , SinifHasta hasta, DateTime tarih)
        {
            this.randevu_id = randevu_id;
            this.doktor = doktor;
            this.hasta = hasta;
            this.tarih = tarih;
        }
    }

}
