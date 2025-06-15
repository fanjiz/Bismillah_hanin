namespace Bismillah_Hanin
{
    partial class FormPesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesanan));
            this.btnTambahPesanan = new System.Windows.Forms.Button();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.btnBayarPesanan = new System.Windows.Forms.Button();
            this.btnRiwayatBayar = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.cbStatusPengerjaan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambahPesanan
            // 
            this.btnTambahPesanan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPesanan.Location = new System.Drawing.Point(44, 347);
            this.btnTambahPesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTambahPesanan.Name = "btnTambahPesanan";
            this.btnTambahPesanan.Size = new System.Drawing.Size(287, 60);
            this.btnTambahPesanan.TabIndex = 0;
            this.btnTambahPesanan.Text = "       Tambah Pesanan";
            this.btnTambahPesanan.UseVisualStyleBackColor = true;
            this.btnTambahPesanan.Click += new System.EventHandler(this.btnTambahPesanan_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.AllowUserToAddRows = false;
            this.dgvPesanan.AllowUserToDeleteRows = false;
            this.dgvPesanan.AllowUserToOrderColumns = true;
            this.dgvPesanan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(364, 347);
            this.dgvPesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.ReadOnly = true;
            this.dgvPesanan.RowHeadersWidth = 62;
            this.dgvPesanan.Size = new System.Drawing.Size(780, 429);
            this.dgvPesanan.TabIndex = 1;
            this.dgvPesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellClick);
            // 
            // btnBayarPesanan
            // 
            this.btnBayarPesanan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayarPesanan.Location = new System.Drawing.Point(44, 449);
            this.btnBayarPesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBayarPesanan.Name = "btnBayarPesanan";
            this.btnBayarPesanan.Size = new System.Drawing.Size(287, 56);
            this.btnBayarPesanan.TabIndex = 2;
            this.btnBayarPesanan.Text = "      Bayar Pesanan";
            this.btnBayarPesanan.UseVisualStyleBackColor = true;
            this.btnBayarPesanan.Click += new System.EventHandler(this.btnBayarPesanan_Click);
            // 
            // btnRiwayatBayar
            // 
            this.btnRiwayatBayar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayatBayar.Location = new System.Drawing.Point(44, 718);
            this.btnRiwayatBayar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRiwayatBayar.Name = "btnRiwayatBayar";
            this.btnRiwayatBayar.Size = new System.Drawing.Size(287, 58);
            this.btnRiwayatBayar.TabIndex = 3;
            this.btnRiwayatBayar.Text = "     Riwayat Pembayaran";
            this.btnRiwayatBayar.UseVisualStyleBackColor = true;
            this.btnRiwayatBayar.Click += new System.EventHandler(this.btnRiwayatBayar_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHapus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(1030, 925);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(130, 47);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // cbStatusPengerjaan
            // 
            this.cbStatusPengerjaan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusPengerjaan.FormattingEnabled = true;
            this.cbStatusPengerjaan.Items.AddRange(new object[] {
            "Diproses",
            "Selesai",
            "Diambil"});
            this.cbStatusPengerjaan.Location = new System.Drawing.Point(367, 938);
            this.cbStatusPengerjaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatusPengerjaan.Name = "cbStatusPengerjaan";
            this.cbStatusPengerjaan.Size = new System.Drawing.Size(262, 35);
            this.cbStatusPengerjaan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 905);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status Pengerjaan";
            // 
            // btnSimpan
            // 
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSimpan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(678, 925);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(130, 48);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(770, 280);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(258, 35);
            this.tbCari.TabIndex = 8;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.White;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(1048, 280);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(96, 35);
            this.btnCari.TabIndex = 9;
            this.btnCari.Text = "     Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(481, 786);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 47);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(368, 786);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(105, 47);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.Location = new System.Drawing.Point(953, 802);
            this.lblPageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(191, 26);
            this.lblPageInfo.TabIndex = 12;
            this.lblPageInfo.Text = "Halaman 1 dari 2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.annual_calender_day_schedule_date_time_calendar_icon_256474;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(44, 718);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 58);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.business_cash_coin_dollar_finance_money_payment_icon_123244;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(44, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 56);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.add_112353;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(44, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 60);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1047, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 51);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hanin Laundry";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.laundry;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(519, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 53);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // FormPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1200, 1050);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatusPengerjaan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRiwayatBayar);
            this.Controls.Add(this.btnBayarPesanan);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.btnTambahPesanan);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanin Laundry";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTambahPesanan;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Button btnBayarPesanan;
        private System.Windows.Forms.Button btnRiwayatBayar;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ComboBox cbStatusPengerjaan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

