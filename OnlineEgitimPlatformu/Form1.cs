namespace OnlineEgitimPlatformu
{
    public partial class Form1 : Form
    {
        private List<SinifOgrenci> OgrencilerTablosu = new List<SinifOgrenci>();
        private List<SinifEgitmen> EgitmenlerTablosu = new List<SinifEgitmen>();
        private List<SinifKurs> KurslarTablosu = new List<SinifKurs>();
        private List<SinifKursKaydi> KursKayitlariTablosu = new List<SinifKursKaydi>();
        private int OgrenciIdSayaci = 1;
        private int EgitmenIdSayaci = 1;
        private int KursIdSayaci = 1;
        private int KursKayitlariIdSayaci = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageOgrenciEkle);
            tabControl1.SelectTab(tabPageOgrenciEkle);
        }


        private void TabSayfalariniTemizle()
        {
            tabControl1.TabPages.Remove(tabPageOgrenciEkle);
            tabControl1.TabPages.Remove(tabPageOgrenciSil);
            tabControl1.TabPages.Remove(tabPageOgrenciListele);
            tabControl1.TabPages.Remove(tabPageEgitmenEkle);
            tabControl1.TabPages.Remove(tabPageEgitmenSil);
            tabControl1.TabPages.Remove(tabPageEgitmenListele);
            tabControl1.TabPages.Remove(tabPageKursEkle);
            tabControl1.TabPages.Remove(tabPageKursSil);
            tabControl1.TabPages.Remove(tabPageKursListele);
            tabControl1.TabPages.Remove(tabPageKursKaydiYap);
            tabControl1.TabPages.Remove(tabPageKursKaydiSil);
            tabControl1.TabPages.Remove(tabPageKursKayitlariListele);
        }

        private void LoadOgrenciler(ComboBox cbox)
        {
            cbox.Items.Clear();

            for (int i = 0; i < OgrencilerTablosu.Count; i++)
            {
                String s = "id:" + OgrencilerTablosu[i].ogrenci_id.ToString() + " => " +
                           "ad:" + OgrencilerTablosu[i].ogrenci_ad_soyad + " => " +
                           "eposta:" + OgrencilerTablosu[i].ogrenci_e_posta;

                cbox.Items.Add(s);
            }

            cbox.SelectedIndex = -1;
            cbox.Text = "";
        }

        private void LoadOgrenciler(ListBox lbox)
        {
            lbox.Items.Clear();

            for (int i = 0; i < OgrencilerTablosu.Count; i++)
            {
                String s = "id:" + OgrencilerTablosu[i].ogrenci_id.ToString() + " => " +
                           "ad:" + OgrencilerTablosu[i].ogrenci_ad_soyad + " => " +
                           "eposta:" + OgrencilerTablosu[i].ogrenci_e_posta;

                lbox.Items.Add(s);
            }
        }

        private void LoadEgitmenler(ComboBox cbox)
        {
            cbox.Items.Clear();

            for (int i = 0; i < EgitmenlerTablosu.Count; i++)
            {
                String s = "id:" + EgitmenlerTablosu[i].egitmen_id.ToString() + " => " +
                           "ad:" + EgitmenlerTablosu[i].egitmen_ad_soyad + " => " +
                           "uzmanlık:" + EgitmenlerTablosu[i].egitmen_uzmanlik;

                cbox.Items.Add(s);
            }

            cbox.SelectedIndex = -1;
            cbox.Text = "";
        }

        private void LoadEgitmenler(ListBox lbox)
        {
            lbox.Items.Clear();

            for (int i = 0; i < EgitmenlerTablosu.Count; i++)
            {
                String s = "id:" + EgitmenlerTablosu[i].egitmen_id.ToString() + " => " +
                           "ad:" + EgitmenlerTablosu[i].egitmen_ad_soyad + " => " +
                           "uzmanlık:" + EgitmenlerTablosu[i].egitmen_uzmanlik;

                lbox.Items.Add(s);
            }
        }

        private void LoadKurslar(ComboBox cbox)
        {
            cbox.Items.Clear();

            for (int i = 0; i < KurslarTablosu.Count; i++)
            {
                String s = "id:" + KurslarTablosu[i].kurs_id.ToString() + " => " +
                           "ad:" + KurslarTablosu[i].kurs_ad + " => " +
                           "egitmen:" + KurslarTablosu[i].kurs_egitmen.egitmen_ad_soyad + " => " +
                           "icerik:" + KurslarTablosu[i].kurs_icerik;

                cbox.Items.Add(s);
            }

            cbox.SelectedIndex = -1;
            cbox.Text = "";
        }

        private void LoadKurslar(ListBox lbox)
        {
            lbox.Items.Clear();

            for (int i = 0; i < KurslarTablosu.Count; i++)
            {
                String s = "id:" + KurslarTablosu[i].kurs_id.ToString() + " => " +
                           "ad:" + KurslarTablosu[i].kurs_ad + " => " +
                           "egitmen:" + KurslarTablosu[i].kurs_egitmen.egitmen_ad_soyad + " => " +
                           "icerik:" + KurslarTablosu[i].kurs_icerik;

                lbox.Items.Add(s);
            }
        }

        private void LoadKursKayitlari(ComboBox cbox)
        {
            cbox.Items.Clear();

            for (int i = 0; i < KursKayitlariTablosu.Count; i++)
            {
                SinifKurs kurs = KurslarTablosu[KursKayitlariTablosu[i].kurs_id];
                SinifOgrenci ogrenci = OgrencilerTablosu[KursKayitlariTablosu[i].kurs_ogrenci_id];
                SinifEgitmen egitmen = EgitmenlerTablosu[KursKayitlariTablosu[i].kurs_egitici_id];

                String s = "id:" + KursKayitlariTablosu[i].kurs_kaydi_id.ToString() + " => " +
                           "kurs:" + kurs.kurs_ad + " => " +
                           "egitmen:" + egitmen.egitmen_ad_soyad + " => " +
                           "ogrenci:" + ogrenci.ogrenci_ad_soyad;

                cbox.Items.Add(s);
            }

            cbox.SelectedIndex = -1;
            cbox.Text = "";
        }

        private void LoadKursKayitlari(ListBox lbox)
        {
            lbox.Items.Clear();

            for (int i = 0; i < KursKayitlariTablosu.Count; i++)
            {
                SinifKurs kurs = KurslarTablosu[KursKayitlariTablosu[i].kurs_id];
                SinifOgrenci ogrenci = OgrencilerTablosu[KursKayitlariTablosu[i].kurs_ogrenci_id];
                SinifEgitmen egitmen = EgitmenlerTablosu[KursKayitlariTablosu[i].kurs_egitici_id];

                String s = "id:" + KursKayitlariTablosu[i].kurs_kaydi_id.ToString() + " => " +
                           "kurs:" + kurs.kurs_ad + " => " +
                           "egitmen:" + egitmen.egitmen_ad_soyad + " => " +
                           "ogrenci:" + ogrenci.ogrenci_ad_soyad;

                lbox.Items.Add(s);
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageOgrenciEkle);
            tabControl1.SelectTab(tabPageOgrenciEkle);
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageOgrenciSil);
            tabControl1.SelectTab(tabPageOgrenciSil);

            LoadOgrenciler(comboBoxKayitliOgrenciler);
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageOgrenciListele);
            tabControl1.SelectTab(tabPageOgrenciListele);

            LoadOgrenciler(listBoxKayitliOgrencilerListesi);
        }

        private void btnEgitmenEkle_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageEgitmenEkle);
            tabControl1.SelectTab(tabPageEgitmenEkle);

        }

        private void btnEgitmenSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageEgitmenSil);
            tabControl1.SelectTab(tabPageEgitmenSil);

            LoadEgitmenler(comboBoxKayitliEgitmenlerSil);
        }

        private void btnEgitmenListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageEgitmenListele);
            tabControl1.SelectTab(tabPageEgitmenListele);

            LoadEgitmenler(listBoxKayitliEgitmenlerListesi);
        }

        private void btnKursEkle_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKursEkle);
            tabControl1.SelectTab(tabPageKursEkle);

            LoadEgitmenler(comboBoxKursEgitmenlerListesi);
        }

        private void btnKursSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKursSil);
            tabControl1.SelectTab(tabPageKursSil);

            LoadKurslar(comboBoxKayitliKurslarSil);
        }

        private void btnKursListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKursListele);
            tabControl1.SelectTab(tabPageKursListele);

            LoadKurslar(listBoxKayitliKurslarListesi);
        }

        private void btnKursaKaydet_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKursKaydiYap);
            tabControl1.SelectTab(tabPageKursKaydiYap);

            LoadKurslar(comboBoxKayitliKurslarKayit);
            LoadEgitmenler(comboBoxKayitliEgitmenlerKayit);
            LoadOgrenciler(comboBoxKayitliOgrencilerKayit);
        }

        private void btnKursKaydiSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKursKaydiSil);
            tabControl1.SelectTab(tabPageKursKaydiSil);

            LoadKursKayitlari(comboBoxKayitliKursKayitlariSil);
        }

        private void btnKursKayitlariListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKursKayitlariListele);
            tabControl1.SelectTab(tabPageKursKayitlariListele);

            LoadKursKayitlari(listBoxKursKayitlariListesi);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            string ogrenci_ad_soyad = textBoxOgrenciAdSoyad.Text;
            string ogrenci_e_posta_adresi = textBoxOgrenciEPostaAdresi.Text;

            if ((ogrenci_ad_soyad == "") || (ogrenci_e_posta_adresi == ""))
            {
                MessageBox.Show("Öğrenci ad ve/veya e-posta alanlarından en az bir tanesi boş girilmiş. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifOgrenci yeni = new SinifOgrenci();
            yeni.ogrenci_ad_soyad = ogrenci_ad_soyad;
            yeni.ogrenci_e_posta = ogrenci_e_posta_adresi;
            yeni.ogrenci_id = OgrenciIdSayaci++;

            OgrencilerTablosu.Add(yeni);
            MessageBox.Show("Öğrenci kaydı başarıyla yapıldı");

        }

        private void buttonOgrenciSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliOgrenciler.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Öğrenci silme başarısız oldu !!!\r\nÖnce kayıtlı bir öğrenci seçip sonra tekrar deneyiniz.");
                return;
            }

            OgrencilerTablosu.RemoveAt(index);
            MessageBox.Show("Öğrenci kaydı başarıyla silindi");

            LoadOgrenciler(comboBoxKayitliOgrenciler);
        }

        private void buttonEgitmenEkle_Click(object sender, EventArgs e)
        {
            string egitmen_ad_soyad = textBoxEgitmenAdSoyad.Text;
            string egitmen_uzmanlik = textBoxEgitmenUzmanlik.Text;

            if ((egitmen_ad_soyad == "") || (egitmen_uzmanlik == ""))
            {
                MessageBox.Show("Eğitmen ad ve/veya uzmanlık alanlarından en az bir tanesi boş girilmiş. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifEgitmen yeni = new SinifEgitmen();
            yeni.egitmen_ad_soyad = egitmen_ad_soyad;
            yeni.egitmen_uzmanlik = egitmen_uzmanlik;
            yeni.egitmen_id = EgitmenIdSayaci++;

            EgitmenlerTablosu.Add(yeni);
            MessageBox.Show("Eğitmen kaydı başarıyla yapıldı");

        }

        private void buttonEgitmenSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliEgitmenlerSil.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Eğitmen silme başarısız oldu !!!\r\nÖnce kayıtlı bir eğitmen seçip sonra tekrar deneyiniz.");
                return;
            }

            EgitmenlerTablosu.RemoveAt(index);
            MessageBox.Show("Eğitmen kaydı başarıyla silindi");

            LoadEgitmenler(comboBoxKayitliEgitmenlerSil);
        }

        private void buttonKursEkle_Click(object sender, EventArgs e)
        {
            string kurs_ad = textBoxKursAd.Text;
            int egitmen_index = comboBoxKursEgitmenlerListesi.SelectedIndex;
            string kurs_icerik = textBoxKursIcerik.Text;
            SinifEgitmen egitmen;

            if (egitmen_index < 0)
            {
                MessageBox.Show("Eğitmen seçimi yapılmamış. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            egitmen = EgitmenlerTablosu[egitmen_index];

            if (kurs_ad == "")
            {
                MessageBox.Show("Kurs adı seçilmemiş. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifKurs yeni = new SinifKurs();
            yeni.kurs_ad = kurs_ad;
            yeni.kurs_icerik = kurs_icerik;
            yeni.kurs_egitmen = egitmen;
            yeni.kurs_id = KursIdSayaci++;

            KurslarTablosu.Add(yeni);
            MessageBox.Show("Kurs kaydı başarıyla yapıldı");

        }

        private void buttonKursSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliKurslarSil.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Kurs silme başarısız oldu !!!\r\nÖnce kayıtlı bir kurs seçip sonra tekrar deneyiniz.");
                return;
            }

            KurslarTablosu.RemoveAt(index);
            MessageBox.Show("Kurs kaydı başarıyla silindi");

            LoadKurslar(comboBoxKayitliKurslarSil);

        }

        private void buttonKursKaydiYap_Click(object sender, EventArgs e)
        {
            int kurs_index = comboBoxKayitliKurslarKayit.SelectedIndex;
            int egitmen_index = comboBoxKayitliEgitmenlerKayit.SelectedIndex;
            int ogrenci_index = comboBoxKayitliOgrencilerKayit.SelectedIndex;

            if (kurs_index < 0)
            {
                MessageBox.Show("Kurs seçimi yapılmamış. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            if (egitmen_index < 0)
            {
                MessageBox.Show("Eğitmen seçimi yapılmamış. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            if (ogrenci_index < 0)
            {
                MessageBox.Show("Öğrenci seçimi yapılmamış. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifKursKaydi yeni = new SinifKursKaydi();
            yeni.kurs_kaydi_id = KursKayitlariIdSayaci++;
            yeni.kurs_id = kurs_index;
            yeni.kurs_egitici_id = egitmen_index;
            yeni.kurs_ogrenci_id = ogrenci_index;

            KursKayitlariTablosu.Add(yeni);
            MessageBox.Show("Kurs kaydı başarıyla yapıldı");

            LoadKurslar(comboBoxKayitliKurslarKayit);
            LoadEgitmenler(comboBoxKayitliEgitmenlerKayit);
            LoadOgrenciler(comboBoxKayitliOgrencilerKayit);
        }

        private void buttonKursKaydiSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliKursKayitlariSil.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Kurs kaydı silme başarısız oldu !!!\r\nÖnce kayıtlı bir kurs kaydı seçip sonra tekrar deneyiniz.");
                return;
            }

            KursKayitlariTablosu.RemoveAt(index);
            MessageBox.Show("Kurs kaydı başarıyla silindi");

            LoadKursKayitlari(comboBoxKayitliKursKayitlariSil);

        }

    }
}
