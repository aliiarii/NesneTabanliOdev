namespace HastaneRandevuSistemi
{
    public partial class Form1 : Form
    {
        private List<SinifDoktor> DoktorlarTablosu = new List<SinifDoktor>();
        private List<SinifHasta> HastalarTablosu = new List<SinifHasta>();
        private List<SinifRandevu> RandevularTablosu = new List<SinifRandevu>();
        private int HastaIdSayaci = 1;
        private int DoktorIdSayaci = 1;
        private int RandevuIdSayaci = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void TabSayfalariniTemizle()
        {
            tabControl1.TabPages.Remove(tabPageHastaEkle);
            tabControl1.TabPages.Remove(tabPageHastaSil);
            tabControl1.TabPages.Remove(tabPageHastaListele);
            tabControl1.TabPages.Remove(tabPageDoktorEkle);
            tabControl1.TabPages.Remove(tabPageDoktorSil);
            tabControl1.TabPages.Remove(tabPageDoktorListele);
            tabControl1.TabPages.Remove(tabPageRandevuAl);
            tabControl1.TabPages.Remove(tabPageRandevuIptalEt);
            tabControl1.TabPages.Remove(tabPageRandevuListele);
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageHastaEkle);
            tabControl1.SelectTab(tabPageHastaEkle);
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageHastaSil);
            tabControl1.SelectTab(tabPageHastaSil);

            comboBoxKayitliHastalar.Items.Clear();

            for (int i = 0; i < HastalarTablosu.Count; i++)
            {
                String s = HastalarTablosu[i].hasta_id.ToString() + " => " + HastalarTablosu[i].hasta_ad_soyad + " => " + HastalarTablosu[i].hasta_tc_kimlik_no;
                comboBoxKayitliHastalar.Items.Add(s);
            }

            comboBoxKayitliHastalar.SelectedIndex = -1;
            comboBoxKayitliHastalar.Text = "";
        }

        private void btnHastaListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageHastaListele);
            tabControl1.SelectTab(tabPageHastaListele);

            listBoxKayitliHastalarListesi.Items.Clear();

            for (int i = 0; i < HastalarTablosu.Count; i++)
            {
                String s = HastalarTablosu[i].hasta_id.ToString() + " => " + HastalarTablosu[i].hasta_ad_soyad + " => " + HastalarTablosu[i].hasta_tc_kimlik_no;
                listBoxKayitliHastalarListesi.Items.Add(s);
            }
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageDoktorEkle);
            tabControl1.SelectTab(tabPageDoktorEkle);

        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageDoktorSil);
            tabControl1.SelectTab(tabPageDoktorSil);

            comboBoxKayitliDoktorlarSil.Items.Clear();

            for (int i = 0; i < DoktorlarTablosu.Count; i++)
            {
                String s = DoktorlarTablosu[i].doktor_id.ToString() + " => " + DoktorlarTablosu[i].doktor_ad_soyad + " => " + DoktorlarTablosu[i].doktor_uzmanlik;
                comboBoxKayitliDoktorlarSil.Items.Add(s);
            }

            comboBoxKayitliDoktorlarSil.SelectedIndex = -1;
            comboBoxKayitliDoktorlarSil.Text = "";
        }

        private void btnDoktorListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageDoktorListele);
            tabControl1.SelectTab(tabPageDoktorListele);

            listBoxKayitliDoktorListesi.Items.Clear();

            for (int i = 0; i < DoktorlarTablosu.Count; i++)
            {
                String s = DoktorlarTablosu[i].doktor_id.ToString() + " => " + DoktorlarTablosu[i].doktor_ad_soyad + " => " + DoktorlarTablosu[i].doktor_uzmanlik;
                listBoxKayitliDoktorListesi.Items.Add(s);
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageRandevuAl);
            tabControl1.SelectTab(tabPageRandevuAl);

            comboBoxKayitliHastalarRandevu.Items.Clear();

            for (int i = 0; i < HastalarTablosu.Count; i++)
            {
                String s = HastalarTablosu[i].hasta_id.ToString() + " => " + HastalarTablosu[i].hasta_ad_soyad + " => " + HastalarTablosu[i].hasta_tc_kimlik_no;
                comboBoxKayitliHastalarRandevu.Items.Add(s);
            }

            comboBoxKayitliDoktorlarRandevu.Items.Clear();

            for (int i = 0; i < DoktorlarTablosu.Count; i++)
            {
                String s = DoktorlarTablosu[i].doktor_id.ToString() + " => " + DoktorlarTablosu[i].doktor_ad_soyad + " => " + DoktorlarTablosu[i].doktor_uzmanlik;
                comboBoxKayitliDoktorlarRandevu.Items.Add(s);
            }

            comboBoxKayitliDoktorlarRandevu.SelectedIndex = -1;
            comboBoxKayitliDoktorlarRandevu.Text = "";
            comboBoxKayitliHastalarRandevu.SelectedIndex = -1;
            comboBoxKayitliHastalarRandevu.Text = "";
        }

        private void btnRandevuIptalEt_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageRandevuIptalEt);
            tabControl1.SelectTab(tabPageRandevuIptalEt);

            comboBoxKayitliRandevular.Items.Clear();

            for (int i = 0; i < RandevularTablosu.Count; i++)
            {
                String s = RandevularTablosu[i].randevu_id.ToString() + " => " + RandevularTablosu[i].doktor.doktor_ad_soyad + " => " + RandevularTablosu[i].doktor.doktor_uzmanlik + " => " + RandevularTablosu[i].hasta.hasta_ad_soyad;
                comboBoxKayitliRandevular.Items.Add(s);
            }

            comboBoxKayitliRandevular.SelectedIndex = -1;
            comboBoxKayitliRandevular.Text = "";
        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            TabSayfalariniTemizle();
            tabControl1.TabPages.Add(tabPageRandevuListele);
            tabControl1.SelectTab(tabPageRandevuListele);

            listBoxRandevuListesi.Items.Clear();

            for (int i = 0; i < RandevularTablosu.Count; i++)
            {
                String s = RandevularTablosu[i].randevu_id.ToString() + " => " + RandevularTablosu[i].doktor.doktor_ad_soyad + " => " + RandevularTablosu[i].doktor.doktor_uzmanlik + " => " + RandevularTablosu[i].hasta.hasta_ad_soyad;
                listBoxRandevuListesi.Items.Add(s);
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHastaEkle_Click(object sender, EventArgs e)
        {
            string hasta_ad_soyad = textBoxHastaAdSoyad.Text;
            string hasta_tc_kimlik_no = textBoxHastaTCKimlikNo.Text;

            if ((hasta_ad_soyad == "") || (hasta_tc_kimlik_no == ""))
            {
                MessageBox.Show("Hasta ad soyadı ve/veya tc kimlik numarası alanlarından en az bir tanesi boş girilmiş. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifHasta yeni = new SinifHasta(HastaIdSayaci++, hasta_ad_soyad, hasta_tc_kimlik_no);

            HastalarTablosu.Add(yeni);
            MessageBox.Show("Hasta kaydı başarıyla yapıldı");
        }

        private void buttonDoktorEkle_Click(object sender, EventArgs e)
        {
            string doktor_ad_soyad = textBoxDoktorAdSoyad.Text;
            string doktor_uzmanlik = textBoxDoktorUzmanlik.Text;

            if ((doktor_ad_soyad == "") || (doktor_uzmanlik == ""))
            {
                MessageBox.Show("Doktor ad soyadı ve/veya uzmanlık alanlarından en az bir tanesi boş girilmiş. Lütfen kontrol edip tekrar deneyiniz !!!");
                return;
            }

            SinifDoktor yeni = new SinifDoktor(DoktorIdSayaci++, doktor_ad_soyad, doktor_uzmanlik);

            DoktorlarTablosu.Add(yeni);
            MessageBox.Show("Doktor kaydı başarıyla yapıldı");

        }

        private void buttonHastaSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliHastalar.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Hasta silme başarısız oldu !!!\r\nÖnce kayıtlı bir hasta seçip sonra tekrar deneyiniz.");
                return;
            }

            HastalarTablosu.RemoveAt(index);
            MessageBox.Show("Hasta kaydı başarıyla silindi");

            comboBoxKayitliHastalar.Items.Clear();

            for (int i = 0; i < HastalarTablosu.Count; i++)
            {
                String s = HastalarTablosu[i].hasta_id.ToString() + " => " + HastalarTablosu[i].hasta_ad_soyad + " => " + HastalarTablosu[i].hasta_tc_kimlik_no;
                comboBoxKayitliHastalar.Items.Add(s);
            }

            comboBoxKayitliHastalar.SelectedIndex = -1;
            comboBoxKayitliHastalar.Text = "";

        }

        private void buttonDoktorSil_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliDoktorlarSil.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Doktor silme başarısız oldu !!!\r\nÖnce kayıtlı bir doktor seçip sonra tekrar deneyiniz.");
                return;
            }

            DoktorlarTablosu.RemoveAt(index);
            MessageBox.Show("Doktor kaydı başarıyla silindi");

            comboBoxKayitliDoktorlarSil.Items.Clear();

            for (int i = 0; i < DoktorlarTablosu.Count; i++)
            {
                String s = DoktorlarTablosu[i].doktor_id.ToString() + " => " + DoktorlarTablosu[i].doktor_ad_soyad + " => " + DoktorlarTablosu[i].doktor_uzmanlik;
                comboBoxKayitliDoktorlarSil.Items.Add(s);
            }

            comboBoxKayitliDoktorlarSil.SelectedIndex = -1;
            comboBoxKayitliDoktorlarSil.Text = "";
        }

        private void buttonRandevuIptalEt_Click(object sender, EventArgs e)
        {
            int index = comboBoxKayitliRandevular.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Randevu iptal etme başarısız oldu !!!\r\nÖnce kayıtlı bir randevu seçip sonra tekrar deneyiniz.");
                return;
            }

            RandevularTablosu.RemoveAt(index);
            MessageBox.Show("Randevu kaydı başarıyla iptal edildi");

            comboBoxKayitliRandevular.Items.Clear();

            for (int i = 0; i < RandevularTablosu.Count; i++)
            {
                String s = RandevularTablosu[i].randevu_id.ToString() + " => " + RandevularTablosu[i].doktor.doktor_ad_soyad + " => " + RandevularTablosu[i].doktor.doktor_uzmanlik + " => " + RandevularTablosu[i].hasta.hasta_ad_soyad;
                comboBoxKayitliRandevular.Items.Add(s);
            }

            comboBoxKayitliRandevular.SelectedIndex = -1;
            comboBoxKayitliRandevular.Text = "";
        }

        private void buttonRandevuAl_Click(object sender, EventArgs e)
        {
            int hasta_id = comboBoxKayitliHastalarRandevu.SelectedIndex;
            int doktor_id = comboBoxKayitliDoktorlarRandevu.SelectedIndex;

            if(hasta_id < 0)
            {
                MessageBox.Show("Lütfen önce geçerli bir hasta seçip tekrar deneyiniz.");
                return;
            }

            if (doktor_id < 0)
            {
                MessageBox.Show("Lütfen önce geçerli bir doktor seçip tekrar deneyiniz.");
                return;
            }

            SinifHasta hasta = HastalarTablosu[hasta_id];
            SinifDoktor doktor = DoktorlarTablosu[doktor_id];

            SinifRandevu yeni = new SinifRandevu(RandevuIdSayaci++,doktor,hasta, dateTimePickerRandevuTarih.Value);
            RandevularTablosu.Add(yeni);
            MessageBox.Show("Randevu kaydı başarıyla yapıldı.");

            comboBoxKayitliDoktorlarRandevu.SelectedIndex = -1;
            comboBoxKayitliDoktorlarRandevu.Text = "";
            comboBoxKayitliHastalarRandevu.SelectedIndex = -1;
            comboBoxKayitliHastalarRandevu.Text = "";
        }
    }
}
