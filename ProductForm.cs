using System;
using System.Data; 
using System.Windows.Forms;
using StokSatisOtomasyonu.BLL;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu
{
    public partial class ProductForm : Form
    {
        ProductBLL productBLL = new ProductBLL();

        public ProductForm()
        {
            InitializeComponent();
            dgvUrunler.AutoGenerateColumns = false;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            // BLL'den gelen DataTable'ı doğrudan basıyoruz
            dgvUrunler.DataSource = productBLL.TumUrunleriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product
                {
                    ProductName = txtUrunAdi.Text,
                    StockQuantity = (int)nmrStok.Value,
                    UnitPrice = Convert.ToDecimal(txtSatisFiyati.Text),
                    CostPrice = Convert.ToDecimal(txtMaliyetFiyati.Text)
                };

                productBLL.YeniUrunEkle(p);
                MessageBox.Show("Ürün eklendi!");
                Temizle();
                Yenile();
            }
            catch (Exception ex) { MessageBox.Show("Ekleme hatası: " + ex.Message); }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUrunler.CurrentRow != null)
            {
                try
                {
                    DataRowView satir = (DataRowView)dgvUrunler.CurrentRow.DataBoundItem;

                    txtUrunAdi.Text = satir["ProductName"].ToString();
                    nmrStok.Value = Convert.ToDecimal(satir["StockQuantity"]);
                    txtMaliyetFiyati.Text = satir["CostPrice"].ToString();
                    txtSatisFiyati.Text = satir["UnitPrice"].ToString();

                    
                    if (satir.DataView.Table.Columns.Contains("id"))
                    {
                        cmbKategori.Text = satir["id"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUrunler.CurrentRow != null)
                {
                    DataRowView satir = (DataRowView)dgvUrunler.CurrentRow.DataBoundItem;
                    int id = Convert.ToInt32(satir["Id"]); 

                    if (MessageBox.Show("Silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        productBLL.UrunSil(id);
                        Yenile();
                        Temizle();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Silme hatası: " + ex.Message); }
        }

        private void Temizle()
        {
            txtUrunAdi.Clear();
            txtMaliyetFiyati.Clear();
            txtSatisFiyati.Clear();
            nmrStok.Value = 0;

            
            cmbKategori.Text = "";
            

            txtUrunAdi.Focus(); 
        }

        private void btnListele_Click(object sender, EventArgs e) => Yenile();

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || dgvUrunler.Rows[e.RowIndex].IsNewRow) return;

            if (dgvUrunler.CurrentRow != null)
            {
                
                DataRowView row = (DataRowView)dgvUrunler.CurrentRow.DataBoundItem;

                
                if (row != null)
                {
                    txtUrunAdi.Text = row["ProductName"].ToString();
                    nmrStok.Value = Convert.ToDecimal(row["StockQuantity"]);
                    txtMaliyetFiyati.Text = row["CostPrice"].ToString();
                    txtSatisFiyati.Text = row["UnitPrice"].ToString();

                   
                    if (row.DataView.Table.Columns.Contains("id"))
                        cmbKategori.Text = row["id"].ToString();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow != null)
            {
                try
                {
                    DataRowView satir = (DataRowView)dgvUrunler.CurrentRow.DataBoundItem;

                    Product p = new Product
                    {
                        
                        Id = Convert.ToInt32(satir["Id"]),
                        ProductName = txtUrunAdi.Text,
                        StockQuantity = (int)nmrStok.Value,
                        UnitPrice = Convert.ToDecimal(txtSatisFiyati.Text),
                        CostPrice = Convert.ToDecimal(txtMaliyetFiyati.Text),

                      
                        CategoryId = string.IsNullOrEmpty(cmbKategori.Text) ? 0 : int.Parse(cmbKategori.Text)
                    };

                    productBLL.UrunGuncelle(p);

                    MessageBox.Show("Ürün ve Kategorisi başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Yenile();  
                    Temizle(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}