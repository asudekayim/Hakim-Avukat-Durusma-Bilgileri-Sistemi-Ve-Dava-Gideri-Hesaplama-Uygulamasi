namespace uygulama
{
    partial class Form4
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
            listBox1 = new ListBox();
            panel1 = new Panel();
            label1 = new Label();
            cmbGunler = new ComboBox();
            btnGoruntule = new Button();
            btnCikisYap = new Button();
            btnPdf = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.SeaShell;
            listBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(677, 27);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(467, 579);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbGunler);
            panel1.Controls.Add(btnGoruntule);
            panel1.Location = new Point(115, 525);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 116);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "GÜN SEÇİNİZ:";
            // 
            // cmbGunler
            // 
            cmbGunler.BackColor = Color.Lavender;
            cmbGunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGunler.FormattingEnabled = true;
            cmbGunler.Items.AddRange(new object[] { "PAZARTESİ", "SALI", "ÇARŞAMBA", "PERŞEMBE", "CUMA" });
            cmbGunler.Location = new Point(146, 11);
            cmbGunler.Name = "cmbGunler";
            cmbGunler.Size = new Size(238, 28);
            cmbGunler.TabIndex = 1;
            // 
            // btnGoruntule
            // 
            btnGoruntule.BackColor = Color.Lavender;
            btnGoruntule.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoruntule.Location = new Point(14, 57);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(370, 42);
            btnGoruntule.TabIndex = 0;
            btnGoruntule.Text = "Bilgileri Görüntüle";
            btnGoruntule.UseVisualStyleBackColor = false;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Lavender;
            btnCikisYap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikisYap.Location = new Point(215, 647);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(184, 42);
            btnCikisYap.TabIndex = 2;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.Lavender;
            btnPdf.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.Location = new Point(1033, 636);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(111, 42);
            btnPdf.TabIndex = 3;
            btnPdf.Text = "PDF AKTAR";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._3dduvarkagitlari_21c9d81c;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 713);
            Controls.Add(btnPdf);
            Controls.Add(btnCikisYap);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DURUŞMA BİLGİLERİ EKRANI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbGunler;
        private Button btnGoruntule;
        private Button btnCikisYap;
        private Button btnPdf;
    }
}