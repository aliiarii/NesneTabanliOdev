namespace EtkinlikYonetimSistemi
{
    public partial class Form1 : Form
    {
        List<SinifEtkinlik> EtkinliklerTablosu = new List<SinifEtkinlik>();
        List<SinifKatilimci> KatilimcilarTablosu = new List<SinifKatilimci>();
        List<SinifBilet> BiletlerTablosu = new List<SinifBilet>();
        private int EtkinlikIdSayaci = 1;
        private int KatilimciIdSayaci = 1;
        private int BiletIdSayaci = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void TabSayfalariniDevreDisiBirak()
        {
            tabControl1.TabPages.Remove(tabPageEtkinlikOlustur);
            tabControl1.TabPages.Remove(tabPageTumEtkinlikleriListele);
            tabControl1.TabPages.Remove(tabPageEtkinlikUygunlukKontroluYap);

            tabControl1.TabPages.Remove(tabPageKatilimciKaydet);
            tabControl1.TabPages.Remove(tabPageKatilimciSil);
            tabControl1.TabPages.Remove(tabPageKatilimciListele);

            tabControl1.TabPages.Remove(tabPageBiletSatinAl);
            tabControl1.TabPages.Remove(tabPageBiletIptalEt);
            tabControl1.TabPages.Remove(tabPageBiletleriListele);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageTumEtkinlikleriListele);
            tabControl1.SelectTab(tabPageTumEtkinlikleriListele);

        }


        private void EtkinlikleriListele()
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageTumEtkinlikleriListele);
            tabControl1.SelectTab(tabPageTumEtkinlikleriListele);

        }


        private void buttonEtkinlikOlustur_Click(object sender, EventArgs e)
        {
            string ad = textBoxEtkinlikAdi.Text;
            string tarih = dateTimePickerEtkinlikTarihi.Text;
            string yer = textBoxEtkinlikYeri.Text;
            string kapasite_text = textBoxEtkinlikKapasitesi.Text;
            string etkinlik_ucreti_text = textBoxEtkinlikUcreti.Text;
            int kapasite = 0;
            float etkinlik_ucreti = 0;

            int.TryParse(kapasite_text, out kapasite);
            float.TryParse(etkinlik_ucreti_text, out etkinlik_ucreti);

            if (kapasite == 0)
            {
                MessageBox.Show("Etkinlik kapasitesi 0 olamaz. Lütfen daha büyük bir değer giriniz !!!");
                return;
            }

            SinifEtkinlik yeni = new SinifEtkinlik(EtkinlikIdSayaci++, ad, dateTimePickerEtkinlikTarihi.Value, yer, kapasite, etkinlik_ucreti);
            EtkinliklerTablosu.Add(yeni);
            MessageBox.Show("Etkinlik başarıyla oluşturuldu");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEtkinlikOlustur_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageEtkinlikOlustur);
            tabControl1.SelectTab(tabPageEtkinlikOlustur);
        }

        private void btnKatilimciKaydet_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageKatilimciKaydet);
            tabControl1.SelectTab(tabPageKatilimciKaydet);
        }

        private void btnBiletSatinAl_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageBiletSatinAl);
            tabControl1.SelectTab(tabPageBiletSatinAl);

            comboBoxKayitliEtkinlikler.Items.Clear();
            comboBoxKayitliKatilimcilar.Items.Clear();

            for (int i = 0; i < EtkinliklerTablosu.Count; i++)
            {
                string s = EtkinliklerTablosu[i].etkinlik_id.ToString() + " => " + EtkinliklerTablosu[i].etkinlik_adi + " => " + EtkinliklerTablosu[i].etkinlik_yeri;
                comboBoxKayitliEtkinlikler.Items.Add(s);
                textBoxBosKapasite.Text = EtkinliklerTablosu[i].etkinlik_bos_yer_sayisi.ToString();
                textBoxEtkinlikUcreti.Text = EtkinliklerTablosu[i].etkinlik_ucreti.ToString();
            }

            for (int i = 0; i < KatilimcilarTablosu.Count; i++)
            {
                string s = KatilimcilarTablosu[i].katilimci_id.ToString() + " => " + KatilimcilarTablosu[i].katilimci_ad_soyad + " => " + KatilimcilarTablosu[i].katilimci_e_posta_adresi;
                comboBoxKayitliKatilimcilar.Items.Add(s);
            }

        }

        private void btnEtkinlikleriListele_Click(object sender, EventArgs e)
        {
            EtkinlikleriListele();

            listBoxEtkinlikListesi.Items.Clear();

            if (EtkinliklerTablosu.Count == 0)
            {
                MessageBox.Show("Henüz hiç bir etkinlik kaydı girilmemiş. Lütfen kayıt girişi yapıp tekrar deneyiniz!!!");
                return;
            }

            for (int i = 0; i < EtkinliklerTablosu.Count; i++)
            {
                string s = EtkinliklerTablosu[i].etkinlik_id.ToString() + " => ";
                s += EtkinliklerTablosu[i].etkinlik_adi + " => ";
                s += EtkinliklerTablosu[i].etkinlik_yeri + " => ";
                s += EtkinliklerTablosu[i].etkinlik_kapasitesi.ToString() + " => ";
                s += EtkinliklerTablosu[i].etkinlik_bos_yer_sayisi.ToString();

                listBoxEtkinlikListesi.Items.Add(s);
            }

        }

        private void btnEtkinlikKontroluYap_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageEtkinlikUygunlukKontroluYap);
            tabControl1.SelectTab(tabPageEtkinlikUygunlukKontroluYap);
        }

        private void buttonEtkinlikUygunlukKontroluYap_Click(object sender, EventArgs e)
        {
            string etkinlik_id_text = textBoxEtkinlikUygunlukKontrolId.Text;
            int etkinlik_id = 0;

            int.TryParse(etkinlik_id_text, out etkinlik_id);

            if (etkinlik_id == 0)
            {
                MessageBox.Show("Bu etkinlik Id sine ait bir kayıt bulunamadı !!!");
                return;
            }

            for (int i = 0; i < EtkinliklerTablosu.Count; i++)
            {
                if (etkinlik_id == EtkinliklerTablosu[i].etkinlik_id)
                {
                    MessageBox.Show(etkinlik_id.ToString() + " Id li etkinlik için boş sandalye sayısı : " + EtkinliklerTablosu[i].etkinlik_bos_yer_sayisi.ToString());
                    return;
                }
            }

            MessageBox.Show("Bu etkinlik Id sine ait bir kayıt bulunamadı !!!");
        }

        private void buttonKatilimciKaydet_Click(object sender, EventArgs e)
        {
            string katilimci_ad_soyad = textBoxKatilimciAdsoyad.Text;
            string katilimci_e_posta_adresi = textBoxKatilimciEPostaAdresi.Text;

            SinifKatilimci yeni = new SinifKatilimci(KatilimciIdSayaci++, katilimci_ad_soyad, katilimci_e_posta_adresi);
            KatilimcilarTablosu.Add(yeni);

            MessageBox.Show("Katılımcı başarıyla kaydedildi.");
        }

        private void buttonBiletSatinAl_Click(object sender, EventArgs e)
        {
            int etkinlik_index = comboBoxKayitliEtkinlikler.SelectedIndex;
            int katilimci_index = comboBoxKayitliKatilimcilar.SelectedIndex;

            if (etkinlik_index < 0)
            {
                MessageBox.Show("Lütfen bir etkinlik seçip tekrar deneyiniz!!!");
                return;
            }

            if (katilimci_index < 0)
            {
                MessageBox.Show("Lütfen bir katilimci seçip tekrar deneyiniz!!!");
                return;
            }

            SinifEtkinlik etkinlik = EtkinliklerTablosu[etkinlik_index];
            SinifKatilimci katilimci = KatilimcilarTablosu[katilimci_index];

            if (etkinlik.etkinlik_bos_yer_sayisi == 0)
            {
                MessageBox.Show("Bu etkinlikte boş yer yok. Lütfen daha sonra tekrar deneyiniz ya da başka bir etkinlik seçiniz!!!");
                return;
            }

            SinifBilet yeni = new SinifBilet(BiletIdSayaci++, etkinlik.etkinlik_id, katilimci.katilimci_id, etkinlik.etkinlik_ucreti);
            etkinlik.KatilimciyiKaydet();
            BiletlerTablosu.Add(yeni);
            MessageBox.Show("Bilet başarıyla alındı.");
        }

        private void comboBoxKayitliEtkinlikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int etkinlik_index = comboBoxKayitliEtkinlikler.SelectedIndex;
            SinifEtkinlik etkinlik = EtkinliklerTablosu[etkinlik_index];

            textBoxBosKapasite.Text = etkinlik.etkinlik_bos_yer_sayisi.ToString();
            textBoxBiletUcreti.Text = etkinlik.etkinlik_ucreti.ToString();
        }

        private void btnKatilimciSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageKatilimciSil);
            tabControl1.SelectTab(tabPageKatilimciSil);

            comboBoxKayitliKatilimcilarSil.Items.Clear();

            for (int i = 0; i < KatilimcilarTablosu.Count; i++)
            {
                string s = KatilimcilarTablosu[i].katilimci_id.ToString() + " => " + KatilimcilarTablosu[i].katilimci_ad_soyad + " => " + KatilimcilarTablosu[i].katilimci_e_posta_adresi;
                comboBoxKayitliKatilimcilarSil.Items.Add(s);
            }
        }

        private void btnKatilimciListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageKatilimciListele);
            tabControl1.SelectTab(tabPageKatilimciListele);

            listBoxKatilimciListesi.Items.Clear();
            
            for (int i = 0; i < KatilimcilarTablosu.Count; i++)
            {
                string s = KatilimcilarTablosu[i].katilimci_id.ToString() + " => " + KatilimcilarTablosu[i].katilimci_ad_soyad + " => " + KatilimcilarTablosu[i].katilimci_e_posta_adresi;
                listBoxKatilimciListesi.Items.Add(s);
            }
        }

        private void btnBiletIptalEt_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageBiletIptalEt);
            tabControl1.SelectTab(tabPageBiletIptalEt);

            comboBoxKayitliBiletler.Items.Clear();

            for (int i = 0; i < BiletlerTablosu.Count; i++)
            {
                string s = BiletlerTablosu[i].bilet_id.ToString() + " => " + BiletlerTablosu[i].bilet_etkinlik_id.ToString() + " => " + BiletlerTablosu[i].bilet_katilimci_id.ToString();
                comboBoxKayitliBiletler.Items.Add(s);
            }

        }

        private void btnBiletListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniDevreDisiBirak();

            tabControl1.TabPages.Add(tabPageBiletleriListele);
            tabControl1.SelectTab(tabPageBiletleriListele);

            listBoxBiletListesi.Items.Clear();

            for (int i = 0; i < BiletlerTablosu.Count; i++)
            {
                SinifEtkinlik etkinlik = EtkinliklerTablosu[BiletlerTablosu[i].bilet_etkinlik_id-1];
                SinifKatilimci katilimci = KatilimcilarTablosu[BiletlerTablosu[i].bilet_katilimci_id-1];

                string s = BiletlerTablosu[i].bilet_id.ToString() + " => " + katilimci.katilimci_ad_soyad + " => " + etkinlik.etkinlik_adi;
                listBoxBiletListesi.Items.Add(s);
            }

        }

        private void buttonKatilimciSil_Click(object sender, EventArgs e)
        {
            int sil_index = comboBoxKayitliKatilimcilarSil.SelectedIndex;

            if (sil_index < 0)
            {
                MessageBox.Show("Katılımcı seçimi yapılmadı. Lütfen silinecek katılımcıyı seçip tekrar deneyiniz!!!");
                return;
            }

            KatilimcilarTablosu.RemoveAt(sil_index);
            MessageBox.Show("Katılımcı başarıyla silindi");
        }

        private void buttonBiletSil_Click(object sender, EventArgs e)
        {
            int sil_index = comboBoxKayitliBiletler.SelectedIndex;

            if (sil_index < 0)
            {
                MessageBox.Show("Bilet seçimi yapılmadı. Lütfen silinecek bileti seçip tekrar deneyiniz!!!");
                return;
            }

            BiletlerTablosu.RemoveAt(sil_index);
            MessageBox.Show("Bilet başarıyla silindi");

        }
    }
}
