namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        private List<SinifKitap> KitaplarTablosu = new List<SinifKitap>();
        private List<SinifUye> UyelerTablosu = new List<SinifUye>();
        private List<SinifOdunc> OdunclerTablosu = new List<SinifOdunc>();
        private int KitapIdSayaci = 1;
        private int UyeIdSayaci = 1;
        private int OduncIdSayaci = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TabSayfalariniTemizle()
        {
            tabControl1.TabPages.Remove(tabPageKitapEkle);
            tabControl1.TabPages.Remove(tabPageKitapSil);
            tabControl1.TabPages.Remove(tabPageKitapListele);
            tabControl1.TabPages.Remove(tabPageUyeEkle);
            tabControl1.TabPages.Remove(tabPageUyeSil);
            tabControl1.TabPages.Remove(tabPageUyeListele);
            tabControl1.TabPages.Remove(tabPageOduncAl);
            tabControl1.TabPages.Remove(tabPageOduncIadeEt);
            tabControl1.TabPages.Remove(tabPageOduncListele);
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKitapEkle);
            tabControl1.SelectTab(tabPageKitapEkle);

        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKitapSil);
            tabControl1.SelectTab(tabPageKitapSil);

            comboBoxKayitliKitaplar.Items.Clear();

            for (int i = 0; i < KitaplarTablosu.Count; i++)
            {
                String s = "id:" + KitaplarTablosu[i].kitap_id.ToString() + " => " +
                           "ad:" + KitaplarTablosu[i].kitap_ad + " => " +
                           "yazar:" + KitaplarTablosu[i].kitap_yazar;
                comboBoxKayitliKitaplar.Items.Add(s);
            }

            comboBoxKayitliKitaplar.SelectedIndex = -1;
            comboBoxKayitliKitaplar.Text = "";

        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKitapListele);
            tabControl1.SelectTab(tabPageKitapListele);

            listBoxKayitliKitaplarListesi.Items.Clear();

            for (int i = 0; i < KitaplarTablosu.Count; i++)
            {
                String s = "id:" + KitaplarTablosu[i].kitap_id.ToString() + " => " +
                           "ad:" + KitaplarTablosu[i].kitap_ad + " => " +
                           "yazar:" + KitaplarTablosu[i].kitap_yazar;
                listBoxKayitliKitaplarListesi.Items.Add(s);
            }

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageUyeEkle);
            tabControl1.SelectTab(tabPageUyeEkle);

        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageUyeSil);
            tabControl1.SelectTab(tabPageUyeSil);

            comboBoxKayitliUyelerSil.Items.Clear();

            for (int i = 0; i < UyelerTablosu.Count; i++)
            {
                String s = "id:" + UyelerTablosu[i].uye_id.ToString() + " => " +
                           "uye:" + UyelerTablosu[i].uye_ad_soyad + " => " +
                           "tc:" + UyelerTablosu[i].uye_tc_kimlik_no + " => " +
                           "tel:" + UyelerTablosu[i].uye_telefon + " => " +
                           "eposta:" + UyelerTablosu[i].uye_e_posta;

                comboBoxKayitliUyelerSil.Items.Add(s);
            }

            comboBoxKayitliUyelerSil.SelectedIndex = -1;
            comboBoxKayitliUyelerSil.Text = "";

        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageUyeListele);
            tabControl1.SelectTab(tabPageUyeListele);

            listBoxKayitliUyelerListesi.Items.Clear();

            for (int i = 0; i < UyelerTablosu.Count; i++)
            {
                String s = "id:" + UyelerTablosu[i].uye_id.ToString() + " => " +
                           "uye:" + UyelerTablosu[i].uye_ad_soyad + " => " +
                           "tc:" + UyelerTablosu[i].uye_tc_kimlik_no + " => " +
                           "tel:" + UyelerTablosu[i].uye_telefon + " => " +
                           "eposta:" + UyelerTablosu[i].uye_e_posta;

                listBoxKayitliUyelerListesi.Items.Add(s);
            }

        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageOduncAl);
            tabControl1.SelectTab(tabPageOduncAl);

            comboBoxKayitliKitaplarOdunc.Items.Clear();

            for (int i = 0; i < KitaplarTablosu.Count; i++)
            {
                String s = "id:" + KitaplarTablosu[i].kitap_id.ToString() + " => " +
                           "ad:" + KitaplarTablosu[i].kitap_ad + " => " +
                           "yazar:" + KitaplarTablosu[i].kitap_yazar;
                comboBoxKayitliKitaplarOdunc.Items.Add(s);
            }

            comboBoxKayitliKitaplarOdunc.SelectedIndex = -1;
            comboBoxKayitliKitaplarOdunc.Text = "";

            comboBoxKayitliUyelerOdunc.Items.Clear();

            for (int i = 0; i < UyelerTablosu.Count; i++)
            {
                String s = "id:" + UyelerTablosu[i].uye_id.ToString() + " => " +
                           "uye:" + UyelerTablosu[i].uye_ad_soyad + " => " +
                           "tc:" + UyelerTablosu[i].uye_tc_kimlik_no + " => " +
                           "tel:" + UyelerTablosu[i].uye_telefon + " => " +
                           "eposta:" + UyelerTablosu[i].uye_e_posta;

                comboBoxKayitliUyelerOdunc.Items.Add(s);
            }

            comboBoxKayitliUyelerOdunc.SelectedIndex = -1;
            comboBoxKayitliUyelerOdunc.Text = "";

        }

        private void btnOduncIadeEt_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageOduncIadeEt);
            tabControl1.SelectTab(tabPageOduncIadeEt);

            comboBoxKayitliOduncler.Items.Clear();

            for (int i = 0; i < OdunclerTablosu.Count; i++)
            {
                SinifKitap kitap = KitaplarTablosu[OdunclerTablosu[i].kitap_id];
                SinifUye uye = UyelerTablosu[OdunclerTablosu[i].uye_id];

                String s = "id:" + OdunclerTablosu[i].odunc_id.ToString() + " => " +
                           "uye:" + uye.uye_ad_soyad + " => " +
                           "kitap:" + kitap.kitap_ad;

                comboBoxKayitliOduncler.Items.Add(s);
            }

            comboBoxKayitliOduncler.SelectedIndex = -1;
            comboBoxKayitliOduncler.Text = "";

        }

        private void btnOduncListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageOduncListele);
            tabControl1.SelectTab(tabPageOduncListele);

            listBoxOduncListesi.Items.Clear();

            for (int i = 0; i < OdunclerTablosu.Count; i++)
            {
                SinifKitap kitap = KitaplarTablosu[OdunclerTablosu[i].kitap_id];
                SinifUye uye = UyelerTablosu[OdunclerTablosu[i].uye_id];

                String s = "id:" + OdunclerTablosu[i].odunc_id.ToString() + " => " +
                           "uye:" + uye.uye_ad_soyad + " => " +
                           "kitap:" + kitap.kitap_ad;

                listBoxOduncListesi.Items.Add(s);
            }

        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            string kitap_ad = textBoxKitapAd.Text;
            string kitap_yazar = textBoxKitapYazar.Text;

            if ((kitap_ad == "") || (kitap_yazar == ""))
            {
                MessageBox.Show("Kitap ad ve/veya yazar alanlarından en az bir tanesi boş girilmiş. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifKitap yeni = new SinifKitap();
            yeni.kitap_ad = kitap_ad;
            yeni.kitap_yazar = kitap_yazar;
            yeni.kitap_id = KitapIdSayaci++;
            yeni.kitap_durum = true;

            KitaplarTablosu.Add(yeni);
            MessageBox.Show("Kitap kaydı başarıyla yapıldı");

        }

        private void buttonKitapSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliKitaplar.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Kitap silme başarısız oldu !!!\r\nÖnce kayıtlı bir kitap seçip sonra tekrar deneyiniz.");
                return;
            }

            KitaplarTablosu.RemoveAt(index);
            MessageBox.Show("Kitap kaydı başarıyla silindi");

            comboBoxKayitliKitaplar.Items.Clear();
            for (int i = 0; i < KitaplarTablosu.Count; i++)
            {
                String s = "id:" + KitaplarTablosu[i].kitap_id.ToString() + " => " +
                           "ad:" + KitaplarTablosu[i].kitap_ad + " => " +
                           "yazar:" + KitaplarTablosu[i].kitap_yazar;
                comboBoxKayitliKitaplar.Items.Add(s);
            }
            comboBoxKayitliKitaplar.SelectedIndex = -1;
            comboBoxKayitliKitaplar.Text = "";
        }

        private void buttonUyeEkle_Click(object sender, EventArgs e)
        {
            string uye_ad_soyad = textBoxUyeAdSoyad.Text;
            string uye_tc_kimlik_no = textBoxUyeTCKimlikNo.Text;
            string uye_posta_adresi = textBoxUyeEPostaAdresi.Text;
            string uye_telefon_no = textBoxUyeTelefonNo.Text;

            if ((uye_ad_soyad == "") || (uye_tc_kimlik_no == ""))
            {
                MessageBox.Show("Üye ad soyadı ve/veya T.C. Kimlik No alanlarından en az bir tanesi boş girilmiş. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifUye yeni = new SinifUye();
            yeni.uye_id = UyeIdSayaci++;
            yeni.uye_ad_soyad = uye_ad_soyad;
            yeni.uye_tc_kimlik_no = uye_tc_kimlik_no;
            yeni.uye_telefon = uye_telefon_no;
            yeni.uye_e_posta = uye_posta_adresi;

            UyelerTablosu.Add(yeni);
            MessageBox.Show("Üye kaydı başarıyla yapıldı");

        }

        private void buttonUyeSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliUyelerSil.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Üye silme başarısız oldu !!!\r\nÖnce kayıtlı bir üye seçip sonra tekrar deneyiniz.");
                return;
            }

            UyelerTablosu.RemoveAt(index);
            MessageBox.Show("Üye kaydı başarıyla silindi");

            comboBoxKayitliUyelerSil.Items.Clear();

            for (int i = 0; i < UyelerTablosu.Count; i++)
            {
                String s = "id:" + UyelerTablosu[i].uye_id.ToString() + " => " +
                           "ad:" + UyelerTablosu[i].uye_ad_soyad + " => " +
                           "tc:" + UyelerTablosu[i].uye_tc_kimlik_no + " => " +
                           "tel:" + UyelerTablosu[i].uye_telefon + " => " +
                           "eposta:" + UyelerTablosu[i].uye_e_posta;

                comboBoxKayitliUyelerSil.Items.Add(s);
            }

            comboBoxKayitliUyelerSil.SelectedIndex = -1;
            comboBoxKayitliUyelerSil.Text = "";

        }

        private void buttonOduncAl_Click(object sender, EventArgs e)
        {
            int kitap_id = comboBoxKayitliKitaplarOdunc.SelectedIndex;
            int uye_id = comboBoxKayitliUyelerOdunc.SelectedIndex;

            if (kitap_id < 0)
            {
                MessageBox.Show("Lütfen önce geçerli bir kitap seçip tekrar deneyiniz.");
                return;
            }

            if (uye_id < 0)
            {
                MessageBox.Show("Lütfen önce geçerli bir üye seçip tekrar deneyiniz.");
                return;
            }

            SinifKitap kitap = KitaplarTablosu[kitap_id];
            SinifUye uye = UyelerTablosu[uye_id];

            SinifOdunc yeni = new SinifOdunc();
            yeni.odunc_id = OduncIdSayaci++;
            yeni.uye_id = uye_id;
            yeni.kitap_id = kitap_id;
            yeni.odunc_verme_tarihi = DateTime.Now;
            yeni.odunc_iade_tarihi = DateTime.MinValue;
            yeni.iade_edildi_mi = false;

            OdunclerTablosu.Add(yeni);
            MessageBox.Show("Randevu kaydı başarıyla yapıldı.");

            comboBoxKayitliUyelerOdunc.SelectedIndex = -1;
            comboBoxKayitliUyelerOdunc.Text = "";
            comboBoxKayitliKitaplarOdunc.SelectedIndex = -1;
            comboBoxKayitliKitaplarOdunc.Text = "";

        }

        private void buttonOduncIadeEt_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliOduncler.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Ödünç iptal etme başarısız oldu !!!\r\nÖnce kayıtlı bir ödünç seçip sonra tekrar deneyiniz.");
                return;
            }

            OdunclerTablosu.RemoveAt(index);
            MessageBox.Show("Ödünç kaydı başarıyla iptal edildi");

            comboBoxKayitliOduncler.Items.Clear();
            for (int i = 0; i < OdunclerTablosu.Count; i++)
            {
                SinifKitap kitap = KitaplarTablosu[OdunclerTablosu[i].kitap_id];
                SinifUye uye = UyelerTablosu[OdunclerTablosu[i].uye_id];

                String s = "id:" + OdunclerTablosu[i].odunc_id.ToString() + " => " +
                           "uye:" + uye.uye_ad_soyad + " => " +
                           "kitap:" + kitap.kitap_ad;

                comboBoxKayitliOduncler.Items.Add(s);
            }
            comboBoxKayitliOduncler.SelectedIndex = -1;
            comboBoxKayitliOduncler.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageKitapEkle);
            tabControl1.SelectTab(tabPageKitapEkle);
        }
    }
}
