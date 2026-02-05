using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokSatisOtomasyonu.BLL; // BLL katmanına erişim

namespace StokSatisOtomasyonu
{
    public partial class ReportForm : Form
    {
        // Rapor verilerini çekecek olan yeni BLL nesnemiz
        ReportBLL reportBLL = new ReportBLL();

        // Eskiden kalma SaleBLL
        SaleBLL saleBLL = new SaleBLL();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Sayfa açıldığında tüm istatistikleri ve tabloları doldur
            VerileriDoldur();

            // Genel satış listesi tablosu
            try
            {
                if (dgvRaporlar != null)
                {
                    dgvRaporlar.DataSource = saleBLL.TumSatislariGetir();
                }
            }
            catch { }
        }

        private void VerileriDoldur()
        {
            try
            {
                // 1. Aylık Ciro Bilgisi (Mavi Panel)
                DataTable dtAylik = reportBLL.AylikSatisGetir();
                if (dtAylik.Rows.Count > 0)
                {
                    decimal ciro = dtAylik.Rows[0]["ToplamCiro"] != DBNull.Value ? Convert.ToDecimal(dtAylik.Rows[0]["ToplamCiro"]) : 0;
                    lblAylikCiro.Text = ciro.ToString("C2");
                }

                // 2. Toplam Kâr (Yeşil Panel)
                lblToplamKar.Text = reportBLL.ToplamKarGetir();

                // 3. Kritik Stok Sayısı ve Tablosu (Kırmızı Panel ve Yanındaki Tablo)
                DataTable dtKritik = reportBLL.KritikStokGetir();
                lblKritikStokAdet.Text = dtKritik.Rows.Count.ToString();

                // --- YENİ EKLENEN KISIM: Kritik Ürünlerin İsimlerini Tabloya Basar ---
                dgvKritikUrunler.DataSource = dtKritik;

                // 4. Detaylı Tablolar (En Çok Satanlar ve Müşteri Analizi)
                dgvEnCokSatanlar.DataSource = reportBLL.EnCokSatanUrunleriGetir();
                dgvMusteriAnalizi.DataSource = reportBLL.MusteriRaporuGetir();

                // Görsel Ayarlar (Tabloların sütunlarını tam yayar)
                AyarlariUygula();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        // Tablo görünümlerini düzenleyen yardımcı metod
        private void AyarlariUygula()
        {// dgvRaporlar tablosu için kesin çözüm
            foreach (DataGridViewColumn col in dgvRaporlar.Columns)
            {
                // İsmi içinde 'Id' geçen veya 'Sira' geçen her şeyi gizle
                if (col.Name.ToLower().Contains("id"))
                {
                    col.Visible = false;
                }
            }

            // ... (Diğer HeaderText ve Türkçe yapma kodların burada kalsın) 
            // --- GENEL SATIŞ TABLOSU (dgvRaporlar) TEMİZLİĞİ ---
            if (dgvRaporlar.Columns.Count > 0)
            {
                // Sütun isimlerine göre gizlemeyi dene
                string[] gizlenecekler = { "Id", "id", "ID", "ProductId", "CustomerId", "MusteriId", "UrunId" };
                foreach (string sutun in gizlenecekler)
                {
                    if (dgvRaporlar.Columns.Contains(sutun))
                        dgvRaporlar.Columns[sutun].Visible = false;
                }

                // Başlıkları Türkçeleştir
                if (dgvRaporlar.Columns.Contains("Quantity")) dgvRaporlar.Columns["Quantity"].HeaderText = "Adet";
                if (dgvRaporlar.Columns.Contains("TotalPrice")) dgvRaporlar.Columns["TotalPrice"].HeaderText = "Toplam Tutar";
                if (dgvRaporlar.Columns.Contains("SaleDate")) dgvRaporlar.Columns["SaleDate"].HeaderText = "Satış Tarihi";
            }

            // --- DİĞER KÜÇÜK TABLOLARIN AYARLARI ---
            // En Çok Satanlar
            if (dgvEnCokSatanlar.Columns.Contains("ProductName")) dgvEnCokSatanlar.Columns["ProductName"].HeaderText = "Ürün Adı";
            if (dgvEnCokSatanlar.Columns.Contains("ToplamAdet")) dgvEnCokSatanlar.Columns["ToplamAdet"].HeaderText = "Satış Adedi";

            // Kritik Stok
            if (dgvKritikUrunler.Columns.Contains("ProductName")) dgvKritikUrunler.Columns["ProductName"].HeaderText = "Ürün Adı";
            if (dgvKritikUrunler.Columns.Contains("StockQuantity")) dgvKritikUrunler.Columns["StockQuantity"].HeaderText = "Kalan Stok";

            // Müşteri Analizi
            if (dgvMusteriAnalizi.Columns.Contains("FullName")) dgvMusteriAnalizi.Columns["FullName"].HeaderText = "Müşteri Adı";
            if (dgvMusteriAnalizi.Columns.Contains("HarcananTutar")) dgvMusteriAnalizi.Columns["HarcananTutar"].HeaderText = "Toplam Harcama";

            // --- GENEL GÖRÜNÜM ---
            dgvRaporlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnCokSatanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriAnalizi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKritikUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRaporlar.RowHeadersVisible = false;
            dgvEnCokSatanlar.RowHeadersVisible = false;
            dgvMusteriAnalizi.RowHeadersVisible = false;
            dgvKritikUrunler.RowHeadersVisible = false;
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}