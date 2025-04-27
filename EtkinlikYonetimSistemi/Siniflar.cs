using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikYonetimSistemi
{
    public class SinifEtkinlik
    {
        public int etkinlik_id = 0;
        public string etkinlik_adi = "";
        public DateTime etkinlik_tarihi = DateTime.MinValue;
        public string etkinlik_yeri = "";
        public int etkinlik_kapasitesi = 0;
        public int etkinlik_bos_yer_sayisi = 0;
        public float etkinlik_ucreti = 0;

        public SinifEtkinlik(int etkinlik_id, string etkinlik_adi, DateTime etkinlik_tarihi, string etkinlik_yeri, int etkinlik_kapasitesi, float etkinlik_ucreti)
        {
            this.etkinlik_id = etkinlik_id;
            this.etkinlik_adi = etkinlik_adi;
            this.etkinlik_tarihi = etkinlik_tarihi;
            this.etkinlik_yeri = etkinlik_yeri;
            this.etkinlik_kapasitesi = etkinlik_kapasitesi;
            this.etkinlik_bos_yer_sayisi = this.etkinlik_kapasitesi;
            this.etkinlik_ucreti = etkinlik_ucreti;
        }

        public bool BosYerVarmi()
        {
            if (this.etkinlik_bos_yer_sayisi > 0) return true;

            return false;
        }

        public bool KatilimciyiKaydet()
        {
            if (this.etkinlik_bos_yer_sayisi > 0)
            {
                this.etkinlik_bos_yer_sayisi --;
                return true;
            }

            return false;
        }
    }

    public class SinifKatilimci
    {
        public string katilimci_ad_soyad = "";
        public string katilimci_e_posta_adresi = "";
        public int katilimci_id = 0;

        public SinifKatilimci(int katilimci_id, string ad_soyad, string e_posta_adresi)
        {
            this.katilimci_id = katilimci_id;
            this.katilimci_ad_soyad = ad_soyad;
            this.katilimci_e_posta_adresi = e_posta_adresi;
        }
    }

    public class SinifBilet
    {
        public int bilet_id = 1;
        public int bilet_etkinlik_id = 0;
        public int bilet_katilimci_id = 0;
        public float bilet_ucret = 0;

        public SinifBilet(int bilet_id, int etkinlik_id, int katilimci_id, float ucret)
        {
            this.bilet_id = bilet_id;
            this.bilet_etkinlik_id = etkinlik_id;
            this.bilet_katilimci_id = katilimci_id;
            this.bilet_ucret = ucret;
        }
    }

}
