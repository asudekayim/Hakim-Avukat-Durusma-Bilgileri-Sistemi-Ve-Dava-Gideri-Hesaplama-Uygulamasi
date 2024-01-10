namespace uygulama
{
    partial class Form5
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnKaydet = new Button();
            label5 = new Label();
            tbTCYeni = new TextBox();
            tbIsim = new TextBox();
            tbSifreYeni = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            btnCikisYap = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 126);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 4;
            label2.Text = "Şifre Giriniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 79);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 5;
            label1.Text = "TC NO Giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(16, 35);
            label3.Name = "label3";
            label3.Size = new Size(311, 25);
            label3.TabIndex = 5;
            label3.Text = "Mesleğinizle Ad Soyad Giriniz:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Lavender;
            btnKaydet.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(16, 173);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(345, 46);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Yeni Kayıt Oluştur";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(16, 246);
            label5.Name = "label5";
            label5.Size = new Size(399, 23);
            label5.TabIndex = 10;
            label5.Text = "YUKARIDA İSTENEN BİLGİLERİ EKSİKSİZ GİRİNİZ!";
            // 
            // tbTCYeni
            // 
            tbTCYeni.Location = new Point(198, 80);
            tbTCYeni.Margin = new Padding(3, 2, 3, 2);
            tbTCYeni.Name = "tbTCYeni";
            tbTCYeni.Size = new Size(171, 27);
            tbTCYeni.TabIndex = 7;
            // 
            // tbIsim
            // 
            tbIsim.Location = new Point(333, 36);
            tbIsim.Margin = new Padding(3, 2, 3, 2);
            tbIsim.Name = "tbIsim";
            tbIsim.Size = new Size(171, 27);
            tbIsim.TabIndex = 7;
            // 
            // tbSifreYeni
            // 
            tbSifreYeni.Location = new Point(198, 127);
            tbSifreYeni.Margin = new Padding(3, 2, 3, 2);
            tbSifreYeni.Name = "tbSifreYeni";
            tbSifreYeni.Size = new Size(171, 27);
            tbSifreYeni.TabIndex = 6;
            tbSifreYeni.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 66);
            label4.Name = "label4";
            label4.Size = new Size(272, 40);
            label4.TabIndex = 8;
            label4.Text = "Kullanıcı Kayıt Formu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbSifreYeni);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbIsim);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(tbTCYeni);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 286);
            panel1.TabIndex = 11;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Lavender;
            btnCikisYap.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikisYap.Location = new Point(994, 12);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(150, 46);
            btnCikisYap.TabIndex = 12;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3dduvarkagitlari_b4f030ed;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 713);
            Controls.Add(btnCikisYap);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KULLANICI KAYIT EKRANI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnKaydet;
        private Label label5;
        private TextBox tbTCYeni;
        private TextBox tbIsim;
        private TextBox tbSifreYeni;
        private Label label4;
        private Panel panel1;
        private Button btnCikisYap;
    }
}