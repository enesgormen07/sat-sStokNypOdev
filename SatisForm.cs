using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokSatisOtomasyonu.BLL;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu
{
    public partial class SatisForm : Form
    {
        SaleBLL saleBLL = new SaleBLL();
        ProductBLL productBLL = new ProductBLL();
        CustomerBLL customerBLL = new CustomerBLL();

        public SatisForm()
        {
            InitializeComponent();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                
                cmbMusteri.DataSource = customerBLL.TumMusterileriGetir();
                cmbMusteri.DisplayMember = "FullName";
                cmbMusteri.ValueMember = "Id";

                
                cmbUrun.DataSource = productBLL.TumUrunleriGetir();
                cmbUrun.DisplayMember = "ProductName";
                cmbUrun.ValueMember = "Id";

                cmbMusteri.SelectedIndex = -1;
                cmbUrun.SelectedIndex = -1;

                dgvSatislar.DataSource = saleBLL.TumSatislariGetir();

                
                if (dgvSatislar.Columns.Contains("Id"))
                {
                    dgvSatislar.Columns["Id"].Visible = false;
                }

                dgvSatislar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata: " + ex.Message);
            }
            
            if (dgvSatislar.Columns.Contains("ProductId"))
            {
                dgvSatislar.Columns["ProductId"].Visible = false; 
            }
        }

        
        private void btnSatisYap_Click_1(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedValue == null || cmbUrun.SelectedValue == null || nmAdet.Value <= 0)
            {
                MessageBox.Show("Lütfen müşteri, ürün ve geçerli bir adet seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                DataRowView seciliUrunRow = (DataRowView)cmbUrun.SelectedItem;

                
                decimal birimFiyat = Convert.ToDecimal(seciliUrunRow["UnitPrice"]);

                int adet = (int)nmAdet.Value;
                decimal hesaplananToplam = birimFiyat * adet;

                Sale yeniSatis = new Sale
                {
                    CustomerId = (int)cmbMusteri.SelectedValue,
                    ProductId = (int)cmbUrun.SelectedValue,
                    Quantity = adet,
                    TotalPrice = hesaplananToplam
                };

                saleBLL.SatisYap(yeniSatis);

                MessageBox.Show($"Satış Başarıyla Gerçekleşti!\nToplam Tutar: {hesaplananToplam} ₺", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VerileriYukle();
                nmAdet.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dgvSatislar_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void SatisSil_Click(object sender, EventArgs e)
        {
            
            if (dgvSatislar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satışı tablodan seçin!");
                return;
            }

            try
            {
               
                int satisId = Convert.ToInt32(dgvSatislar.CurrentRow.Cells["Id"].Value);
                int urunId = Convert.ToInt32(dgvSatislar.CurrentRow.Cells["ProductId"].Value);
                int miktar = Convert.ToInt32(dgvSatislar.CurrentRow.Cells["Adet"].Value);

                
                DialogResult onay = MessageBox.Show("Seçili satışı silmek istiyor musunuz? Stok geri yüklenecektir.", "Satış İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    
                    saleBLL.SatisSil(satisId, urunId, miktar);

                    MessageBox.Show("Satış başarıyla silindi ve stok güncellendi.");

                  
                    VerileriYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: Kolon isimlerini kontrol edin! " + ex.Message);
            }
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}