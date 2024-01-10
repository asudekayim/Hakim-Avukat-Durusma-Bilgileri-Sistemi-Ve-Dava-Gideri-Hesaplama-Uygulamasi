using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace uygulama
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            string secilenGun = cmbGunler.SelectedItem.ToString();

            if (secilenGun == "PAZARTESİ")
            {
                StreamReader read1 = new StreamReader("C:\\Users\\asude\\OneDrive\\Masaüstü\\pzt.txt");

                while (read1.EndOfStream == false)
                {
                    listBox1.Items.Add(read1.ReadLine());
                }
            }
            else if (secilenGun == "SALI")
            {
                StreamReader read2 = new StreamReader("C:\\Users\\asude\\OneDrive\\Masaüstü\\salı.txt");

                while (read2.EndOfStream == false)
                {
                    listBox1.Items.Add(read2.ReadLine());
                }
            }
            else if (secilenGun == "ÇARŞAMBA")
            {
                StreamReader read3 = new StreamReader("C:\\Users\\asude\\OneDrive\\Masaüstü\\çrş.txt");

                while (read3.EndOfStream == false)
                {
                    listBox1.Items.Add(read3.ReadLine());
                }
            }
            else if (secilenGun == "PERŞEMBE")
            {
                StreamReader read4 = new StreamReader("C:\\Users\\asude\\OneDrive\\Masaüstü\\prş.txt");

                while (read4.EndOfStream == false)
                {
                    listBox1.Items.Add(read4.ReadLine());
                }
            }
            else if (secilenGun == "CUMA")
            {
                StreamReader read5 = new StreamReader("C:\\Users\\asude\\OneDrive\\Masaüstü\\cuma.txt");

                while (read5.EndOfStream == false)
                {
                    listBox1.Items.Add(read5.ReadLine());
                }
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

            pdfYaz(listBox1, "C:\\pdf\\" + cmbGunler.SelectedItem + ".pdf", (string)cmbGunler.SelectedItem);
            MessageBox.Show("PDF DOSYASINA " + cmbGunler.SelectedItem + " İSMİYLE KAYDEDİLDİ!");

        }

        void pdfYaz(ListBox listbox, string pdfYolu, string gun)
        {
            PdfFont fnt = PdfFontFactory.CreateFont("resources/fonts/arial.ttf", PdfEncodings.IDENTITY_H);

            using (PdfWriter writer = new PdfWriter(pdfYolu))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    using (Document dokuman = new Document(pdf))
                    {
                        dokuman.Add(new Paragraph(gun.ToString()).SetFont(fnt));
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
