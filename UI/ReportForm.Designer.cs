namespace StokSatisOtomasyonu
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAylikCiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToplamKar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKritikStokAdet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEnCokSatanlar = new System.Windows.Forms.DataGridView();
            this.dgvMusteriAnalizi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKritikUrunler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokSatanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriAnalizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaporlar
            // 
            this.dgvRaporlar.AllowUserToAddRows = false;
            this.dgvRaporlar.AllowUserToDeleteRows = false;
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRaporlar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRaporlar.Location = new System.Drawing.Point(2, 370);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.ReadOnly = true;
            this.dgvRaporlar.RowHeadersWidth = 62;
            this.dgvRaporlar.RowTemplate.Height = 28;
            this.dgvRaporlar.Size = new System.Drawing.Size(989, 193);
            this.dgvRaporlar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lblAylikCiro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 126);
            this.panel1.TabIndex = 1;
            // 
            // lblAylikCiro
            // 
            this.lblAylikCiro.AutoSize = true;
            this.lblAylikCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikCiro.Location = new System.Drawing.Point(74, 71);
            this.lblAylikCiro.Name = "lblAylikCiro";
            this.lblAylikCiro.Size = new System.Drawing.Size(59, 20);
            this.lblAylikCiro.TabIndex = 1;
            this.lblAylikCiro.Text = "0,00 ₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aylık Ciro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.lblToplamKar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(381, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 126);
            this.panel2.TabIndex = 2;
            // 
            // lblToplamKar
            // 
            this.lblToplamKar.AutoSize = true;
            this.lblToplamKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKar.Location = new System.Drawing.Point(72, 71);
            this.lblToplamKar.Name = "lblToplamKar";
            this.lblToplamKar.Size = new System.Drawing.Size(59, 20);
            this.lblToplamKar.TabIndex = 1;
            this.lblToplamKar.Text = "0,00 ₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Kâr";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblKritikStokAdet);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(687, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 126);
            this.panel3.TabIndex = 3;
            // 
            // lblKritikStokAdet
            // 
            this.lblKritikStokAdet.AutoSize = true;
            this.lblKritikStokAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKritikStokAdet.Location = new System.Drawing.Point(68, 71);
            this.lblKritikStokAdet.Name = "lblKritikStokAdet";
            this.lblKritikStokAdet.Size = new System.Drawing.Size(19, 20);
            this.lblKritikStokAdet.TabIndex = 1;
            this.lblKritikStokAdet.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kritik Stok";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvEnCokSatanlar
            // 
            this.dgvEnCokSatanlar.AllowUserToAddRows = false;
            this.dgvEnCokSatanlar.AllowUserToDeleteRows = false;
            this.dgvEnCokSatanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnCokSatanlar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEnCokSatanlar.Location = new System.Drawing.Point(2, 179);
            this.dgvEnCokSatanlar.Name = "dgvEnCokSatanlar";
            this.dgvEnCokSatanlar.ReadOnly = true;
            this.dgvEnCokSatanlar.RowHeadersWidth = 62;
            this.dgvEnCokSatanlar.RowTemplate.Height = 28;
            this.dgvEnCokSatanlar.Size = new System.Drawing.Size(324, 185);
            this.dgvEnCokSatanlar.TabIndex = 4;
            // 
            // dgvMusteriAnalizi
            // 
            this.dgvMusteriAnalizi.AllowUserToAddRows = false;
            this.dgvMusteriAnalizi.AllowUserToDeleteRows = false;
            this.dgvMusteriAnalizi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusteriAnalizi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMusteriAnalizi.Location = new System.Drawing.Point(679, 179);
            this.dgvMusteriAnalizi.Name = "dgvMusteriAnalizi";
            this.dgvMusteriAnalizi.ReadOnly = true;
            this.dgvMusteriAnalizi.RowHeadersWidth = 62;
            this.dgvMusteriAnalizi.RowTemplate.Height = 28;
            this.dgvMusteriAnalizi.Size = new System.Drawing.Size(312, 185);
            this.dgvMusteriAnalizi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "En Çok Satan 5 Ürün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(791, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "En İyi Müşteriler";
            // 
            // dgvKritikUrunler
            // 
            this.dgvKritikUrunler.AllowUserToAddRows = false;
            this.dgvKritikUrunler.AllowUserToDeleteRows = false;
            this.dgvKritikUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKritikUrunler.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKritikUrunler.Location = new System.Drawing.Point(332, 179);
            this.dgvKritikUrunler.Name = "dgvKritikUrunler";
            this.dgvKritikUrunler.ReadOnly = true;
            this.dgvKritikUrunler.RowHeadersWidth = 62;
            this.dgvKritikUrunler.RowTemplate.Height = 28;
            this.dgvKritikUrunler.Size = new System.Drawing.Size(341, 185);
            this.dgvKritikUrunler.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(440, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kritik Stoktaki Ürünler";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(93, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ürün";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 684);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvKritikUrunler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMusteriAnalizi);
            this.Controls.Add(this.dgvEnCokSatanlar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRaporlar);
            this.Name = "ReportForm";
            this.Text = "En Çok Satan 5 Ürün";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokSatanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriAnalizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaporlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAylikCiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamKar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKritikStokAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEnCokSatanlar;
        private System.Windows.Forms.DataGridView dgvMusteriAnalizi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKritikUrunler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}