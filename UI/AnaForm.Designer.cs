namespace StokSatisOtomasyonu
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.pnlSolMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.pnlIcerik = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pbSlider = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlToplamArac = new System.Windows.Forms.Panel();
            this.lblStokAdet = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKazanc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKritik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.pnlSolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlIcerik.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlider)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlToplamArac.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();

            this.pnlSolMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlSolMenu.Controls.Add(this.btnCikis);
            this.pnlSolMenu.Controls.Add(this.btnAnaSayfa);
            this.pnlSolMenu.Controls.Add(this.pictureBox1);
            this.pnlSolMenu.Controls.Add(this.btnRaporlar);
            this.pnlSolMenu.Controls.Add(this.btnSatis);
            this.pnlSolMenu.Controls.Add(this.btnMusteriler);
            this.pnlSolMenu.Controls.Add(this.btnUrunler);
            this.pnlSolMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSolMenu.Name = "pnlSolMenu";
            this.pnlSolMenu.Size = new System.Drawing.Size(167, 649);
            this.pnlSolMenu.TabIndex = 0;

            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Tomato;
            this.btnCikis.Location = new System.Drawing.Point(12, 534);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(142, 61);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAnaSayfa.Location = new System.Drawing.Point(12, 151);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(142, 61);
            this.btnAnaSayfa.TabIndex = 5;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);

            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-71, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;

            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRaporlar.Location = new System.Drawing.Point(12, 458);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(142, 61);
            this.btnRaporlar.TabIndex = 3;
            this.btnRaporlar.Text = "Raporlama Ekranı";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click_1);

            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatis.Location = new System.Drawing.Point(12, 382);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(142, 61);
            this.btnSatis.TabIndex = 2;
            this.btnSatis.Text = "Satış Ekran";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click_1);

            this.btnMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMusteriler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriler.Location = new System.Drawing.Point(12, 304);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(142, 61);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "Müşteri Yönetimi";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click_1);

            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUrunler.Location = new System.Drawing.Point(12, 228);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(142, 61);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Text = "Ürün Yönetimi";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click_1);

            this.pnlIcerik.Controls.Add(this.pnlDashboard);
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Location = new System.Drawing.Point(167, 0);
            this.pnlIcerik.Name = "pnlIcerik";
            this.pnlIcerik.Size = new System.Drawing.Size(980, 649);
            this.pnlIcerik.TabIndex = 1;

            this.pnlDashboard.Controls.Add(this.pbSlider);
            this.pnlDashboard.Controls.Add(this.panel1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(980, 649);
            this.pnlDashboard.TabIndex = 6;

            this.pbSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbSlider.Location = new System.Drawing.Point(0, 136);
            this.pbSlider.Name = "pbSlider";
            this.pbSlider.Size = new System.Drawing.Size(980, 513);
            this.pbSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlider.TabIndex = 5;
            this.pbSlider.TabStop = false;

            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.pnlToplamArac);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 147);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);

            this.pnlToplamArac.BackColor = System.Drawing.Color.White;
            this.pnlToplamArac.Controls.Add(this.lblStokAdet);
            this.pnlToplamArac.Controls.Add(this.panel5);
            this.pnlToplamArac.Controls.Add(this.label2);
            this.pnlToplamArac.Location = new System.Drawing.Point(47, 21);
            this.pnlToplamArac.Name = "pnlToplamArac";
            this.pnlToplamArac.Size = new System.Drawing.Size(220, 100);
            this.pnlToplamArac.TabIndex = 1;

            this.lblStokAdet.AutoSize = true;
            this.lblStokAdet.Location = new System.Drawing.Point(95, 52);
            this.lblStokAdet.Name = "lblStokAdet";
            this.lblStokAdet.Size = new System.Drawing.Size(18, 20);
            this.lblStokAdet.TabIndex = 6;
            this.lblStokAdet.Text = "0";

            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 100);
            this.panel5.TabIndex = 5;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "TOPLAM STOK";

            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblKazanc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(704, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 100);
            this.panel2.TabIndex = 2;

            this.lblKazanc.AutoSize = true;
            this.lblKazanc.Location = new System.Drawing.Point(93, 52);
            this.lblKazanc.Name = "lblKazanc";
            this.lblKazanc.Size = new System.Drawing.Size(18, 20);
            this.lblKazanc.TabIndex = 7;
            this.lblKazanc.Text = "0";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "GÜNLÜK KAZANÇ";

            this.panel6.BackColor = System.Drawing.Color.LawnGreen;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 100);
            this.panel6.TabIndex = 5;

            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblKritik);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(393, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 100);
            this.panel3.TabIndex = 4;

            this.lblKritik.AutoSize = true;
            this.lblKritik.Location = new System.Drawing.Point(93, 52);
            this.lblKritik.Name = "lblKritik";
            this.lblKritik.Size = new System.Drawing.Size(18, 20);
            this.lblKritik.TabIndex = 7;
            this.lblKritik.Text = "0";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "KRİTİK STOK";

            this.panel7.BackColor = System.Drawing.Color.Tomato;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 100);
            this.panel7.TabIndex = 5;

            this.timerSlider.Interval = 3200;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 649);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.pnlSolMenu);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.pnlSolMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlIcerik.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlToplamArac.ResumeLayout(false);
            this.pnlToplamArac.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSolMenu;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Panel pnlIcerik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerSlider;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlToplamArac;
        private System.Windows.Forms.Label lblStokAdet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKazanc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbSlider;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKritik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlDashboard;
    }
}