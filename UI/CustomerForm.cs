using System;
using System.Windows.Forms;
using StokSatisOtomasyonu.BLL;
using StokSatisOtomasyonu.Domain;

namespace StokSatisOtomasyonu
{
    public partial class CustomerForm : Form
    {
        CustomerBLL customerBLL = new CustomerBLL();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dgvMusteriler.DataSource = customerBLL.TumMusterileriGetir();

            if (dgvMusteriler.Columns.Count > 0)
            {
                dgvMusteriler.Columns["FullName"].HeaderText = "Ad Soyad";
                dgvMusteriler.Columns["PhoneNumber"].HeaderText = "Telefon";
                dgvMusteriler.Columns["Email"].HeaderText = "E-Posta";
                dgvMusteriler.Columns["Address"].HeaderText = "Adres";
                dgvMusteriler.Columns["Id"].Visible = false;
            }
        }

        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Customer yeniMusteri = new Customer
                {
                    FullName = txtAdSoyad.Text,
                    PhoneNumber = txtTelefon.Text,
                    Email = txtEmail.Text,
                    Address = txtAdres.Text
                };

                customerBLL.YeniMusteriEkle(yeniMusteri);
                MessageBox.Show("Müşteri başarıyla kaydedildi!");

                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMusteriler.Rows[e.RowIndex].IsNewRow) return;

            if (dgvMusteriler.CurrentRow != null)
            {
                var satir = dgvMusteriler.CurrentRow;
                txtAdSoyad.Text = satir.Cells["FullName"].Value.ToString();
                txtTelefon.Text = satir.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = satir.Cells["Email"].Value.ToString();
                txtAdres.Text = satir.Cells["Address"].Value.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["Id"].Value);
                DialogResult onay = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    customerBLL.MusteriSil(id);
                    MessageBox.Show("Müşteri başarıyla silindi.");
                    Listele();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi tablodan seçin!");
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow != null)
            {
                try
                {
                    int seciliId = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["Id"].Value);

                    Customer güncellenecekMusteri = new Customer
                    {
                        Id = seciliId,
                        FullName = txtAdSoyad.Text,
                        PhoneNumber = txtTelefon.Text,
                        Email = txtEmail.Text,
                        Address = txtAdres.Text
                    };

                    customerBLL.MusteriGuncelle(güncellenecekMusteri);
                    MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!");

                    Listele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi tablodan seçin!");
            }
        }

        
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                Customer yeniMusteri = new Customer
                {
                    FullName = txtAdSoyad.Text,
                    PhoneNumber = txtTelefon.Text,
                    Email = txtEmail.Text,
                    Address = txtAdres.Text
                };

                
                customerBLL.YeniMusteriEkle(yeniMusteri);

                
                MessageBox.Show("Müşteri başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                Listele();  
                Temizle();  
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ekleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}