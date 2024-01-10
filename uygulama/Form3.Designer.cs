namespace uygulama
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            cmbGunSec = new ComboBox();
            btnGozdenGecir = new Button();
            btnDegistir = new Button();
            groupBox3 = new GroupBox();
            btnYeniOlustur = new Button();
            tbYeniSifre = new TextBox();
            tbYeniTC = new TextBox();
            tbYeniAD = new TextBox();
            label13 = new Label();
            label10 = new Label();
            label12 = new Label();
            btnCikisYap = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(27, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Bilgileri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 196);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 2;
            label8.Text = "Telefon NO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 196);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 2;
            label7.Text = "label3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 151);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 2;
            label6.Text = "Mail Adresi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 151);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 100);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 1;
            label5.Text = "Çalıştığı Birim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 100);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 48);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 0;
            label4.Text = "Adı Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbGunSec);
            groupBox2.Controls.Add(btnGozdenGecir);
            groupBox2.Controls.Add(btnDegistir);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(734, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 582);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duruşma";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 348);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(9, 27);
            label9.Name = "label9";
            label9.Size = new Size(358, 25);
            label9.TabIndex = 2;
            label9.Text = "Aşağıdan değiştirmek istediğiniz günü seçin";
            // 
            // cmbGunSec
            // 
            cmbGunSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGunSec.FormattingEnabled = true;
            cmbGunSec.Items.AddRange(new object[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" });
            cmbGunSec.Location = new Point(59, 55);
            cmbGunSec.Name = "cmbGunSec";
            cmbGunSec.Size = new Size(260, 33);
            cmbGunSec.TabIndex = 1;
            // 
            // btnGozdenGecir
            // 
            btnGozdenGecir.BackColor = Color.Lavender;
            btnGozdenGecir.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGozdenGecir.ForeColor = SystemColors.ActiveCaptionText;
            btnGozdenGecir.Location = new Point(59, 451);
            btnGozdenGecir.Name = "btnGozdenGecir";
            btnGozdenGecir.Size = new Size(260, 59);
            btnGozdenGecir.TabIndex = 0;
            btnGozdenGecir.Text = "Duruşma Bilgilerini Gözden Geçir";
            btnGozdenGecir.UseVisualStyleBackColor = false;
            btnGozdenGecir.Click += btnGozdenGecir_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.BackColor = Color.Lavender;
            btnDegistir.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDegistir.ForeColor = SystemColors.ActiveCaptionText;
            btnDegistir.Location = new Point(59, 519);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(260, 59);
            btnDegistir.TabIndex = 0;
            btnDegistir.Text = "Duruşma Bilgilerini Değiştir";
            btnDegistir.UseVisualStyleBackColor = false;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(btnYeniOlustur);
            groupBox3.Controls.Add(tbYeniSifre);
            groupBox3.Controls.Add(tbYeniTC);
            groupBox3.Controls.Add(tbYeniAD);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(27, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 365);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yeni Kullanıcı Kayıt Formu";
            // 
            // btnYeniOlustur
            // 
            btnYeniOlustur.BackColor = Color.Lavender;
            btnYeniOlustur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniOlustur.ForeColor = SystemColors.ActiveCaptionText;
            btnYeniOlustur.Location = new Point(67, 234);
            btnYeniOlustur.Name = "btnYeniOlustur";
            btnYeniOlustur.Size = new Size(260, 91);
            btnYeniOlustur.TabIndex = 4;
            btnYeniOlustur.Text = "Yeni Kullanıcı Oluştur";
            btnYeniOlustur.UseVisualStyleBackColor = false;
            btnYeniOlustur.Click += btnYeniOlustur_Click;
            // 
            // tbYeniSifre
            // 
            tbYeniSifre.Location = new Point(137, 168);
            tbYeniSifre.Name = "tbYeniSifre";
            tbYeniSifre.Size = new Size(190, 30);
            tbYeniSifre.TabIndex = 3;
            // 
            // tbYeniTC
            // 
            tbYeniTC.Location = new Point(137, 109);
            tbYeniTC.Name = "tbYeniTC";
            tbYeniTC.Size = new Size(190, 30);
            tbYeniTC.TabIndex = 3;
            // 
            // tbYeniAD
            // 
            tbYeniAD.Location = new Point(193, 45);
            tbYeniAD.Name = "tbYeniAD";
            tbYeniAD.Size = new Size(190, 30);
            tbYeniAD.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 168);
            label13.Name = "label13";
            label13.Size = new Size(122, 23);
            label13.TabIndex = 2;
            label13.Text = "Şifre Belirleyin:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 48);
            label10.Name = "label10";
            label10.Size = new Size(181, 23);
            label10.TabIndex = 0;
            label10.Text = "Mesleğiyle Adı Soyadı:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 112);
            label12.Name = "label12";
            label12.Size = new Size(115, 23);
            label12.TabIndex = 2;
            label12.Text = "TC Kimlik NO:";
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Lavender;
            btnCikisYap.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikisYap.ForeColor = SystemColors.ActiveCaptionText;
            btnCikisYap.Location = new Point(793, 619);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(260, 75);
            btnCikisYap.TabIndex = 4;
            btnCikisYap.Text = "Uygulamadan Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._1920x1080_px_Colorful_minimalism_Web_Design_1273713__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 713);
            Controls.Add(btnCikisYap);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMİN EKRANI";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnDegistir;
        private ComboBox cmbGunSec;
        private Label label9;
        private TextBox tbYeniAD;
        private Label label13;
        private Label label10;
        private Label label12;
        private Button btnYeniOlustur;
        private TextBox tbYeniSifre;
        private TextBox tbYeniTC;
        private RichTextBox richTextBox1;
        private Button btnGozdenGecir;
        private Button btnCikisYap;
    }
}