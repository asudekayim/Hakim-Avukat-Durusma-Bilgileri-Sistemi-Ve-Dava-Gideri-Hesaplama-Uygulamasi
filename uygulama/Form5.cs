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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // TextBox'lardan bilgileri al
            string bilgi1 = tbIsim.Text;
            string bilgi2 = tbTCYeni.Text;
            string bilgi3 = tbSifreYeni.Text;

            // Dosya yolu
            string dosyaYolu = "C:\\Users\\asude\\OneDrive\\Masaüstü\\Kullanıcı Bilgileri.txt";

            try
            {
                // Dosyayı aç ve mevcut içeriği oku
                string oncekiBilgiler = File.ReadAllText(dosyaYolu);

                // Yeni bilgileri ekleyerek dosyayı güncelle
                File.WriteAllText(dosyaYolu, oncekiBilgiler + Environment.NewLine +
                                            bilgi1 + "-" + bilgi2 + "-" + bilgi3);

                MessageBox.Show("Bilgiler başarıyla kaydedildi. Lütfen çıkış yap butonuna tıkladıktan sonra tekrar giriniz.", "BİLGİLENDİRME",
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
