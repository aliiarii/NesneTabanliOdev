using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    public class SinifKitap
    {
        public int kitap_id = 0;
        public string kitap_ad = "";
        public string kitap_yazar = "";
        public bool kitap_durum = true;

        public void DurumGuncelle(bool yeni_durum)
        {
            this.kitap_durum = yeni_durum;
        }
    }

    public class SinifUye
    {
        public int uye_id = 0;
        public string uye_ad_soyad = "";
        public string uye_tc_kimlik_no = "";
        public string uye_telefon = "";
        public string uye_e_posta = "";
        public List<SinifKitap> odunc_kitaplar = new List<SinifKitap>();

        public void KitapEkle(SinifKitap kitap)
        {
            this.odunc_kitaplar.Add(kitap);
        }

        public void KitapSil(SinifKitap kitap)
        {
            this.odunc_kitaplar.Remove(kitap);
        }

    }

    public class SinifOdunc
    {
        public int odunc_id = 0;
        public int uye_id = 0;
        public int kitap_id = 0;
        public DateTime odunc_verme_tarihi = DateTime.Now;
        public DateTime odunc_iade_tarihi = DateTime.MinValue;
        public bool iade_edildi_mi = true;
    }

}
