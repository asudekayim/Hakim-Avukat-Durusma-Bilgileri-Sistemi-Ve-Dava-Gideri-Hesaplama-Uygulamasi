using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace uygulama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string dosyaYolu = "C:\\Users\\asude\\OneDrive\\Masaüstü\\Yönetici Bilgisi.txt";

        private void Form3_Load(object sender, EventArgs e)
        {
            string firstLine = File.ReadAllLines(dosyaYolu).FirstOrDefault();

            if (firstLine != null)
            {
                string[] bilgiler = firstLine.Split('-');

                label1.Text = bilgiler[0];
                label2.Text = bilgiler[3];
                label3.Text = bilgiler[4];
                label7.Text = bilgiler[5];
            }
        }

        public string dosyaYolu1 = @"C:\Users\asude\OneDrive\Masaüstü\pzt.txt";
        public string dosyaYolu2 = @"C:\Users\asude\OneDrive\Masaüstü\salı.txt";
        public string dosyaYolu3 = @"C:\Users\asude\OneDrive\Masaüstü\çrş.txt";
        public string dosyaYolu4 = @"C:\Users\asude\OneDrive\Masaüstü\prş.txt";
        public string dosyaYolu5 = @"C:\Users\asude\OneDrive\Masaüstü\cuma.txt";

        private void btnGozdenGecir_Click(object sender, EventArgs e)
        {
            string secilenGun1 = cmbGunSec.SelectedItem.ToString();

            if (secilenGun1 == "Pazartesi")
            {

                try
                {
                    // Dosyadan metin oku
                    string metin = File.ReadAllText(dosyaYolu1);

                    // RichTextBox'a metni yazdır
                    richTextBox1.Text = metin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya okuma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (secilenGun1 == "Salı")
            {
                try
                {
                    // Dosyadan metin oku
                    string metin = File.ReadAllText(dosyaYolu2);

                    // RichTextBox'a metni yazdır
                    richTextBox1.Text = metin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya okuma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (secilenGun1 == "Çarşamba")
            {
                try
                {
                    // Dosyadan metin oku
                    string metin = File.ReadAllText(dosyaYolu3);

                    // RichTextBox'a metni yazdır
                    richTextBox1.Text = metin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya okuma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (secilenGun1 == "Perşembe")
            {
                try
                {
                    // Dosyadan metin oku
                    string metin = File.ReadAllText(dosyaYolu4);

                    // RichTextBox'a metni yazdır
                    richTextBox1.Text = metin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya okuma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (secilenGun1 == "Cuma")
            {
                try
                {
                    // Dosyadan metin oku
                    string metin = File.ReadAllText(dosyaYolu5);

                    // RichTextBox'a metni yazdır
                    richTextBox1.Text = metin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya okuma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string secilenGun = cmbGunSec.SelectedItem.ToString();

            if (secilenGun == "Pazartesi")
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu1))
                {
                    sw.Write(richTextBox1.Text);
                }
                MessageBox.Show("Dosya başarıyla kaydedildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (secilenGun == "Salı")
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu2))
                {
                    sw.Write(richTextBox1.Text);
                }
                MessageBox.Show("Dosya başarıyla kaydedildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (secilenGun == "Çarşamba")
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu3))
                {
                    sw.Write(richTextBox1.Text);
                }
                MessageBox.Show("Dosya başarıyla kaydedildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (secilenGun == "Perşembe")
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu4))
                {
                    sw.Write(richTextBox1.Text);
                }
                MessageBox.Show("Dosya başarıyla kaydedildi.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (secilenGun == "Cuma")
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu5))
                {
                    sw.Write(richTextBox1.Text);
                }
                MessageBox.Show("Dosya başarıyla kaydedildi.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void btnYeniOlustur_Click(object sender, EventArgs e)
        {
            // TextBox'lardan bilgileri al
            string bilgi1 = tbYeniAD.Text;
            string bilgi2 = tbYeniTC.Text;
            string bilgi3 = tbYeniSifre.Text;

            // Dosya yolu
            string dosyaYolu = "C:\\Users\\asude\\OneDrive\\Masaüstü\\Kullanıcı Bilgileri.txt";

            try
            {
                // Dosyayı aç ve mevcut içeriği oku
                string oncekiBilgiler = File.ReadAllText(dosyaYolu);

                // Yeni bilgileri ekleyerek dosyayı güncelle
                File.WriteAllText(dosyaYolu, oncekiBilgiler + Environment.NewLine +
                                            bilgi1 + "-" + bilgi2 + "-" + bilgi3);

                MessageBox.Show("Bilgiler başarıyla kaydedildi. Lütfen uygulamaya tekrar girerek giriş yapınız.", "BİLGİLENDİRME",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

