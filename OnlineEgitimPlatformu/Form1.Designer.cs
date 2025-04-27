namespace OnlineEgitimPlatformu
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
            btnKursListele = new Button();
            btnKursSil = new Button();
            btnEgitmenListele = new Button();
            btnEgitmenSil = new Button();
            tabControl1 = new TabControl();
            tabPageOgrenciEkle = new TabPage();
            textBoxOgrenciEPostaAdresi = new TextBox();
            textBoxOgrenciAdSoyad = new TextBox();
            buttonOgrenciEkle = new Button();
            label3 = new Label();
            label1 = new Label();
            tabPageOgrenciSil = new TabPage();
            comboBoxKayitliOgrenciler = new ComboBox();
            buttonOgrenciSil = new Button();
            label17 = new Label();
            tabPageOgrenciListele = new TabPage();
            listBoxKayitliOgrencilerListesi = new ListBox();
            label13 = new Label();
            tabPageEgitmenEkle = new TabPage();
            textBoxEgitmenUzmanlik = new TextBox();
            textBoxEgitmenAdSoyad = new TextBox();
            buttonEgitmenEkle = new Button();
            label6 = new Label();
            label8 = new Label();
            tabPageEgitmenSil = new TabPage();
            comboBoxKayitliEgitmenlerSil = new ComboBox();
            buttonEgitmenSil = new Button();
            label19 = new Label();
            tabPageEgitmenListele = new TabPage();
            listBoxKayitliEgitmenlerListesi = new ListBox();
            label7 = new Label();
            tabPageKursEkle = new TabPage();
            comboBoxKursEgitmenlerListesi = new ComboBox();
            textBoxKursIcerik = new TextBox();
            label14 = new Label();
            textBoxKursAd = new TextBox();
            buttonKursEkle = new Button();
            label5 = new Label();
            label10 = new Label();
            tabPageKursSil = new TabPage();
            comboBoxKayitliKurslarSil = new ComboBox();
            buttonKursSil = new Button();
            label23 = new Label();
            tabPageKursListele = new TabPage();
            listBoxKayitliKurslarListesi = new ListBox();
            label18 = new Label();
            tabPageKursKaydiYap = new TabPage();
            comboBoxKayitliOgrencilerKayit = new ComboBox();
            comboBoxKayitliKurslarKayit = new ComboBox();
            comboBoxKayitliEgitmenlerKayit = new ComboBox();
            buttonKursKaydiYap = new Button();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabPageKursKaydiSil = new TabPage();
            comboBoxKayitliKursKayitlariSil = new ComboBox();
            buttonKursKaydiSil = new Button();
            label2 = new Label();
            tabPageKursKayitlariListele = new TabPage();
            listBoxKursKayitlariListesi = new ListBox();
            label4 = new Label();
            btnCikis = new Button();
            btnOgrenciListele = new Button();
            btnOgrenciSil = new Button();
            btnKursEkle = new Button();
            btnEgitmenEkle = new Button();
            btnOgrenciEkle = new Button();
            btnKursaKaydet = new Button();
            btnKursKaydiSil = new Button();
            btnKursKayitlariListele = new Button();
            tabControl1.SuspendLayout();
            tabPageOgrenciEkle.SuspendLayout();
            tabPageOgrenciSil.SuspendLayout();
            tabPageOgrenciListele.SuspendLayout();
            tabPageEgitmenEkle.SuspendLayout();
            tabPageEgitmenSil.SuspendLayout();
            tabPageEgitmenListele.SuspendLayout();
            tabPageKursEkle.SuspendLayout();
            tabPageKursSil.SuspendLayout();
            tabPageKursListele.SuspendLayout();
            tabPageKursKaydiYap.SuspendLayout();
            tabPageKursKaydiSil.SuspendLayout();
            tabPageKursKayitlariListele.SuspendLayout();
            SuspendLayout();
            // 
            // btnKursListele
            // 
            btnKursListele.Location = new Point(17, 397);
            btnKursListele.Name = "btnKursListele";
            btnKursListele.Size = new Size(194, 40);
            btnKursListele.TabIndex = 32;
            btnKursListele.Text = "Kurs Listele";
            btnKursListele.UseVisualStyleBackColor = true;
            btnKursListele.Click += btnKursListele_Click;
            // 
            // btnKursSil
            // 
            btnKursSil.Location = new Point(17, 351);
            btnKursSil.Name = "btnKursSil";
            btnKursSil.Size = new Size(194, 40);
            btnKursSil.TabIndex = 31;
            btnKursSil.Text = "Kurs Sil";
            btnKursSil.UseVisualStyleBackColor = true;
            btnKursSil.Click += btnKursSil_Click;
            // 
            // btnEgitmenListele
            // 
            btnEgitmenListele.Location = new Point(17, 259);
            btnEgitmenListele.Name = "btnEgitmenListele";
            btnEgitmenListele.Size = new Size(194, 40);
            btnEgitmenListele.TabIndex = 30;
            btnEgitmenListele.Text = "Eğitmen Listele";
            btnEgitmenListele.UseVisualStyleBackColor = true;
            btnEgitmenListele.Click += btnEgitmenListele_Click;
            // 
            // btnEgitmenSil
            // 
            btnEgitmenSil.Location = new Point(17, 213);
            btnEgitmenSil.Name = "btnEgitmenSil";
            btnEgitmenSil.Size = new Size(194, 40);
            btnEgitmenSil.TabIndex = 29;
            btnEgitmenSil.Text = "Eğitmen Sil";
            btnEgitmenSil.UseVisualStyleBackColor = true;
            btnEgitmenSil.Click += btnEgitmenSil_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageOgrenciEkle);
            tabControl1.Controls.Add(tabPageOgrenciSil);
            tabControl1.Controls.Add(tabPageOgrenciListele);
            tabControl1.Controls.Add(tabPageEgitmenEkle);
            tabControl1.Controls.Add(tabPageEgitmenSil);
            tabControl1.Controls.Add(tabPageEgitmenListele);
            tabControl1.Controls.Add(tabPageKursEkle);
            tabControl1.Controls.Add(tabPageKursSil);
            tabControl1.Controls.Add(tabPageKursListele);
            tabControl1.Controls.Add(tabPageKursKaydiYap);
            tabControl1.Controls.Add(tabPageKursKaydiSil);
            tabControl1.Controls.Add(tabPageKursKayitlariListele);
            tabControl1.Location = new Point(238, 29);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(721, 591);
            tabControl1.TabIndex = 28;
            // 
            // tabPageOgrenciEkle
            // 
            tabPageOgrenciEkle.Controls.Add(textBoxOgrenciEPostaAdresi);
            tabPageOgrenciEkle.Controls.Add(textBoxOgrenciAdSoyad);
            tabPageOgrenciEkle.Controls.Add(buttonOgrenciEkle);
            tabPageOgrenciEkle.Controls.Add(label3);
            tabPageOgrenciEkle.Controls.Add(label1);
            tabPageOgrenciEkle.Location = new Point(4, 24);
            tabPageOgrenciEkle.Name = "tabPageOgrenciEkle";
            tabPageOgrenciEkle.Padding = new Padding(3);
            tabPageOgrenciEkle.Size = new Size(713, 563);
            tabPageOgrenciEkle.TabIndex = 0;
            tabPageOgrenciEkle.Text = "Öğrenci Ekle";
            tabPageOgrenciEkle.UseVisualStyleBackColor = true;
            // 
            // textBoxOgrenciEPostaAdresi
            // 
            textBoxOgrenciEPostaAdresi.Location = new Point(136, 58);
            textBoxOgrenciEPostaAdresi.Name = "textBoxOgrenciEPostaAdresi";
            textBoxOgrenciEPostaAdresi.Size = new Size(413, 23);
            textBoxOgrenciEPostaAdresi.TabIndex = 7;
            // 
            // textBoxOgrenciAdSoyad
            // 
            textBoxOgrenciAdSoyad.Location = new Point(136, 18);
            textBoxOgrenciAdSoyad.Name = "textBoxOgrenciAdSoyad";
            textBoxOgrenciAdSoyad.Size = new Size(413, 23);
            textBoxOgrenciAdSoyad.TabIndex = 5;
            // 
            // buttonOgrenciEkle
            // 
            buttonOgrenciEkle.Location = new Point(136, 114);
            buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            buttonOgrenciEkle.Size = new Size(150, 40);
            buttonOgrenciEkle.TabIndex = 4;
            buttonOgrenciEkle.Text = "Öğrenci Ekle";
            buttonOgrenciEkle.UseVisualStyleBackColor = true;
            buttonOgrenciEkle.Click += buttonOgrenciEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 72);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "E-Posta Adresi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı";
            // 
            // tabPageOgrenciSil
            // 
            tabPageOgrenciSil.Controls.Add(comboBoxKayitliOgrenciler);
            tabPageOgrenciSil.Controls.Add(buttonOgrenciSil);
            tabPageOgrenciSil.Controls.Add(label17);
            tabPageOgrenciSil.Location = new Point(4, 24);
            tabPageOgrenciSil.Name = "tabPageOgrenciSil";
            tabPageOgrenciSil.Size = new Size(965, 563);
            tabPageOgrenciSil.TabIndex = 3;
            tabPageOgrenciSil.Text = "Öğrenci Sil";
            tabPageOgrenciSil.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliOgrenciler
            // 
            comboBoxKayitliOgrenciler.FormattingEnabled = true;
            comboBoxKayitliOgrenciler.Location = new Point(126, 18);
            comboBoxKayitliOgrenciler.Name = "comboBoxKayitliOgrenciler";
            comboBoxKayitliOgrenciler.Size = new Size(446, 23);
            comboBoxKayitliOgrenciler.TabIndex = 27;
            // 
            // buttonOgrenciSil
            // 
            buttonOgrenciSil.Location = new Point(126, 68);
            buttonOgrenciSil.Name = "buttonOgrenciSil";
            buttonOgrenciSil.Size = new Size(150, 40);
            buttonOgrenciSil.TabIndex = 25;
            buttonOgrenciSil.Text = "Öğrenci Sil";
            buttonOgrenciSil.UseVisualStyleBackColor = true;
            buttonOgrenciSil.Click += buttonOgrenciSil_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 26);
            label17.Name = "label17";
            label17.Size = new Size(97, 15);
            label17.TabIndex = 24;
            label17.Text = "Kayıtlı Öğrenciler";
            // 
            // tabPageOgrenciListele
            // 
            tabPageOgrenciListele.Controls.Add(listBoxKayitliOgrencilerListesi);
            tabPageOgrenciListele.Controls.Add(label13);
            tabPageOgrenciListele.Location = new Point(4, 24);
            tabPageOgrenciListele.Name = "tabPageOgrenciListele";
            tabPageOgrenciListele.Size = new Size(713, 563);
            tabPageOgrenciListele.TabIndex = 4;
            tabPageOgrenciListele.Text = "Öğrenci Listele";
            tabPageOgrenciListele.UseVisualStyleBackColor = true;
            // 
            // listBoxKayitliOgrencilerListesi
            // 
            listBoxKayitliOgrencilerListesi.FormattingEnabled = true;
            listBoxKayitliOgrencilerListesi.ItemHeight = 15;
            listBoxKayitliOgrencilerListesi.Location = new Point(15, 39);
            listBoxKayitliOgrencilerListesi.Name = "listBoxKayitliOgrencilerListesi";
            listBoxKayitliOgrencilerListesi.Size = new Size(681, 364);
            listBoxKayitliOgrencilerListesi.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 17);
            label13.Name = "label13";
            label13.Size = new Size(132, 15);
            label13.TabIndex = 24;
            label13.Text = "Kayıtlı Öğrenciler Listesi";
            // 
            // tabPageEgitmenEkle
            // 
            tabPageEgitmenEkle.Controls.Add(textBoxEgitmenUzmanlik);
            tabPageEgitmenEkle.Controls.Add(textBoxEgitmenAdSoyad);
            tabPageEgitmenEkle.Controls.Add(buttonEgitmenEkle);
            tabPageEgitmenEkle.Controls.Add(label6);
            tabPageEgitmenEkle.Controls.Add(label8);
            tabPageEgitmenEkle.Location = new Point(4, 24);
            tabPageEgitmenEkle.Name = "tabPageEgitmenEkle";
            tabPageEgitmenEkle.Padding = new Padding(3);
            tabPageEgitmenEkle.Size = new Size(965, 563);
            tabPageEgitmenEkle.TabIndex = 1;
            tabPageEgitmenEkle.Text = "Eğitmen Ekle";
            tabPageEgitmenEkle.UseVisualStyleBackColor = true;
            // 
            // textBoxEgitmenUzmanlik
            // 
            textBoxEgitmenUzmanlik.Location = new Point(132, 68);
            textBoxEgitmenUzmanlik.Name = "textBoxEgitmenUzmanlik";
            textBoxEgitmenUzmanlik.Size = new Size(413, 23);
            textBoxEgitmenUzmanlik.TabIndex = 16;
            // 
            // textBoxEgitmenAdSoyad
            // 
            textBoxEgitmenAdSoyad.Location = new Point(132, 18);
            textBoxEgitmenAdSoyad.Name = "textBoxEgitmenAdSoyad";
            textBoxEgitmenAdSoyad.Size = new Size(413, 23);
            textBoxEgitmenAdSoyad.TabIndex = 14;
            // 
            // buttonEgitmenEkle
            // 
            buttonEgitmenEkle.Location = new Point(132, 124);
            buttonEgitmenEkle.Name = "buttonEgitmenEkle";
            buttonEgitmenEkle.Size = new Size(150, 40);
            buttonEgitmenEkle.TabIndex = 13;
            buttonEgitmenEkle.Text = "Eğitmen Ekle";
            buttonEgitmenEkle.UseVisualStyleBackColor = true;
            buttonEgitmenEkle.Click += buttonEgitmenEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 82);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "Uzmanlık";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 28);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 9;
            label8.Text = "Ad Soyad";
            // 
            // tabPageEgitmenSil
            // 
            tabPageEgitmenSil.Controls.Add(comboBoxKayitliEgitmenlerSil);
            tabPageEgitmenSil.Controls.Add(buttonEgitmenSil);
            tabPageEgitmenSil.Controls.Add(label19);
            tabPageEgitmenSil.Location = new Point(4, 24);
            tabPageEgitmenSil.Name = "tabPageEgitmenSil";
            tabPageEgitmenSil.Size = new Size(965, 563);
            tabPageEgitmenSil.TabIndex = 5;
            tabPageEgitmenSil.Text = "Eğitmen Sil";
            tabPageEgitmenSil.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliEgitmenlerSil
            // 
            comboBoxKayitliEgitmenlerSil.FormattingEnabled = true;
            comboBoxKayitliEgitmenlerSil.Location = new Point(132, 22);
            comboBoxKayitliEgitmenlerSil.Name = "comboBoxKayitliEgitmenlerSil";
            comboBoxKayitliEgitmenlerSil.Size = new Size(413, 23);
            comboBoxKayitliEgitmenlerSil.TabIndex = 27;
            // 
            // buttonEgitmenSil
            // 
            buttonEgitmenSil.Location = new Point(132, 68);
            buttonEgitmenSil.Name = "buttonEgitmenSil";
            buttonEgitmenSil.Size = new Size(150, 40);
            buttonEgitmenSil.TabIndex = 24;
            buttonEgitmenSil.Text = "Eğitmen Sil";
            buttonEgitmenSil.UseVisualStyleBackColor = true;
            buttonEgitmenSil.Click += buttonEgitmenSil_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(16, 30);
            label19.Name = "label19";
            label19.Size = new Size(99, 15);
            label19.TabIndex = 20;
            label19.Text = "Kayıtlı Eğitmenler";
            // 
            // tabPageEgitmenListele
            // 
            tabPageEgitmenListele.Controls.Add(listBoxKayitliEgitmenlerListesi);
            tabPageEgitmenListele.Controls.Add(label7);
            tabPageEgitmenListele.Location = new Point(4, 24);
            tabPageEgitmenListele.Name = "tabPageEgitmenListele";
            tabPageEgitmenListele.Size = new Size(713, 563);
            tabPageEgitmenListele.TabIndex = 6;
            tabPageEgitmenListele.Text = "Eğitmen Listele";
            tabPageEgitmenListele.UseVisualStyleBackColor = true;
            // 
            // listBoxKayitliEgitmenlerListesi
            // 
            listBoxKayitliEgitmenlerListesi.FormattingEnabled = true;
            listBoxKayitliEgitmenlerListesi.ItemHeight = 15;
            listBoxKayitliEgitmenlerListesi.Location = new Point(20, 42);
            listBoxKayitliEgitmenlerListesi.Name = "listBoxKayitliEgitmenlerListesi";
            listBoxKayitliEgitmenlerListesi.Size = new Size(675, 364);
            listBoxKayitliEgitmenlerListesi.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 20);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 2;
            label7.Text = "Kayıtlı Eğitmen Listesi";
            // 
            // tabPageKursEkle
            // 
            tabPageKursEkle.Controls.Add(comboBoxKursEgitmenlerListesi);
            tabPageKursEkle.Controls.Add(textBoxKursIcerik);
            tabPageKursEkle.Controls.Add(label14);
            tabPageKursEkle.Controls.Add(textBoxKursAd);
            tabPageKursEkle.Controls.Add(buttonKursEkle);
            tabPageKursEkle.Controls.Add(label5);
            tabPageKursEkle.Controls.Add(label10);
            tabPageKursEkle.Location = new Point(4, 24);
            tabPageKursEkle.Name = "tabPageKursEkle";
            tabPageKursEkle.Size = new Size(965, 563);
            tabPageKursEkle.TabIndex = 2;
            tabPageKursEkle.Text = "Kurs Ekle";
            tabPageKursEkle.UseVisualStyleBackColor = true;
            // 
            // comboBoxKursEgitmenlerListesi
            // 
            comboBoxKursEgitmenlerListesi.FormattingEnabled = true;
            comboBoxKursEgitmenlerListesi.Location = new Point(139, 78);
            comboBoxKursEgitmenlerListesi.Name = "comboBoxKursEgitmenlerListesi";
            comboBoxKursEgitmenlerListesi.Size = new Size(413, 23);
            comboBoxKursEgitmenlerListesi.TabIndex = 28;
            // 
            // textBoxKursIcerik
            // 
            textBoxKursIcerik.Location = new Point(139, 124);
            textBoxKursIcerik.Name = "textBoxKursIcerik";
            textBoxKursIcerik.Size = new Size(413, 23);
            textBoxKursIcerik.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 132);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 22;
            label14.Text = "İçerik";
            // 
            // textBoxKursAd
            // 
            textBoxKursAd.Location = new Point(139, 22);
            textBoxKursAd.Name = "textBoxKursAd";
            textBoxKursAd.Size = new Size(413, 23);
            textBoxKursAd.TabIndex = 20;
            // 
            // buttonKursEkle
            // 
            buttonKursEkle.Location = new Point(139, 180);
            buttonKursEkle.Name = "buttonKursEkle";
            buttonKursEkle.Size = new Size(150, 40);
            buttonKursEkle.TabIndex = 19;
            buttonKursEkle.Text = "Kurs Ekle";
            buttonKursEkle.UseVisualStyleBackColor = true;
            buttonKursEkle.Click += buttonKursEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 80);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 18;
            label5.Text = "Eğitmen";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 32);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 17;
            label10.Text = "Ad";
            // 
            // tabPageKursSil
            // 
            tabPageKursSil.Controls.Add(comboBoxKayitliKurslarSil);
            tabPageKursSil.Controls.Add(buttonKursSil);
            tabPageKursSil.Controls.Add(label23);
            tabPageKursSil.Location = new Point(4, 24);
            tabPageKursSil.Name = "tabPageKursSil";
            tabPageKursSil.Size = new Size(965, 563);
            tabPageKursSil.TabIndex = 7;
            tabPageKursSil.Text = "Kurs Sil";
            tabPageKursSil.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliKurslarSil
            // 
            comboBoxKayitliKurslarSil.FormattingEnabled = true;
            comboBoxKayitliKurslarSil.Location = new Point(132, 22);
            comboBoxKayitliKurslarSil.Name = "comboBoxKayitliKurslarSil";
            comboBoxKayitliKurslarSil.Size = new Size(413, 23);
            comboBoxKayitliKurslarSil.TabIndex = 27;
            // 
            // buttonKursSil
            // 
            buttonKursSil.Location = new Point(132, 68);
            buttonKursSil.Name = "buttonKursSil";
            buttonKursSil.Size = new Size(150, 40);
            buttonKursSil.TabIndex = 24;
            buttonKursSil.Text = "Kurs Sil";
            buttonKursSil.UseVisualStyleBackColor = true;
            buttonKursSil.Click += buttonKursSil_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(16, 30);
            label23.Name = "label23";
            label23.Size = new Size(78, 15);
            label23.TabIndex = 20;
            label23.Text = "Kayıtlı Kurslar";
            // 
            // tabPageKursListele
            // 
            tabPageKursListele.Controls.Add(listBoxKayitliKurslarListesi);
            tabPageKursListele.Controls.Add(label18);
            tabPageKursListele.Location = new Point(4, 24);
            tabPageKursListele.Name = "tabPageKursListele";
            tabPageKursListele.Size = new Size(713, 563);
            tabPageKursListele.TabIndex = 8;
            tabPageKursListele.Text = "Kurs Listele";
            tabPageKursListele.UseVisualStyleBackColor = true;
            // 
            // listBoxKayitliKurslarListesi
            // 
            listBoxKayitliKurslarListesi.FormattingEnabled = true;
            listBoxKayitliKurslarListesi.ItemHeight = 15;
            listBoxKayitliKurslarListesi.Location = new Point(20, 42);
            listBoxKayitliKurslarListesi.Name = "listBoxKayitliKurslarListesi";
            listBoxKayitliKurslarListesi.Size = new Size(673, 364);
            listBoxKayitliKurslarListesi.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 20);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 2;
            label18.Text = "Kurs Listesi";
            // 
            // tabPageKursKaydiYap
            // 
            tabPageKursKaydiYap.Controls.Add(comboBoxKayitliOgrencilerKayit);
            tabPageKursKaydiYap.Controls.Add(comboBoxKayitliKurslarKayit);
            tabPageKursKaydiYap.Controls.Add(comboBoxKayitliEgitmenlerKayit);
            tabPageKursKaydiYap.Controls.Add(buttonKursKaydiYap);
            tabPageKursKaydiYap.Controls.Add(label9);
            tabPageKursKaydiYap.Controls.Add(label11);
            tabPageKursKaydiYap.Controls.Add(label12);
            tabPageKursKaydiYap.Location = new Point(4, 24);
            tabPageKursKaydiYap.Name = "tabPageKursKaydiYap";
            tabPageKursKaydiYap.Size = new Size(965, 563);
            tabPageKursKaydiYap.TabIndex = 9;
            tabPageKursKaydiYap.Text = "Kurs Kaydı Yap";
            tabPageKursKaydiYap.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliOgrencilerKayit
            // 
            comboBoxKayitliOgrencilerKayit.FormattingEnabled = true;
            comboBoxKayitliOgrencilerKayit.Location = new Point(147, 118);
            comboBoxKayitliOgrencilerKayit.Name = "comboBoxKayitliOgrencilerKayit";
            comboBoxKayitliOgrencilerKayit.Size = new Size(413, 23);
            comboBoxKayitliOgrencilerKayit.TabIndex = 27;
            // 
            // comboBoxKayitliKurslarKayit
            // 
            comboBoxKayitliKurslarKayit.FormattingEnabled = true;
            comboBoxKayitliKurslarKayit.Location = new Point(147, 39);
            comboBoxKayitliKurslarKayit.Name = "comboBoxKayitliKurslarKayit";
            comboBoxKayitliKurslarKayit.Size = new Size(413, 23);
            comboBoxKayitliKurslarKayit.TabIndex = 26;
            // 
            // comboBoxKayitliEgitmenlerKayit
            // 
            comboBoxKayitliEgitmenlerKayit.FormattingEnabled = true;
            comboBoxKayitliEgitmenlerKayit.Location = new Point(147, 78);
            comboBoxKayitliEgitmenlerKayit.Name = "comboBoxKayitliEgitmenlerKayit";
            comboBoxKayitliEgitmenlerKayit.Size = new Size(413, 23);
            comboBoxKayitliEgitmenlerKayit.TabIndex = 25;
            // 
            // buttonKursKaydiYap
            // 
            buttonKursKaydiYap.Location = new Point(147, 183);
            buttonKursKaydiYap.Name = "buttonKursKaydiYap";
            buttonKursKaydiYap.Size = new Size(150, 40);
            buttonKursKaydiYap.TabIndex = 24;
            buttonKursKaydiYap.Text = "Kurs Kaydı Yap";
            buttonKursKaydiYap.UseVisualStyleBackColor = true;
            buttonKursKaydiYap.Click += buttonKursKaydiYap_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 126);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 23;
            label9.Text = "Kayıtlı Öğrenciler";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 47);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 22;
            label11.Text = "Kayıtlı Kurslar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 86);
            label12.Name = "label12";
            label12.Size = new Size(99, 15);
            label12.TabIndex = 21;
            label12.Text = "Kayıtlı Eğitmenler";
            // 
            // tabPageKursKaydiSil
            // 
            tabPageKursKaydiSil.Controls.Add(comboBoxKayitliKursKayitlariSil);
            tabPageKursKaydiSil.Controls.Add(buttonKursKaydiSil);
            tabPageKursKaydiSil.Controls.Add(label2);
            tabPageKursKaydiSil.Location = new Point(4, 24);
            tabPageKursKaydiSil.Name = "tabPageKursKaydiSil";
            tabPageKursKaydiSil.Size = new Size(965, 563);
            tabPageKursKaydiSil.TabIndex = 10;
            tabPageKursKaydiSil.Text = "Kurs Kaydı Sil";
            tabPageKursKaydiSil.UseVisualStyleBackColor = true;
            // 
            // comboBoxKayitliKursKayitlariSil
            // 
            comboBoxKayitliKursKayitlariSil.FormattingEnabled = true;
            comboBoxKayitliKursKayitlariSil.Location = new Point(143, 32);
            comboBoxKayitliKursKayitlariSil.Name = "comboBoxKayitliKursKayitlariSil";
            comboBoxKayitliKursKayitlariSil.Size = new Size(413, 23);
            comboBoxKayitliKursKayitlariSil.TabIndex = 30;
            // 
            // buttonKursKaydiSil
            // 
            buttonKursKaydiSil.Location = new Point(143, 78);
            buttonKursKaydiSil.Name = "buttonKursKaydiSil";
            buttonKursKaydiSil.Size = new Size(150, 40);
            buttonKursKaydiSil.TabIndex = 29;
            buttonKursKaydiSil.Text = "Kurs Kaydı Sil";
            buttonKursKaydiSil.UseVisualStyleBackColor = true;
            buttonKursKaydiSil.Click += buttonKursKaydiSil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 40);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 28;
            label2.Text = "Mevcut Kurs Kayıtları";
            // 
            // tabPageKursKayitlariListele
            // 
            tabPageKursKayitlariListele.Controls.Add(listBoxKursKayitlariListesi);
            tabPageKursKayitlariListele.Controls.Add(label4);
            tabPageKursKayitlariListele.Location = new Point(4, 24);
            tabPageKursKayitlariListele.Name = "tabPageKursKayitlariListele";
            tabPageKursKayitlariListele.Size = new Size(713, 563);
            tabPageKursKayitlariListele.TabIndex = 11;
            tabPageKursKayitlariListele.Text = "Kurs Kayıtları Listele";
            tabPageKursKayitlariListele.UseVisualStyleBackColor = true;
            // 
            // listBoxKursKayitlariListesi
            // 
            listBoxKursKayitlariListesi.FormattingEnabled = true;
            listBoxKursKayitlariListesi.ItemHeight = 15;
            listBoxKursKayitlariListesi.Location = new Point(30, 44);
            listBoxKursKayitlariListesi.Name = "listBoxKursKayitlariListesi";
            listBoxKursKayitlariListesi.Size = new Size(672, 514);
            listBoxKursKayitlariListesi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 22);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 4;
            label4.Text = "Kurs Kayıtları Listesi";
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(17, 581);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(194, 40);
            btnCikis.TabIndex = 27;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnOgrenciListele
            // 
            btnOgrenciListele.Location = new Point(17, 121);
            btnOgrenciListele.Name = "btnOgrenciListele";
            btnOgrenciListele.Size = new Size(194, 40);
            btnOgrenciListele.TabIndex = 26;
            btnOgrenciListele.Text = "Öğrenci Listele";
            btnOgrenciListele.UseVisualStyleBackColor = true;
            btnOgrenciListele.Click += btnOgrenciListele_Click;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.Location = new Point(17, 75);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(194, 40);
            btnOgrenciSil.TabIndex = 25;
            btnOgrenciSil.Text = "Öğrenci Sil";
            btnOgrenciSil.UseVisualStyleBackColor = true;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // btnKursEkle
            // 
            btnKursEkle.Location = new Point(17, 305);
            btnKursEkle.Name = "btnKursEkle";
            btnKursEkle.Size = new Size(194, 40);
            btnKursEkle.TabIndex = 24;
            btnKursEkle.Text = "Kurs Ekle";
            btnKursEkle.UseVisualStyleBackColor = true;
            btnKursEkle.Click += btnKursEkle_Click;
            // 
            // btnEgitmenEkle
            // 
            btnEgitmenEkle.Location = new Point(17, 167);
            btnEgitmenEkle.Name = "btnEgitmenEkle";
            btnEgitmenEkle.Size = new Size(194, 40);
            btnEgitmenEkle.TabIndex = 23;
            btnEgitmenEkle.Text = "Eğitmen Ekle";
            btnEgitmenEkle.UseVisualStyleBackColor = true;
            btnEgitmenEkle.Click += btnEgitmenEkle_Click;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(17, 29);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(194, 40);
            btnOgrenciEkle.TabIndex = 22;
            btnOgrenciEkle.Text = "Öğrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // btnKursaKaydet
            // 
            btnKursaKaydet.Location = new Point(17, 443);
            btnKursaKaydet.Name = "btnKursaKaydet";
            btnKursaKaydet.Size = new Size(194, 40);
            btnKursaKaydet.TabIndex = 33;
            btnKursaKaydet.Text = "Kursa Kaydı Yap";
            btnKursaKaydet.UseVisualStyleBackColor = true;
            btnKursaKaydet.Click += btnKursaKaydet_Click;
            // 
            // btnKursKaydiSil
            // 
            btnKursKaydiSil.Location = new Point(17, 489);
            btnKursKaydiSil.Name = "btnKursKaydiSil";
            btnKursKaydiSil.Size = new Size(194, 40);
            btnKursKaydiSil.TabIndex = 34;
            btnKursKaydiSil.Text = "Kurs Kaydi Sil";
            btnKursKaydiSil.UseVisualStyleBackColor = true;
            btnKursKaydiSil.Click += btnKursKaydiSil_Click;
            // 
            // btnKursKayitlariListele
            // 
            btnKursKayitlariListele.Location = new Point(17, 535);
            btnKursKayitlariListele.Name = "btnKursKayitlariListele";
            btnKursKayitlariListele.Size = new Size(194, 40);
            btnKursKayitlariListele.TabIndex = 35;
            btnKursKayitlariListele.Text = "Kurs Kayıtları Listele";
            btnKursKayitlariListele.UseVisualStyleBackColor = true;
            btnKursKayitlariListele.Click += btnKursKayitlariListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 632);
            Controls.Add(btnKursKayitlariListele);
            Controls.Add(btnKursKaydiSil);
            Controls.Add(btnKursaKaydet);
            Controls.Add(btnKursListele);
            Controls.Add(btnKursSil);
            Controls.Add(btnEgitmenListele);
            Controls.Add(btnEgitmenSil);
            Controls.Add(tabControl1);
            Controls.Add(btnCikis);
            Controls.Add(btnOgrenciListele);
            Controls.Add(btnOgrenciSil);
            Controls.Add(btnKursEkle);
            Controls.Add(btnEgitmenEkle);
            Controls.Add(btnOgrenciEkle);
            Name = "Form1";
            Text = "Online Eğitim Platformu";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageOgrenciEkle.ResumeLayout(false);
            tabPageOgrenciEkle.PerformLayout();
            tabPageOgrenciSil.ResumeLayout(false);
            tabPageOgrenciSil.PerformLayout();
            tabPageOgrenciListele.ResumeLayout(false);
            tabPageOgrenciListele.PerformLayout();
            tabPageEgitmenEkle.ResumeLayout(false);
            tabPageEgitmenEkle.PerformLayout();
            tabPageEgitmenSil.ResumeLayout(false);
            tabPageEgitmenSil.PerformLayout();
            tabPageEgitmenListele.ResumeLayout(false);
            tabPageEgitmenListele.PerformLayout();
            tabPageKursEkle.ResumeLayout(false);
            tabPageKursEkle.PerformLayout();
            tabPageKursSil.ResumeLayout(false);
            tabPageKursSil.PerformLayout();
            tabPageKursListele.ResumeLayout(false);
            tabPageKursListele.PerformLayout();
            tabPageKursKaydiYap.ResumeLayout(false);
            tabPageKursKaydiYap.PerformLayout();
            tabPageKursKaydiSil.ResumeLayout(false);
            tabPageKursKaydiSil.PerformLayout();
            tabPageKursKayitlariListele.ResumeLayout(false);
            tabPageKursKayitlariListele.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKursListele;
        private Button btnKursSil;
        private Button btnEgitmenListele;
        private Button btnEgitmenSil;
        private TabControl tabControl1;
        private TabPage tabPageOgrenciEkle;
        private TextBox textBoxOgrenciEPostaAdresi;
        private TextBox textBoxOgrenciAdSoyad;
        private Button buttonOgrenciEkle;
        private Label label3;
        private Label label1;
        private TabPage tabPageOgrenciSil;
        private ComboBox comboBoxKayitliOgrenciler;
        private Button buttonOgrenciSil;
        private Label label17;
        private TabPage tabPageOgrenciListele;
        private ListBox listBoxKayitliOgrencilerListesi;
        private Label label13;
        private TabPage tabPageEgitmenEkle;
        private TextBox textBoxEgitmenUzmanlik;
        private TextBox textBoxEgitmenAdSoyad;
        private Button buttonEgitmenEkle;
        private Label label6;
        private Label label8;
        private TabPage tabPageEgitmenSil;
        private ComboBox comboBoxKayitliEgitmenlerSil;
        private Button buttonEgitmenSil;
        private Label label19;
        private TabPage tabPageEgitmenListele;
        private ListBox listBoxKayitliEgitmenlerListesi;
        private Label label7;
        private TabPage tabPageKursEkle;
        private TabPage tabPageKursSil;
        private ComboBox comboBoxKayitliKurslarSil;
        private Button buttonKursSil;
        private Label label23;
        private TabPage tabPageKursListele;
        private ListBox listBoxKayitliKurslarListesi;
        private Label label18;
        private Button btnCikis;
        private Button btnOgrenciListele;
        private Button btnOgrenciSil;
        private Button btnKursEkle;
        private Button btnEgitmenEkle;
        private Button btnOgrenciEkle;
        private Button btnKursaKaydet;
        private Button btnKursKaydiSil;
        private Button btnKursKayitlariListele;
        private TabPage tabPageKursKaydiYap;
        private ComboBox comboBoxKayitliKurslarKayit;
        private TabPage tabPageKursKaydiSil;
        private TabPage tabPageKursKayitlariListele;
        private DateTimePicker dateTimePickerRandevuTarih;
        private ComboBox comboBoxKayitliOgrencilerKursKaydi;
        private ComboBox comboBoxKayitliEgitmenlerKayit;
        private Button buttonKursKaydiYap;
        private Label label9;
        private Label label11;
        private Label label12;
        private ComboBox comboBoxKayitliKursKayitlariSil;
        private Button buttonKursKaydiSil;
        private Label label2;
        private ListBox listBoxKursKayitlariListesi;
        private Label label4;
        private TextBox textBoxKursAd;
        private Button buttonKursEkle;
        private Label label5;
        private Label label10;
        private TextBox textBoxKursIcerik;
        private Label label14;
        private ComboBox comboBoxKursEgitmenlerListesi;
        private ComboBox comboBoxKayitliOgrencilerKayit;
    }
}
