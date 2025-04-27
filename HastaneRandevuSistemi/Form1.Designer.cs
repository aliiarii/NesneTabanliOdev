namespace HastaneRandevuSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRandevuListele = new Button();
            btnRandevuIptalEt = new Button();
            btnDoktorListele = new Button();
            btnDoktorSil = new Button();
            tabControl1 = new TabControl();
            tabPageHastaEkle = new TabPage();
            textBoxHastaTCKimlikNo = new TextBox();
            textBoxHastaAdSoyad = new TextBox();
            buttonHastaEkle = new Button();
            label3 = new Label();
            label1 = new Label();
            tabPageHastaSil = new TabPage();
            comboBoxKayitliHastalar = new ComboBox();
            buttonHastaSil = new Button();
            label17 = new Label();
            tabPageHastaListele = new TabPage();
            listBoxKayitliHastalarListesi = new ListBox();
            label13 = new Label();
            tabPageDoktorEkle = new TabPage();
            textBoxDoktorUzmanlik = new TextBox();
            textBoxDoktorAdSoyad = new TextBox();
            buttonDoktorEkle = new Button();
            label6 = new Label();
            label8 = new Label();
            tabPageDoktorSil = new TabPage();
            comboBoxKayitliDoktorlarSil = new ComboBox();
            buttonDoktorSil = new Button();
            label19 = new Label();
            tabPageDoktorListele = new TabPage();
            listBoxKayitliDoktorListesi = new ListBox();
            label7 = new Label();
            tabPageRandevuAl = new TabPage();
            dateTimePickerRandevuTarih = new DateTimePicker();
            comboBoxKayitliHastalarRandevu = new ComboBox();
            comboBoxKayitliDoktorlarRandevu = new ComboBox();
            buttonRandevuAl = new Button();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabPageRandevuIptalEt = new TabPage();
            comboBoxKayitliRandevular = new ComboBox();
            buttonRandevuIptalEt = new Button();
            label23 = new Label();
            tabPageRandevuListele = new TabPage();
            listBoxRandevuListesi = new ListBox();
            label18 = new Label();
            btnCikis = new Button();
            btnHastaListele = new Button();
            btnHastaSil = new Button();
            btnRandevuAl = new Button();
            btnDoktorEkle = new Button();
            btnHastaEkle = new Button();
            tabControl1.SuspendLayout();
            tabPageHastaEkle.SuspendLayout();
            tabPageHastaSil.SuspendLayout();
            tabPageHastaListele.SuspendLayout();
            tabPageDoktorEkle.SuspendLayout();
            tabPageDoktorSil.SuspendLayout();
            tabPageDoktorListele.SuspendLayout();
            tabPageRandevuAl.SuspendLayout();
            tabPageRandevuIptalEt.SuspendLayout();
            tabPageRandevuListele.SuspendLayout();
            SuspendLayout();
            // 
            // btnRandevuListele
            // 
            btnRandevuListele.Location = new Point(12, 394);
            btnRandevuListele.Name = "btnRandevuListele";
            btnRandevuListele.Size = new Size(194, 40);
            btnRandevuListele.TabIndex = 21;
            btnRandevuListele.Text = "Randevu Listele";
            btnRandevuListele.UseVisualStyleBackColor = true;
            btnRandevuListele.Click += btnRandevuListele_Click;
            // 
            // btnRandevuIptalEt
            // 
            btnRandevuIptalEt.Location = new Point(12, 348);
            btnRandevuIptalEt.Name = "btnRandevuIptalEt";
            btnRandevuIptalEt.Size = new Size(194, 40);
            btnRandevuIptalEt.TabIndex = 20;
            btnRandevuIptalEt.Text = "Randevu İptal Et";
            btnRandevuIptalEt.UseVisualStyleBackColor = true;
            btnRandevuIptalEt.Click += btnRandevuIptalEt_Click;
            // 
            // btnDoktorListele
            // 
            btnDoktorListele.Location = new Point(12, 256);
            btnDoktorListele.Name = "btnDoktorListele";
            btnDoktorListele.Size = new Size(194, 40);
            btnDoktorListele.TabIndex = 19;
            btnDoktorListele.Text = "Doktor Listele";
            btnDoktorListele.UseVisualStyleBackColor = true;
            btnDoktorListele.Click += btnDoktorListele_Click;
            // 
            // btnDoktorSil
            // 
            btnDoktorSil.Location = new Point(12, 210);
            btnDoktorSil.Name = "btnDoktorSil";
            btnDoktorSil.Size = new Size(194, 40);
            btnDoktorSil.TabIndex = 18;
            btnDoktorSil.Text = "Doktor Sil";
            btnDoktorSil.UseVisualStyleBackColor = true;
            btnDoktorSil.Click += btnDoktorSil_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageHastaEkle);
            tabControl1.Controls.Add(tabPageHastaSil);
            tabControl1.Controls.Add(tabPageHastaListele);
            tabControl1.Controls.Add(tabPageDoktorEkle);
            tabControl1.Controls.Add(tabPageDoktorSil);
            tabControl1.Controls.Add(tabPageDoktorListele);
            tabControl1.Controls.Add(tabPageRandevuAl);
            tabControl1.Controls.Add(tabPageRandevuIptalEt);
            tabControl1.Controls.Add(tabPageRandevuListele);
            tabControl1.Location = new Point(233, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(919, 454);
            tabControl1.TabIndex = 17;
            // 
            // tabPageHastaEkle
            // 
            tabPageHastaEkle.Controls.Add(textBoxHastaTCKimlikNo);
            tabPageHastaEkle.Controls.Add(textBoxHastaAdSoyad);
            tabPageHastaEkle.Controls.Add(buttonHastaEkle);
            tabPageHastaEkle.Controls.Add(label3);
            tabPageHastaEkle.Controls.Add(label1);
            tabPageHastaEkle.Location = new Point(4, 24);
            tabPageHastaEkle.Name = "tabPageHastaEkle";
            tabPageHastaEkle.Padding = new Padding(3);
            tabPageHastaEkle.Size = new Size(911, 426);
            tabPageHastaEkle.TabIndex = 0;
            tabPageHastaEkle.Text = "Hasta Ekle";
            tabPageHastaEkle.UseVisualStyleBackColor = true;
            // 
            // textBoxHastaTCKimlikNo
            // 
            textBoxHastaTCKimlikNo.Location = new Point(136, 58);
            textBoxHastaTCKimlikNo.Name = "textBoxHastaTCKimlikNo";
            textBoxHastaTCKimlikNo.Size = new Size(413, 23);
            textBoxHastaTCKimlikNo.TabIndex = 7;
            // 
            // textBoxHastaAdSoyad
            // 
            textBoxHastaAdSoyad.Location = new Point(136, 18);
            textBoxHastaAdSoyad.Name = "textBoxHastaAdSoyad";
            textBoxHastaAdSoyad.Size = new Size(413, 23);
            textBoxHastaAdSoyad.TabIndex = 5;
            // 
            // buttonHastaEkle
            // 
            buttonHastaEkle.Location = new Point(136, 114);
            buttonHastaEkle.Name = "buttonHastaEkle";
            buttonHastaEkle.Size = new Size(150, 40);
            buttonHastaEkle.TabIndex = 4;
            buttonHastaEkle.Text = "Ekle";
            buttonHastaEkle.UseVisualStyleBackColor = true;
            buttonHastaEkle.Click += buttonHastaEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 69);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı";
            // 
            // tabPageHastaSil
            // 
            tabPageHastaSil.Controls.Add(comboBoxKayitliHastalar);
            tabPageHastaSil.Controls.Add(buttonHastaSil);
            tabPageHastaSil.Controls.Add(label17);
            tabPageHastaSil.Location = new Point(4, 24);
            tabPageHastaSil.Name = "tabPageHastaSil";
            tabPageHastaSil.Size = new Size(911, 426);
            tabPageHastaSil.TabIndex = 3;
            tabPageHastaSil.Text = "Hasta Sil";
            tabPageHastaSil.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliHastalar
            // 
            comboBoxKayitliHastalar.FormattingEnabled = true;
            comboBoxKayitliHastalar.Location = new Point(126, 18);
            comboBoxKayitliHastalar.Name = "comboBoxKayitliHastalar";
            comboBoxKayitliHastalar.Size = new Size(446, 23);
            comboBoxKayitliHastalar.TabIndex = 27;
            // 
            // buttonHastaSil
            // 
            buttonHastaSil.Location = new Point(126, 68);
            buttonHastaSil.Name = "buttonHastaSil";
            buttonHastaSil.Size = new Size(150, 40);
            buttonHastaSil.TabIndex = 25;
            buttonHastaSil.Text = "Sil";
            buttonHastaSil.UseVisualStyleBackColor = true;
            buttonHastaSil.Click += buttonHastaSil_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 26);
            label17.Name = "label17";
            label17.Size = new Size(85, 15);
            label17.TabIndex = 24;
            label17.Text = "Kayıtlı Hastalar";
            // 
            // tabPageHastaListele
            // 
            tabPageHastaListele.Controls.Add(listBoxKayitliHastalarListesi);
            tabPageHastaListele.Controls.Add(label13);
            tabPageHastaListele.Location = new Point(4, 24);
            tabPageHastaListele.Name = "tabPageHastaListele";
            tabPageHastaListele.Size = new Size(911, 426);
            tabPageHastaListele.TabIndex = 4;
            tabPageHastaListele.Text = "Hasta Listele";
            tabPageHastaListele.UseVisualStyleBackColor = true;
            // 
            // listBoxKayitliHastalarListesi
            // 
            listBoxKayitliHastalarListesi.FormattingEnabled = true;
            listBoxKayitliHastalarListesi.ItemHeight = 15;
            listBoxKayitliHastalarListesi.Location = new Point(15, 39);
            listBoxKayitliHastalarListesi.Name = "listBoxKayitliHastalarListesi";
            listBoxKayitliHastalarListesi.Size = new Size(870, 364);
            listBoxKayitliHastalarListesi.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 17);
            label13.Name = "label13";
            label13.Size = new Size(120, 15);
            label13.TabIndex = 24;
            label13.Text = "Kayıtlı Hastalar Listesi";
            // 
            // tabPageDoktorEkle
            // 
            tabPageDoktorEkle.Controls.Add(textBoxDoktorUzmanlik);
            tabPageDoktorEkle.Controls.Add(textBoxDoktorAdSoyad);
            tabPageDoktorEkle.Controls.Add(buttonDoktorEkle);
            tabPageDoktorEkle.Controls.Add(label6);
            tabPageDoktorEkle.Controls.Add(label8);
            tabPageDoktorEkle.Location = new Point(4, 24);
            tabPageDoktorEkle.Name = "tabPageDoktorEkle";
            tabPageDoktorEkle.Padding = new Padding(3);
            tabPageDoktorEkle.Size = new Size(911, 426);
            tabPageDoktorEkle.TabIndex = 1;
            tabPageDoktorEkle.Text = "Doktor Ekle";
            tabPageDoktorEkle.UseVisualStyleBackColor = true;
            // 
            // textBoxDoktorUzmanlik
            // 
            textBoxDoktorUzmanlik.Location = new Point(132, 68);
            textBoxDoktorUzmanlik.Name = "textBoxDoktorUzmanlik";
            textBoxDoktorUzmanlik.Size = new Size(413, 23);
            textBoxDoktorUzmanlik.TabIndex = 16;
            // 
            // textBoxDoktorAdSoyad
            // 
            textBoxDoktorAdSoyad.Location = new Point(132, 18);
            textBoxDoktorAdSoyad.Name = "textBoxDoktorAdSoyad";
            textBoxDoktorAdSoyad.Size = new Size(413, 23);
            textBoxDoktorAdSoyad.TabIndex = 14;
            // 
            // buttonDoktorEkle
            // 
            buttonDoktorEkle.Location = new Point(132, 124);
            buttonDoktorEkle.Name = "buttonDoktorEkle";
            buttonDoktorEkle.Size = new Size(150, 40);
            buttonDoktorEkle.TabIndex = 13;
            buttonDoktorEkle.Text = "Ekle";
            buttonDoktorEkle.UseVisualStyleBackColor = true;
            buttonDoktorEkle.Click += buttonDoktorEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 79);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "Uzmanlık";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 25);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 9;
            label8.Text = "Ad soyad";
            // 
            // tabPageDoktorSil
            // 
            tabPageDoktorSil.Controls.Add(comboBoxKayitliDoktorlarSil);
            tabPageDoktorSil.Controls.Add(buttonDoktorSil);
            tabPageDoktorSil.Controls.Add(label19);
            tabPageDoktorSil.Location = new Point(4, 24);
            tabPageDoktorSil.Name = "tabPageDoktorSil";
            tabPageDoktorSil.Size = new Size(911, 426);
            tabPageDoktorSil.TabIndex = 5;
            tabPageDoktorSil.Text = "Doktor Sil";
            tabPageDoktorSil.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliDoktorlarSil
            // 
            comboBoxKayitliDoktorlarSil.FormattingEnabled = true;
            comboBoxKayitliDoktorlarSil.Location = new Point(132, 22);
            comboBoxKayitliDoktorlarSil.Name = "comboBoxKayitliDoktorlarSil";
            comboBoxKayitliDoktorlarSil.Size = new Size(413, 23);
            comboBoxKayitliDoktorlarSil.TabIndex = 27;
            // 
            // buttonDoktorSil
            // 
            buttonDoktorSil.Location = new Point(132, 68);
            buttonDoktorSil.Name = "buttonDoktorSil";
            buttonDoktorSil.Size = new Size(150, 40);
            buttonDoktorSil.TabIndex = 24;
            buttonDoktorSil.Text = "Doktor Sil";
            buttonDoktorSil.UseVisualStyleBackColor = true;
            buttonDoktorSil.Click += buttonDoktorSil_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(16, 30);
            label19.Name = "label19";
            label19.Size = new Size(91, 15);
            label19.TabIndex = 20;
            label19.Text = "Kayıtlı Doktorlar";
            // 
            // tabPageDoktorListele
            // 
            tabPageDoktorListele.Controls.Add(listBoxKayitliDoktorListesi);
            tabPageDoktorListele.Controls.Add(label7);
            tabPageDoktorListele.Location = new Point(4, 24);
            tabPageDoktorListele.Name = "tabPageDoktorListele";
            tabPageDoktorListele.Size = new Size(911, 426);
            tabPageDoktorListele.TabIndex = 6;
            tabPageDoktorListele.Text = "Doktor Listele";
            tabPageDoktorListele.UseVisualStyleBackColor = true;
            // 
            // listBoxKayitliDoktorListesi
            // 
            listBoxKayitliDoktorListesi.FormattingEnabled = true;
            listBoxKayitliDoktorListesi.ItemHeight = 15;
            listBoxKayitliDoktorListesi.Location = new Point(20, 42);
            listBoxKayitliDoktorListesi.Name = "listBoxKayitliDoktorListesi";
            listBoxKayitliDoktorListesi.Size = new Size(870, 364);
            listBoxKayitliDoktorListesi.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 20);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 2;
            label7.Text = "Kayıtlı Doktor Listesi";
            // 
            // tabPageRandevuAl
            // 
            tabPageRandevuAl.Controls.Add(dateTimePickerRandevuTarih);
            tabPageRandevuAl.Controls.Add(comboBoxKayitliHastalarRandevu);
            tabPageRandevuAl.Controls.Add(comboBoxKayitliDoktorlarRandevu);
            tabPageRandevuAl.Controls.Add(buttonRandevuAl);
            tabPageRandevuAl.Controls.Add(label9);
            tabPageRandevuAl.Controls.Add(label11);
            tabPageRandevuAl.Controls.Add(label12);
            tabPageRandevuAl.Location = new Point(4, 24);
            tabPageRandevuAl.Name = "tabPageRandevuAl";
            tabPageRandevuAl.Size = new Size(911, 426);
            tabPageRandevuAl.TabIndex = 2;
            tabPageRandevuAl.Text = "Randevu Al";
            tabPageRandevuAl.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerRandevuTarih
            // 
            dateTimePickerRandevuTarih.Location = new Point(136, 97);
            dateTimePickerRandevuTarih.Name = "dateTimePickerRandevuTarih";
            dateTimePickerRandevuTarih.Size = new Size(413, 23);
            dateTimePickerRandevuTarih.TabIndex = 20;
            // 
            // comboBoxKayitliHastalarRandevu
            // 
            comboBoxKayitliHastalarRandevu.FormattingEnabled = true;
            comboBoxKayitliHastalarRandevu.Location = new Point(136, 16);
            comboBoxKayitliHastalarRandevu.Name = "comboBoxKayitliHastalarRandevu";
            comboBoxKayitliHastalarRandevu.Size = new Size(413, 23);
            comboBoxKayitliHastalarRandevu.TabIndex = 19;
            // 
            // comboBoxKayitliDoktorlarRandevu
            // 
            comboBoxKayitliDoktorlarRandevu.FormattingEnabled = true;
            comboBoxKayitliDoktorlarRandevu.Location = new Point(136, 55);
            comboBoxKayitliDoktorlarRandevu.Name = "comboBoxKayitliDoktorlarRandevu";
            comboBoxKayitliDoktorlarRandevu.Size = new Size(413, 23);
            comboBoxKayitliDoktorlarRandevu.TabIndex = 18;
            // 
            // buttonRandevuAl
            // 
            buttonRandevuAl.Location = new Point(136, 160);
            buttonRandevuAl.Name = "buttonRandevuAl";
            buttonRandevuAl.Size = new Size(150, 40);
            buttonRandevuAl.TabIndex = 13;
            buttonRandevuAl.Text = "Randevu Al";
            buttonRandevuAl.UseVisualStyleBackColor = true;
            buttonRandevuAl.Click += buttonRandevuAl_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 103);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 12;
            label9.Text = "Randevu Tarihi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 24);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 10;
            label11.Text = "Kayıtlı Hastalar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 63);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 9;
            label12.Text = "Kayıtlı Doktorlar";
            // 
            // tabPageRandevuIptalEt
            // 
            tabPageRandevuIptalEt.Controls.Add(comboBoxKayitliRandevular);
            tabPageRandevuIptalEt.Controls.Add(buttonRandevuIptalEt);
            tabPageRandevuIptalEt.Controls.Add(label23);
            tabPageRandevuIptalEt.Location = new Point(4, 24);
            tabPageRandevuIptalEt.Name = "tabPageRandevuIptalEt";
            tabPageRandevuIptalEt.Size = new Size(911, 426);
            tabPageRandevuIptalEt.TabIndex = 7;
            tabPageRandevuIptalEt.Text = "Randevu İptal Et";
            tabPageRandevuIptalEt.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliRandevular
            // 
            comboBoxKayitliRandevular.FormattingEnabled = true;
            comboBoxKayitliRandevular.Location = new Point(132, 22);
            comboBoxKayitliRandevular.Name = "comboBoxKayitliRandevular";
            comboBoxKayitliRandevular.Size = new Size(413, 23);
            comboBoxKayitliRandevular.TabIndex = 27;
            // 
            // buttonRandevuIptalEt
            // 
            buttonRandevuIptalEt.Location = new Point(132, 68);
            buttonRandevuIptalEt.Name = "buttonRandevuIptalEt";
            buttonRandevuIptalEt.Size = new Size(150, 40);
            buttonRandevuIptalEt.TabIndex = 24;
            buttonRandevuIptalEt.Text = "Randevu İptal Et";
            buttonRandevuIptalEt.UseVisualStyleBackColor = true;
            buttonRandevuIptalEt.Click += buttonRandevuIptalEt_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(16, 30);
            label23.Name = "label23";
            label23.Size = new Size(101, 15);
            label23.TabIndex = 20;
            label23.Text = "Kayıtlı Randevular";
            // 
            // tabPageRandevuListele
            // 
            tabPageRandevuListele.Controls.Add(listBoxRandevuListesi);
            tabPageRandevuListele.Controls.Add(label18);
            tabPageRandevuListele.Location = new Point(4, 24);
            tabPageRandevuListele.Name = "tabPageRandevuListele";
            tabPageRandevuListele.Size = new Size(911, 426);
            tabPageRandevuListele.TabIndex = 8;
            tabPageRandevuListele.Text = "Randevu Listele";
            tabPageRandevuListele.UseVisualStyleBackColor = true;
            // 
            // listBoxRandevuListesi
            // 
            listBoxRandevuListesi.FormattingEnabled = true;
            listBoxRandevuListesi.ItemHeight = 15;
            listBoxRandevuListesi.Location = new Point(20, 42);
            listBoxRandevuListesi.Name = "listBoxRandevuListesi";
            listBoxRandevuListesi.Size = new Size(870, 364);
            listBoxRandevuListesi.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 20);
            label18.Name = "label18";
            label18.Size = new Size(88, 15);
            label18.TabIndex = 2;
            label18.Text = "Randevu Listesi";
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(12, 440);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(194, 40);
            btnCikis.TabIndex = 16;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnHastaListele
            // 
            btnHastaListele.Location = new Point(12, 118);
            btnHastaListele.Name = "btnHastaListele";
            btnHastaListele.Size = new Size(194, 40);
            btnHastaListele.TabIndex = 15;
            btnHastaListele.Text = "Hasta Listele";
            btnHastaListele.UseVisualStyleBackColor = true;
            btnHastaListele.Click += btnHastaListele_Click;
            // 
            // btnHastaSil
            // 
            btnHastaSil.Location = new Point(12, 72);
            btnHastaSil.Name = "btnHastaSil";
            btnHastaSil.Size = new Size(194, 40);
            btnHastaSil.TabIndex = 14;
            btnHastaSil.Text = "Hasta Sil";
            btnHastaSil.UseVisualStyleBackColor = true;
            btnHastaSil.Click += btnHastaSil_Click;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.Location = new Point(12, 302);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(194, 40);
            btnRandevuAl.TabIndex = 13;
            btnRandevuAl.Text = "Randevu Al";
            btnRandevuAl.UseVisualStyleBackColor = true;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.Location = new Point(12, 164);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(194, 40);
            btnDoktorEkle.TabIndex = 12;
            btnDoktorEkle.Text = "Doktor Ekle";
            btnDoktorEkle.UseVisualStyleBackColor = true;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.Location = new Point(12, 26);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(194, 40);
            btnHastaEkle.TabIndex = 11;
            btnHastaEkle.Text = "Hasta Ekle";
            btnHastaEkle.UseVisualStyleBackColor = true;
            btnHastaEkle.Click += btnHastaEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 508);
            Controls.Add(btnRandevuListele);
            Controls.Add(btnRandevuIptalEt);
            Controls.Add(btnDoktorListele);
            Controls.Add(btnDoktorSil);
            Controls.Add(tabControl1);
            Controls.Add(btnCikis);
            Controls.Add(btnHastaListele);
            Controls.Add(btnHastaSil);
            Controls.Add(btnRandevuAl);
            Controls.Add(btnDoktorEkle);
            Controls.Add(btnHastaEkle);
            Name = "Form1";
            Text = "Hastane Randevu Sistemi";
            tabControl1.ResumeLayout(false);
            tabPageHastaEkle.ResumeLayout(false);
            tabPageHastaEkle.PerformLayout();
            tabPageHastaSil.ResumeLayout(false);
            tabPageHastaSil.PerformLayout();
            tabPageHastaListele.ResumeLayout(false);
            tabPageHastaListele.PerformLayout();
            tabPageDoktorEkle.ResumeLayout(false);
            tabPageDoktorEkle.PerformLayout();
            tabPageDoktorSil.ResumeLayout(false);
            tabPageDoktorSil.PerformLayout();
            tabPageDoktorListele.ResumeLayout(false);
            tabPageDoktorListele.PerformLayout();
            tabPageRandevuAl.ResumeLayout(false);
            tabPageRandevuAl.PerformLayout();
            tabPageRandevuIptalEt.ResumeLayout(false);
            tabPageRandevuIptalEt.PerformLayout();
            tabPageRandevuListele.ResumeLayout(false);
            tabPageRandevuListele.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRandevuListele;
        private Button btnRandevuIptalEt;
        private Button btnDoktorListele;
        private Button btnDoktorSil;
        private TabControl tabControl1;
        private TabPage tabPageHastaEkle;
        private TextBox textBoxHastaTCKimlikNo;
        private TextBox textBoxHastaAdSoyad;
        private Button buttonHastaEkle;
        private TextBox textBoxEtkinlikUcreti;
        private Label label5;
        private TextBox textBoxEtkinlikKapasitesi;
        private TextBox textBoxEtkinlikYeri;
        private DateTimePicker dateTimePickerEtkinlikTarihi;
        private TextBox textBoxEtkinlikAdi;
        private Button buttonEtkinlikOlustur;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPageHastaSil;
        private TabPage tabPageHastaListele;
        private TabPage tabPageDoktorEkle;
        private TextBox textBoxDoktorUzmanlik;
        private TextBox textBoxDoktorAdSoyad;
        private Button buttonDoktorEkle;
        private Label label6;
        private Label label8;
        private TabPage tabPageDoktorSil;
        private ComboBox comboBoxKayitliDoktorlarSil;
        private ComboBox comboBoxKayitliKatilimcilarSil;
        private Button buttonDoktorSil;
        private Label label19;
        private TabPage tabPageDoktorListele;
        private ListBox listBoxKayitliDoktorListesi;
        private Label label7;
        private TabPage tabPageRandevuAl;
        private ComboBox comboBoxKayitliHastalarRandevu;
        private ComboBox comboBoxKayitliDoktorlarRandevu;
        private Button buttonRandevuAl;
        private Label label9;
        private Label label11;
        private Label label12;
        private TabPage tabPageRandevuIptalEt;
        private ComboBox comboBoxKayitliRandevular;
        private Button buttonRandevuIptalEt;
        private Label label23;
        private TabPage tabPageRandevuListele;
        private ListBox listBoxRandevuListesi;
        private Label label18;
        private Button btnCikis;
        private Button btnHastaListele;
        private Button btnHastaSil;
        private Button btnRandevuAl;
        private Button btnDoktorEkle;
        private Button btnHastaEkle;
        private TextBox textBoxEtkinlikUygunlukKontrolId;
        private Button buttonHastaSil;
        private Label label17;
        private ListBox listBoxKayitliHastalarListesi;
        private Label label13;
        private ComboBox comboBoxKayitliHastalar;
        private DateTimePicker dateTimePickerRandevuTarih;
    }
}
