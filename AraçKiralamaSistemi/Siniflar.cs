using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralamaSistemi
{
    public class SinifArac
    {
        public int AracId {  get; set; }
        public String Model { get; set; }
        public Boolean Durum { get; set; }

        public void DurumGuncelle(Boolean yeni_deger)
        {
            Durum = yeni_deger;
        }
    }

    public class SinifMusteri
    {
        public int MusteriId { get; set; }
        public String AdSoyad {  get; set; }
        public String TelefonNo { get; set; }
        public String TcKimlikNo { get; set; }

        public List<SinifArac> KiralananAraclar = new List<SinifArac>();

    }

    public class SinifKiralamaKayit
    {
        public SinifArac Arac { get; set; }
        public SinifMusteri Musteri { get; set; }
        public String Durum { get; set; }
    }

    public class SinifKiralama
    {
        public List<SinifKiralamaKayit> Kiralamalar = new List<SinifKiralamaKayit>();

        public void KiralamaYap(SinifMusteri musteri, SinifArac arac)
        {
            if (!arac.Durum)
            {
                arac.DurumGuncelle(true);
                SinifKiralamaKayit yeni = new SinifKiralamaKayit();
                yeni.Musteri = musteri;
                yeni.Arac = arac;
                yeni.Durum = "Kiralanmış";
                Kiralamalar.Add(yeni);
                musteri.KiralananAraclar.Add(arac);
                MessageBox.Show(arac.AracId.ToString() + " id numarasına sahip " + arac.Model + " model araç " + musteri.AdSoyad + " adlı müşteriye başarıyla kiralandı.");
            }
            else
            {
                MessageBox.Show(arac.AracId.ToString() + " id numarasına sahip " + arac.Model + " model araç zaten kiralanmış!");
            }
        }

        public void KiralamaIptalEt(SinifMusteri musteri, SinifArac arac)
        {
            foreach(SinifKiralamaKayit kiralama in Kiralamalar)
            {
                if((kiralama.Arac == arac) && (kiralama.Musteri == musteri) && (kiralama.Durum == "Kiralanmış"))
                {
                    arac.DurumGuncelle(false);
                    kiralama.Durum = "İptal";
                    musteri.KiralananAraclar.Remove(arac);
                    MessageBox.Show(arac.AracId.ToString() + " id numarasına sahip " + arac.Model + " model aracın kiralanması iptal edildi.");
                    return;
                }

                MessageBox.Show("Henüz hiç bir araç kiralanmamış !");
            }
        }

        public String KiralamaBilgisi(SinifMusteri musteri)
        {
            List<SinifKiralamaKayit> AktifKiralamalar = new List<SinifKiralamaKayit>();

            foreach(SinifKiralamaKayit k in Kiralamalar)
            {
                if((k.Musteri == musteri) && (k.Durum == "Kiralanmış"))
                {
                    AktifKiralamalar.Add(k);
                }
            }

            if(AktifKiralamalar.Count == 0)
            {
                MessageBox.Show("Henüz hiç bir araç kiralanmamış !");
            }
            else
            {
                String s = "";
                foreach (SinifKiralamaKayit k in AktifKiralamalar)
                {
                    s += "id: " + k.Arac.AracId.ToString() + " => model: " + k.Arac.Model + "\r\n";
                }

                return s;
            }

            return "";
        }
    }


}
