using System.Windows.Forms;

namespace AraçKiralamaSistemi
{
    public partial class Form1 : Form
    {
        List<SinifArac> AraclarTablosu = new List<SinifArac>();
        List<SinifMusteri> MusterilerTablosu = new List<SinifMusteri>();
        SinifKiralama KiralamaListesi = new SinifKiralama();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AraclariListele()
        {
            listBoxAraclarTablosu.Items.Clear();

            for (int i = 0; i < AraclarTablosu.Count; i++)
            {
                listBoxAraclarTablosu.Items.Add(AraclarTablosu[i].AracId.ToString() + " => " + AraclarTablosu[i].Model);
            }
        }

        private void MusterileriListele()
        {
            listBoxMusterilerTablosu.Items.Clear();

            for (int i = 0; i < MusterilerTablosu.Count; i++)
            {
                listBoxMusterilerTablosu.Items.Add(MusterilerTablosu[i].MusteriId.ToString() + " => " + MusterilerTablosu[i].AdSoyad + " => " + MusterilerTablosu[i].TelefonNo);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageAracListele);
            tabControl1.SelectTab(tabPageAracListele);

            AraclariListele();

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageAracEkle);
            tabControl1.SelectTab(tabPageAracEkle);

        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageAracSil);
            tabControl1.SelectTab(tabPageAracSil);

        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageAracListele);
            tabControl1.SelectTab(tabPageAracListele);

            AraclariListele();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageMusteriEkle);
            tabControl1.SelectTab(tabPageMusteriEkle);

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageMusteriSil);
            tabControl1.SelectTab(tabPageMusteriSil);

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageMusteriListele);
            tabControl1.SelectTab(tabPageMusteriListele);

            MusterileriListele();
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageAracKirala);
            tabControl1.SelectTab(tabPageAracKirala);

        }

        private void btnAracKiralamaIptalEt_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageAracKiralamaIptalEt);
            tabControl1.SelectTab(tabPageAracKiralamaIptalEt);

        }

        private void btnAracKiralamaBilgileri_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAracEkle);
            tabControl1.TabPages.Remove(tabPageAracSil);
            tabControl1.TabPages.Remove(tabPageAracListele);
            tabControl1.TabPages.Remove(tabPageMusteriEkle);
            tabControl1.TabPages.Remove(tabPageMusteriSil);
            tabControl1.TabPages.Remove(tabPageMusteriListele);
            tabControl1.TabPages.Remove(tabPageAracKirala);
            tabControl1.TabPages.Remove(tabPageAracKiralamaIptalEt);
            tabControl1.TabPages.Remove(tabPageAracKiralamaBilgileri);

            tabControl1.TabPages.Add(tabPageAracKiralamaBilgileri);
            tabControl1.SelectTab(tabPageAracKiralamaBilgileri);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAracEkle_Click(object sender, EventArgs e)
        {
            string id_text = textBoxAracEkleId.Text;
            int arac_id = 0;
            string model_text = textBoxModel.Text;

            int.TryParse(id_text, out arac_id);


            for (int i = 0; i < AraclarTablosu.Count; i++)
            {
                if (arac_id == AraclarTablosu[i].AracId)
                {
                    MessageBox.Show("Bu araç Id sine ait bir kayıt mevcut. Lütfen konttol edip tekrar deneyiniz!!!");
                    return;
                }
            }

            SinifArac yeni = new SinifArac();
            yeni.AracId = arac_id;
            yeni.Model = model_text;
            AraclarTablosu.Add(yeni);

            MessageBox.Show("Araç başarıyla kaydedildi");
        }

        private void buttonAracSil_Click(object sender, EventArgs e)
        {
            string id_text = textBoxAracSilId.Text;
            int arac_id = 0;

            int.TryParse(id_text, out arac_id);


            for (int i = 0; i < AraclarTablosu.Count; i++)
            {
                if (arac_id == AraclarTablosu[i].AracId)
                {
                    AraclarTablosu.RemoveAt(i);
                    MessageBox.Show("Araç başarıyla silindi");
                    return;
                }
            }

            MessageBox.Show("Bu araç Id sine ait bir kayıt mevcut değil. Lütfen konttol edip tekrar deneyiniz!!!");
        }

        private void buttonMusteriSil_Click(object sender, EventArgs e)
        {
            string id_text = textBoxMusteriSilId.Text;
            int musteri_id = 0;

            int.TryParse(id_text, out musteri_id);


            for (int i = 0; i < MusterilerTablosu.Count; i++)
            {
                if (musteri_id == MusterilerTablosu[i].MusteriId)
                {
                    MusterilerTablosu.RemoveAt(i);
                    MessageBox.Show("Müşteri başarıyla silindi");
                    return;
                }
            }

            MessageBox.Show("Bu müşteri Id sine ait bir kayıt mevcut değil. Lütfen konttol edip tekrar deneyiniz!!!");
        }

        private void buttonMusteriEkle_Click(object sender, EventArgs e)
        {
            string id_text = textBoxMusteriEkleId.Text;
            int musteri_id = 0;
            string ad_soyad = textBoxAdSoyad.Text;
            string telefon = textBoxTelefon.Text;
            string tc_kimlik_no = textBoxTcKimlikNo.Text;

            int.TryParse(id_text, out musteri_id);


            for (int i = 0; i < MusterilerTablosu.Count; i++)
            {
                if (musteri_id == MusterilerTablosu[i].MusteriId)
                {
                    MessageBox.Show("Bu müşteri Id sine ait bir kayıt mevcut. Lütfen konttol edip tekrar deneyiniz!!!");
                    return;
                }
            }

            SinifMusteri yeni = new SinifMusteri();
            yeni.MusteriId = musteri_id;
            yeni.AdSoyad = ad_soyad;
            yeni.TelefonNo = telefon;
            yeni.TcKimlikNo = tc_kimlik_no;

            MusterilerTablosu.Add(yeni);

            MessageBox.Show("Müşteri başarıyla kaydedildi");

        }

        private void buttonKirala_Click(object sender, EventArgs e)
        {
            string arac_id_text = textBoxKiralaAracId.Text;
            string musteri_id_text = textBoxKiralaMusteriId.Text;
            int arac_id = 0;
            int musteri_id = 0;
            Boolean arac_found = false;
            Boolean musteri_found = false;
            int arac_index = 0;
            int musteri_index = 0;

            int.TryParse(arac_id_text, out arac_id);
            int.TryParse(musteri_id_text, out musteri_id);


            for (int i = 0; i < AraclarTablosu.Count; i++)
            {
                if (arac_id == AraclarTablosu[i].AracId)
                {
                    arac_index = i;
                    arac_found = true;
                    break;
                }
            }

            if (!arac_found)
            {
                MessageBox.Show("Girilen araç id sine ait bir kayıt bulunamadı. Lütfen tekrar deneyiniz!!!");
                return;
            }

            for (int i = 0; i < MusterilerTablosu.Count; i++)
            {
                if (musteri_id == MusterilerTablosu[i].MusteriId)
                {
                    musteri_index = i;
                    musteri_found = true;
                    break;
                }
            }

            if (!musteri_found)
            {
                MessageBox.Show("Girilen musteri id sine ait bir kayıt bulunamadı. Lütfen tekrar deneyiniz!!!");
                return;
            }

            KiralamaListesi.KiralamaYap(MusterilerTablosu[musteri_index], AraclarTablosu[arac_index]);

        }

        private void buttonKiralamaIptalEt_Click(object sender, EventArgs e)
        {
            string arac_id_text = textBoxKiralamaIptalAracId.Text;
            string musteri_id_text = textBoxKiralamaIptalMusteriId.Text;
            int arac_id = 0;
            int musteri_id = 0;
            Boolean arac_found = false;
            Boolean musteri_found = false;
            int arac_index = 0;
            int musteri_index = 0;

            int.TryParse(arac_id_text, out arac_id);
            int.TryParse(musteri_id_text, out musteri_id);


            for (int i = 0; i < AraclarTablosu.Count; i++)
            {
                if (arac_id == AraclarTablosu[i].AracId)
                {
                    arac_index = i;
                    arac_found = true;
                    break;
                }
            }

            if (!arac_found)
            {
                MessageBox.Show("Girilen araç id sine ait bir kayıt bulunamadı. Lütfen tekrar deneyiniz!!!");
                return;
            }

            for (int i = 0; i < MusterilerTablosu.Count; i++)
            {
                if (musteri_id == MusterilerTablosu[i].MusteriId)
                {
                    musteri_index = i;
                    musteri_found = true;
                    break;
                }
            }

            if (!musteri_found)
            {
                MessageBox.Show("Girilen musteri id sine ait bir kayıt bulunamadı. Lütfen tekrar deneyiniz!!!");
                return;
            }

            KiralamaListesi.KiralamaIptalEt(MusterilerTablosu[musteri_index], AraclarTablosu[arac_index]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musteri_id_text = textBoxAracKiralamaBilgileriMusteriId.Text;
            int musteri_id = 0;

            int.TryParse(musteri_id_text, out musteri_id);

            listBoxKiralamaTablosu.Items.Clear();

            for (int i = 0; i < MusterilerTablosu.Count; i++)
            {
                if (musteri_id == MusterilerTablosu[i].MusteriId)
                {
                    listBoxKiralamaTablosu.Items.Add(KiralamaListesi.KiralamaBilgisi(MusterilerTablosu[i]));
                    return;
                }
            }

            MessageBox.Show("Girilen musteri id sine ait bir kayıt bulunamadı. Lütfen tekrar deneyiniz!!!");

        }
    }
}
