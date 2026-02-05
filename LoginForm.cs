using System;
using System.Windows.Forms;
using StokSatisOtomasyonu.BLL; // BLL katmanına erişim
using StokSatisOtomasyonu.Domain; // User nesnesine erişim

namespace StokSatisOtomasyonu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // BLL nesnesini oluşturuyoruz
                UserBLL userBLL = new UserBLL();

                // Veritabanından kullanıcıyı kontrol ediyoruz
                User girisYapan = userBLL.LoginKontrol(txtKullaniciAdi.Text, txtSifre.Text);

                if (girisYapan != null)
                {
                    // PHPMyAdmin'den gelen 'Role' bilgisini (Yönetici, Satış Personeli vb.) hafızaya alıyoruz
                    AnaForm.GirisYapanRol = girisYapan.Role;

                    MessageBox.Show("Giriş Başarılı! Hoş geldin " + girisYapan.Username);

                    AnaForm ana = new AnaForm();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    // Kullanıcı adı veya şifre yanlışsa bu mesaj çalışacak
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}