namespace Etüt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Etutu_Olustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_Saat = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Ogretmen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Ders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Etut_ıd = new System.Windows.Forms.TextBox();
            this.lbl_Etut_Id = new System.Windows.Forms.Label();
            this.txt_Ogrenci = new System.Windows.Forms.TextBox();
            this.btn_Etut_Ver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Ders_Sil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Ders_Ad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.btn_Ogrenci_Ekle = new System.Windows.Forms.Button();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Sınıf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_Fotograf_Yukle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cmb_Ders_Ogretmen = new System.Windows.Forms.ComboBox();
            this.btn_Ogretmen_Ekle = new System.Windows.Forms.Button();
            this.txt_Ogretmen_Ad = new System.Windows.Forms.TextBox();
            this.txt_Ogretmen_Soyad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Etutu_Olustur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.msk_Saat);
            this.groupBox1.Controls.Add(this.cmb_Ogretmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.msk_Tarih);
            this.groupBox1.Controls.Add(this.cmb_Ders);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Etutu_Olustur
            // 
            this.btn_Etutu_Olustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Etutu_Olustur.Location = new System.Drawing.Point(164, 215);
            this.btn_Etutu_Olustur.Name = "btn_Etutu_Olustur";
            this.btn_Etutu_Olustur.Size = new System.Drawing.Size(196, 40);
            this.btn_Etutu_Olustur.TabIndex = 7;
            this.btn_Etutu_Olustur.Text = "Etüt Oluştur";
            this.btn_Etutu_Olustur.UseVisualStyleBackColor = false;
            this.btn_Etutu_Olustur.Click += new System.EventHandler(this.btn_Etutu_Olustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saat:";
            // 
            // msk_Saat
            // 
            this.msk_Saat.Location = new System.Drawing.Point(164, 164);
            this.msk_Saat.Mask = "90:00";
            this.msk_Saat.Name = "msk_Saat";
            this.msk_Saat.Size = new System.Drawing.Size(196, 30);
            this.msk_Saat.TabIndex = 4;
            this.msk_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_Ogretmen
            // 
            this.cmb_Ogretmen.FormattingEnabled = true;
            this.cmb_Ogretmen.Location = new System.Drawing.Point(164, 68);
            this.cmb_Ogretmen.Name = "cmb_Ogretmen";
            this.cmb_Ogretmen.Size = new System.Drawing.Size(196, 33);
            this.cmb_Ogretmen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretmen:";
            // 
            // msk_Tarih
            // 
            this.msk_Tarih.Location = new System.Drawing.Point(164, 126);
            this.msk_Tarih.Mask = "00/00/0000";
            this.msk_Tarih.Name = "msk_Tarih";
            this.msk_Tarih.Size = new System.Drawing.Size(196, 30);
            this.msk_Tarih.TabIndex = 1;
            this.msk_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_Ders
            // 
            this.cmb_Ders.FormattingEnabled = true;
            this.cmb_Ders.Location = new System.Drawing.Point(164, 29);
            this.cmb_Ders.Name = "cmb_Ders";
            this.cmb_Ders.Size = new System.Drawing.Size(196, 33);
            this.cmb_Ders.TabIndex = 1;
            this.cmb_Ders.SelectedIndexChanged += new System.EventHandler(this.cmb_Ders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_Etut_ıd);
            this.groupBox2.Controls.Add(this.lbl_Etut_Id);
            this.groupBox2.Controls.Add(this.txt_Ogrenci);
            this.groupBox2.Controls.Add(this.btn_Etut_Ver);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(430, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_Etut_ıd
            // 
            this.txt_Etut_ıd.Location = new System.Drawing.Point(113, 29);
            this.txt_Etut_ıd.Name = "txt_Etut_ıd";
            this.txt_Etut_ıd.Size = new System.Drawing.Size(212, 30);
            this.txt_Etut_ıd.TabIndex = 14;
            // 
            // lbl_Etut_Id
            // 
            this.lbl_Etut_Id.AutoSize = true;
            this.lbl_Etut_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Etut_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Etut_Id.Location = new System.Drawing.Point(18, 30);
            this.lbl_Etut_Id.Name = "lbl_Etut_Id";
            this.lbl_Etut_Id.Size = new System.Drawing.Size(89, 29);
            this.lbl_Etut_Id.TabIndex = 13;
            this.lbl_Etut_Id.Text = "Etüt ID:";
            // 
            // txt_Ogrenci
            // 
            this.txt_Ogrenci.Location = new System.Drawing.Point(113, 83);
            this.txt_Ogrenci.Name = "txt_Ogrenci";
            this.txt_Ogrenci.Size = new System.Drawing.Size(212, 30);
            this.txt_Ogrenci.TabIndex = 12;
            // 
            // btn_Etut_Ver
            // 
            this.btn_Etut_Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Etut_Ver.Location = new System.Drawing.Point(113, 137);
            this.btn_Etut_Ver.Name = "btn_Etut_Ver";
            this.btn_Etut_Ver.Size = new System.Drawing.Size(212, 49);
            this.btn_Etut_Ver.TabIndex = 7;
            this.btn_Etut_Ver.Text = "Etüt Ver";
            this.btn_Etut_Ver.UseVisualStyleBackColor = false;
            this.btn_Etut_Ver.Click += new System.EventHandler(this.btn_Etut_Ver_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(49, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 326);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btn_Ders_Sil);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txt_Ders_Ad);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(430, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 126);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btn_Ders_Sil
            // 
            this.btn_Ders_Sil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Ders_Sil.Location = new System.Drawing.Point(117, 70);
            this.btn_Ders_Sil.Name = "btn_Ders_Sil";
            this.btn_Ders_Sil.Size = new System.Drawing.Size(109, 39);
            this.btn_Ders_Sil.TabIndex = 29;
            this.btn_Ders_Sil.Text = "Ders Sil";
            this.btn_Ders_Sil.UseVisualStyleBackColor = false;
            this.btn_Ders_Sil.Click += new System.EventHandler(this.btn_Ders_Sil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(232, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 29);
            this.label13.TabIndex = 28;
            this.label13.Text = "Label13";
            this.label13.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(6, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ders Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Ders_Ad
            // 
            this.txt_Ders_Ad.Location = new System.Drawing.Point(104, 34);
            this.txt_Ders_Ad.Name = "txt_Ders_Ad";
            this.txt_Ders_Ad.Size = new System.Drawing.Size(212, 30);
            this.txt_Ders_Ad.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(2, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ders Ad:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.msk_Telefon);
            this.groupBox5.Controls.Add(this.btn_Ogrenci_Ekle);
            this.groupBox5.Controls.Add(this.txt_Mail);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txt_Sınıf);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txt_Ad);
            this.groupBox5.Controls.Add(this.txt_Soyad);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(779, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 349);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // msk_Telefon
            // 
            this.msk_Telefon.Location = new System.Drawing.Point(134, 187);
            this.msk_Telefon.Mask = "(999) 000-0000";
            this.msk_Telefon.Name = "msk_Telefon";
            this.msk_Telefon.Size = new System.Drawing.Size(212, 30);
            this.msk_Telefon.TabIndex = 27;
            // 
            // btn_Ogrenci_Ekle
            // 
            this.btn_Ogrenci_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Ogrenci_Ekle.Location = new System.Drawing.Point(134, 277);
            this.btn_Ogrenci_Ekle.Name = "btn_Ogrenci_Ekle";
            this.btn_Ogrenci_Ekle.Size = new System.Drawing.Size(212, 49);
            this.btn_Ogrenci_Ekle.TabIndex = 26;
            this.btn_Ogrenci_Ekle.Text = "Öğrenci Ekle";
            this.btn_Ogrenci_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ogrenci_Ekle.Click += new System.EventHandler(this.btn_Ogrenci_Ekle_Click);
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(134, 238);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(212, 30);
            this.txt_Mail.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(64, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mail:";
            // 
            // txt_Sınıf
            // 
            this.txt_Sınıf.Location = new System.Drawing.Point(134, 134);
            this.txt_Sınıf.Name = "txt_Sınıf";
            this.txt_Sınıf.Size = new System.Drawing.Size(212, 30);
            this.txt_Sınıf.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(64, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sınıf:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(26, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefon:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(134, 29);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(212, 30);
            this.txt_Ad.TabIndex = 17;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(134, 83);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(212, 30);
            this.txt_Soyad.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(80, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(41, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Soyad:";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.btn_Fotograf_Yukle);
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.Location = new System.Drawing.Point(1139, 60);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(377, 349);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // btn_Fotograf_Yukle
            // 
            this.btn_Fotograf_Yukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Fotograf_Yukle.Location = new System.Drawing.Point(94, 277);
            this.btn_Fotograf_Yukle.Name = "btn_Fotograf_Yukle";
            this.btn_Fotograf_Yukle.Size = new System.Drawing.Size(212, 49);
            this.btn_Fotograf_Yukle.TabIndex = 27;
            this.btn_Fotograf_Yukle.Text = "Fotoğraf Yükle";
            this.btn_Fotograf_Yukle.UseVisualStyleBackColor = false;
            this.btn_Fotograf_Yukle.Click += new System.EventHandler(this.btn_Fotograf_Yukle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 222);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.Cmb_Ders_Ogretmen);
            this.groupBox6.Controls.Add(this.btn_Ogretmen_Ekle);
            this.groupBox6.Controls.Add(this.txt_Ogretmen_Ad);
            this.groupBox6.Controls.Add(this.txt_Ogretmen_Soyad);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(1145, 415);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(377, 305);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(41, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ders";
            // 
            // Cmb_Ders_Ogretmen
            // 
            this.Cmb_Ders_Ogretmen.FormattingEnabled = true;
            this.Cmb_Ders_Ogretmen.Location = new System.Drawing.Point(134, 131);
            this.Cmb_Ders_Ogretmen.Name = "Cmb_Ders_Ogretmen";
            this.Cmb_Ders_Ogretmen.Size = new System.Drawing.Size(212, 33);
            this.Cmb_Ders_Ogretmen.TabIndex = 28;
            // 
            // btn_Ogretmen_Ekle
            // 
            this.btn_Ogretmen_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Ogretmen_Ekle.Location = new System.Drawing.Point(134, 184);
            this.btn_Ogretmen_Ekle.Name = "btn_Ogretmen_Ekle";
            this.btn_Ogretmen_Ekle.Size = new System.Drawing.Size(212, 49);
            this.btn_Ogretmen_Ekle.TabIndex = 26;
            this.btn_Ogretmen_Ekle.Text = "Öğretmen Ekle";
            this.btn_Ogretmen_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ogretmen_Ekle.Click += new System.EventHandler(this.btn_Ogretmen_Ekle_Click);
            // 
            // txt_Ogretmen_Ad
            // 
            this.txt_Ogretmen_Ad.Location = new System.Drawing.Point(134, 29);
            this.txt_Ogretmen_Ad.Name = "txt_Ogretmen_Ad";
            this.txt_Ogretmen_Ad.Size = new System.Drawing.Size(212, 30);
            this.txt_Ogretmen_Ad.TabIndex = 17;
            // 
            // txt_Ogretmen_Soyad
            // 
            this.txt_Ogretmen_Soyad.Location = new System.Drawing.Point(134, 83);
            this.txt_Ogretmen_Soyad.Name = "txt_Ogretmen_Soyad";
            this.txt_Ogretmen_Soyad.Size = new System.Drawing.Size(212, 30);
            this.txt_Ogretmen_Soyad.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(80, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 29);
            this.label15.TabIndex = 15;
            this.label15.Text = "Ad:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(41, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 29);
            this.label16.TabIndex = 14;
            this.label16.Text = "Soyad:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1529, 763);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Etutu_Olustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_Saat;
        private System.Windows.Forms.ComboBox cmb_Ogretmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_Tarih;
        private System.Windows.Forms.ComboBox cmb_Ders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Etut_Ver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Ogrenci;
        private System.Windows.Forms.TextBox txt_Etut_ıd;
        private System.Windows.Forms.Label lbl_Etut_Id;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Ders_Ad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox msk_Telefon;
        private System.Windows.Forms.Button btn_Ogrenci_Ekle;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Sınıf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_Fotograf_Yukle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cmb_Ders_Ogretmen;
        private System.Windows.Forms.Button btn_Ogretmen_Ekle;
        private System.Windows.Forms.TextBox txt_Ogretmen_Ad;
        private System.Windows.Forms.TextBox txt_Ogretmen_Soyad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Ders_Sil;
    }
}

