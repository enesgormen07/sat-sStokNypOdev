using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using StokSatisOtomasyonu.Domain;
using StokSatisOtomasyonu.BLL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace StokSatisOtomasyonu
{
    public partial class AnaForm : Form
    {
        // Login ekranından gelen rol bilgisini burada tutuyoruz
        public static string GirisYapanRol;

        ReportBLL reportBLL = new ReportBLL();
        int resimSira = 1;

        public AnaForm()
        {
            InitializeComponent();
        }

        // --- GÜNCEL SAYILARI GETİREN ANA METOD ---
        public void IstatistikleriGetir()
        {
            try
            {
                lblStokAdet.Text = reportBLL.ToplamStokSayisiGetir() + " Adet";
                lblKazanc.Text = reportBLL.GunlukKazancGetir();

                DataTable dtKritik = reportBLL.KritikStokGetir();
                lblKritik.Text = dtKritik.Rows.Count.ToString() + " Ürün";

                if (dtKritik.Rows.Count > 0) lblKritik.ForeColor = Color.Red;
                else lblKritik.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                lblStokAdet.Text = "0 Adet";
                lblKazanc.Text = "0,00 ₺";
                lblKritik.Text = "0 Ürün";
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            IstatistikleriGetir();
            try { pbSlider.Image = Properties.Resources._1_jpg; } catch { }
            timerSlider.Start();

            // 1. ToolTip nesnesini oluşturuyoruz
            ToolTip yetkiUyari = new ToolTip();
            yetkiUyari.ToolTipTitle = "Yetki Kısıtlaması";
            yetkiUyari.ToolTipIcon = ToolTipIcon.Warning;
            yetkiUyari.IsBalloon = true; // Balon şeklinde görünmesi için

            string uyariMesaji = "Bu işlem için yetkiniz bulunmamaktadır.";

            // 2. YETKİ KONTROLLERİ VE İPUÇLARI
            if (GirisYapanRol == "Satış Personeli")
            {
                // Butonları kilitle
                btnUrunler.Enabled = false;
                btnRaporlar.Enabled = false;

                // Üzerine gelince mesajı göster
                yetkiUyari.SetToolTip(btnUrunler, uyariMesaji);
                yetkiUyari.SetToolTip(btnRaporlar, uyariMesaji);
            }
            else if (GirisYapanRol == "Depo Görevlisi")
            {
                // Butonları kilitle
                btnSatis.Enabled = false;
                btnMusteriler.Enabled = false;
                btnRaporlar.Enabled = false;

                // Üzerine gelince mesajı göster
                yetkiUyari.SetToolTip(btnSatis, uyariMesaji);
                yetkiUyari.SetToolTip(btnMusteriler, uyariMesaji);
                yetkiUyari.SetToolTip(btnRaporlar, uyariMesaji);
            }

        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (resimSira)
                {
                    case 1: pbSlider.Image = Properties.Resources._1_jpg; break;
                    case 2: pbSlider.Image = Properties.Resources._2_jpg; break;
                    case 3: pbSlider.Image = Properties.Resources._3_jpg; break;
                    case 4: pbSlider.Image = Properties.Resources._4_jpg; break;
                    case 5: pbSlider.Image = Properties.Resources._5_jpg; break;
                }
                resimSira++;
                if (resimSira > 5) resimSira = 1;
            }
            catch { timerSlider.Stop(); }
        }

        public void FormuGetir(Form altForm)
        {
            pnlDashboard.Visible = false;
            foreach (Control item in pnlIcerik.Controls.Cast<Control>().ToList())
            {
                if (item is Form) pnlIcerik.Controls.Remove(item);
            }
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(altForm);
            altForm.BringToFront();
            altForm.Show();
        }

        private void btnUrunler_Click_1(object sender, EventArgs e) { FormuGetir(new ProductForm()); }
        private void btnMusteriler_Click_1(object sender, EventArgs e) { FormuGetir(new CustomerForm()); }
        private void btnSatis_Click_1(object sender, EventArgs e) { FormuGetir(new SatisForm()); }
        private void btnRaporlar_Click_1(object sender, EventArgs e) { FormuGetir(new ReportForm()); }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            IstatistikleriGetir();
            foreach (Control item in pnlIcerik.Controls.Cast<Control>().ToList())
            {
                if (item is Form) pnlIcerik.Controls.Remove(item);
            }
            pnlDashboard.Visible = true;
            pnlDashboard.BringToFront();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void pbSlider_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
    }
}