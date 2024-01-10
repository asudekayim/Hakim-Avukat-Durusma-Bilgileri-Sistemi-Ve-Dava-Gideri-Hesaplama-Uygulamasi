using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double pesinHarcDegeri = 0;
        double davaDegeri;
        double deger;
        double MahkemeTuru(int ID)
        {
            if (ID == 0 || ID == 1)
            {
                return Hesaplama.shmBasvuruHarci;
            }
            else return Hesaplama.ahmBasvuruHarci;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Hesaplama hesap = new Hesaplama(Convert.ToInt16(tbBilirkisiSayisi.Text), Convert.ToDouble(tbDeger.Text), cmbMahkeme.SelectedIndex, Convert.ToInt16(tbTanikSayisi.Text),
                Convert.ToInt16(tbAvukatSayisi.Text), Convert.ToInt16(tbTarafSayisi.Text));

            if (!chkMaktu.Checked)
            {
                pesinHarcDegeri = hesap.pesinHarcHesapla();

                if (cmbMahkeme.SelectedIndex == 0 || cmbMahkeme.SelectedIndex == 1)
                {
                    if (pesinHarcDegeri < Hesaplama.shmBasvuruHarci)
                    {
                        deger = Hesaplama.shmBasvuruHarci;
                    }
                    else deger = pesinHarcDegeri;
                }
                else
                {
                    if (pesinHarcDegeri < Hesaplama.ahmBasvuruHarci)
                    {
                        deger = Hesaplama.ahmBasvuruHarci;
                    }
                    else deger = pesinHarcDegeri;
                }
            }
            else
            {
                pesinHarcDegeri = hesap.maktuHarcHesapla(cmbMahkeme.SelectedIndex);
            }

            listBox1.Items.Add("HESAP DÖKÜMÜ");
            listBox1.Items.Add("*******************");
            string secilenMahkeme = cmbMahkeme.SelectedItem.ToString();
            listBox1.Items.Add("Mahkeme Türü : " + secilenMahkeme);
            listBox1.Items.Add("Dava Değeri : " + tbDeger.Text + "TL");
            listBox1.Items.Add("*******************");

            if (cmbMahkeme.SelectedIndex == 0 || cmbMahkeme.SelectedIndex == 1)
            {
                listBox1.Items.Add("Başvuru Harcı : " + Hesaplama.shmBasvuruHarci);
            }
            else
            {
                listBox1.Items.Add("Başvuru Harcı : " + Hesaplama.ahmBasvuruHarci);
            }

            listBox1.Items.Add("Dosya Gideri : " + Hesaplama.dosyaGideri);
            listBox1.Items.Add("Peşin Harç : " + deger.ToString("F2")); // pesinHarcDegeri.ToString("F2"));
            listBox1.Items.Add("Tebligat Gideri : " + hesap.tebligatGideri());
            listBox1.Items.Add("Vekalet Harcı : " + Hesaplama.vekaletSuretHarci);
            listBox1.Items.Add("Bilirkişi Ücreti : " + hesap.BilirkisiUcreti());
            listBox1.Items.Add("Tanık Gideri : " + hesap.tanikUcretiHesapla(Convert.ToInt32(tbTanikSayisi.Text)));

            if (cmbMahkeme.SelectedIndex == 0 || cmbMahkeme.SelectedIndex == 1)
            {
                double toplam1 = Hesaplama.shmBasvuruHarci + Hesaplama.dosyaGideri + hesap.BilirkisiUcreti() + hesap.tebligatGideri() + Hesaplama.vekaletSuretHarci + hesap.tanikUcretiHesapla(Convert.ToInt32(tbTanikSayisi.Text) + (int)pesinHarcDegeri);

                listBox1.Items.Add("TOPLAM : " + toplam1);
            }
            else
            {
                var toplam2 = Hesaplama.ahmBasvuruHarci + Hesaplama.dosyaGideri + hesap.BilirkisiUcreti() + hesap.tebligatGideri() + Hesaplama.vekaletSuretHarci + hesap.tanikUcretiHesapla(Convert.ToInt32(tbTanikSayisi.Text));

                listBox1.Items.Add("TOPLAM : " + toplam2);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkMaktu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaktu.Checked)
            {
                tbDeger.Enabled = false;
                tbDeger.Text = "0";
            }
            else if (!chkMaktu.Checked)
            {
                tbDeger.Enabled = true;
            }
        }


        private void linkDurusma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbMahkeme.SelectedIndex = -1;
            tbDeger.Clear();
            cmbBilirkisi.SelectedIndex = -1;
            chkMaktu.Checked = false;
            tbBilirkisiSayisi.Clear();
            tbTarafSayisi.Clear();
            tbTanikSayisi.Clear();
            tbAvukatSayisi.Clear();
            listBox1.Items.Clear();
        }

        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            pdfYaz(listBox1, "C:\\pdf\\Hesap Dökümü.pdf");
            MessageBox.Show("PDF DOSYASINA HESAP DÖKÜMÜ İSMİYLE KAYDEDİLDİ!");
        }

        void pdfYaz(ListBox listbox , string pdfYolu)
        {
            PdfFont fnt = PdfFontFactory.CreateFont("resources/fonts/arial.ttf", PdfEncodings.IDENTITY_H);

            using (PdfWriter writer = new PdfWriter(pdfYolu))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    using (Document dokuman = new Document(pdf))
                    {
                        foreach (var item in listbox.Items)
                        {
                            dokuman.Add(new Paragraph(item.ToString()).SetFont(fnt));

                        }
                    }
                }
            }
        }
    }
}
