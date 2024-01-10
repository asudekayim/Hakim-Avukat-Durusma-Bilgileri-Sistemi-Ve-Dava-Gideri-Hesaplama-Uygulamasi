namespace uygulama
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
            btnYonetici = new Button();
            btnGiris = new Button();
            label1 = new Label();
            tbTC = new TextBox();
            label2 = new Label();
            tbSifre = new TextBox();
            label3 = new Label();
            tbGirilenKod = new TextBox();
            tbKod = new TextBox();
            label4 = new Label();
            linkKayitOlustur = new LinkLabel();
            SuspendLayout();
            // 
            // btnYonetici
            // 
            btnYonetici.BackColor = Color.Lavender;
            btnYonetici.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnYonetici.Location = new Point(12, 286);
            btnYonetici.Margin = new Padding(3, 2, 3, 2);
            btnYonetici.Name = "btnYonetici";
            btnYonetici.Size = new Size(206, 61);
            btnYonetici.TabIndex = 1;
            btnYonetici.Text = "YÖNETİCİ GİRİŞİ";
            btnYonetici.UseVisualStyleBackColor = false;
            btnYonetici.Click += btnYonetici_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Lavender;
            btnGiris.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(224, 286);
            btnGiris.Margin = new Padding(3, 2, 3, 2);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(206, 61);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 2;
            label1.Text = "TC NO Giriniz:";
            // 
            // tbTC
            // 
            tbTC.Location = new Point(182, 135);
            tbTC.Margin = new Padding(3, 2, 3, 2);
            tbTC.Name = "tbTC";
            tbTC.Size = new Size(171, 27);
            tbTC.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifre Giriniz:";
            // 
            // tbSifre
            // 
            tbSifre.Location = new Point(182, 182);
            tbSifre.Margin = new Padding(3, 2, 3, 2);
            tbSifre.Name = "tbSifre";
            tbSifre.Size = new Size(171, 27);
            tbSifre.TabIndex = 3;
            tbSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 2;
            label3.Text = "Kodu Giriniz:";
            // 
            // tbGirilenKod
            // 
            tbGirilenKod.Location = new Point(182, 231);
            tbGirilenKod.Margin = new Padding(3, 2, 3, 2);
            tbGirilenKod.Name = "tbGirilenKod";
            tbGirilenKod.Size = new Size(171, 27);
            tbGirilenKod.TabIndex = 3;
            // 
            // tbKod
            // 
            tbKod.Location = new Point(365, 231);
            tbKod.Margin = new Padding(3, 2, 3, 2);
            tbKod.Name = "tbKod";
            tbKod.Size = new Size(112, 27);
            tbKod.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 69);
            label4.Name = "label4";
            label4.Size = new Size(346, 32);
            label4.TabIndex = 4;
            label4.Text = "Giriş Sayfasına Hoşgeldiniz";
            // 
            // linkKayitOlustur
            // 
            linkKayitOlustur.AutoSize = true;
            linkKayitOlustur.BackColor = Color.Transparent;
            linkKayitOlustur.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkKayitOlustur.ForeColor = Color.Black;
            linkKayitOlustur.LinkColor = Color.White;
            linkKayitOlustur.Location = new Point(12, 368);
            linkKayitOlustur.Name = "linkKayitOlustur";
            linkKayitOlustur.Size = new Size(417, 20);
            linkKayitOlustur.TabIndex = 5;
            linkKayitOlustur.TabStop = true;
            linkKayitOlustur.Text = "Hesabınız yoksa yeni hesap oluşturmak için tıklayın.";
            linkKayitOlustur.LinkClicked += linkKayitOlustur_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3dduvarkagitlari_b4f030ed;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 713);
            Controls.Add(linkKayitOlustur);
            Controls.Add(label4);
            Controls.Add(tbKod);
            Controls.Add(tbGirilenKod);
            Controls.Add(tbSifre);
            Controls.Add(tbTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(btnYonetici);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİRİŞ EKRANI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnYonetici;
        private Button btnGiris;
        private Label label1;
        private TextBox tbTC;
        private Label label2;
        private TextBox tbSifre;
        private Label label3;
        private TextBox tbGirilenKod;
        private TextBox tbKod;
        private Label label4;
        private LinkLabel linkKayitOlustur;
    }
}
