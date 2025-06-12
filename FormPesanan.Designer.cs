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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambahPesanan
            // 
            this.btnTambahPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPesanan.Location = new System.Drawing.Point(12, 90);
            this.btnTambahPesanan.Name = "btnTambahPesanan";
            this.btnTambahPesanan.Size = new System.Drawing.Size(201, 54);
            this.btnTambahPesanan.TabIndex = 0;
            this.btnTambahPesanan.Text = "Tambah Pesanan";
            this.btnTambahPesanan.UseVisualStyleBackColor = true;
            this.btnTambahPesanan.Click += new System.EventHandler(this.btnTambahPesanan_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.AllowUserToAddRows = false;
            this.dgvPesanan.AllowUserToDeleteRows = false;
            this.dgvPesanan.AllowUserToOrderColumns = true;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(253, 90);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.ReadOnly = true;
            this.dgvPesanan.Size = new System.Drawing.Size(520, 294);
            this.dgvPesanan.TabIndex = 1;
            this.dgvPesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellClick);
            // 
            // btnBayarPesanan
            // 
            this.btnBayarPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayarPesanan.Location = new System.Drawing.Point(12, 163);
            this.btnBayarPesanan.Name = "btnBayarPesanan";
            this.btnBayarPesanan.Size = new System.Drawing.Size(201, 54);
            this.btnBayarPesanan.TabIndex = 2;
            this.btnBayarPesanan.Text = "Bayar Pesanan";
            this.btnBayarPesanan.UseVisualStyleBackColor = true;
            this.btnBayarPesanan.Click += new System.EventHandler(this.btnBayarPesanan_Click);
            // 
            // btnRiwayatBayar
            // 
            this.btnRiwayatBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayatBayar.Location = new System.Drawing.Point(12, 330);
            this.btnRiwayatBayar.Name = "btnRiwayatBayar";
            this.btnRiwayatBayar.Size = new System.Drawing.Size(201, 54);
            this.btnRiwayatBayar.TabIndex = 3;
            this.btnRiwayatBayar.Text = "Riwayat Pembayaran";
            this.btnRiwayatBayar.UseVisualStyleBackColor = true;
            this.btnRiwayatBayar.Click += new System.EventHandler(this.btnRiwayatBayar_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(665, 479);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(108, 43);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // cbStatusPengerjaan
            // 
            this.cbStatusPengerjaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusPengerjaan.FormattingEnabled = true;
            this.cbStatusPengerjaan.Location = new System.Drawing.Point(253, 494);
            this.cbStatusPengerjaan.Name = "cbStatusPengerjaan";
            this.cbStatusPengerjaan.Size = new System.Drawing.Size(176, 28);
            this.cbStatusPengerjaan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status Pengerjaan";
            // 
            // btnSimpan
            // 
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(435, 479);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(108, 43);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(524, 45);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(173, 26);
            this.tbCari.TabIndex = 8;
            // 
            // btnCari
            // 
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(703, 37);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(70, 43);
            this.btnCari.TabIndex = 9;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(329, 390);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 43);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(253, 390);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 43);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.Location = new System.Drawing.Point(644, 401);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(129, 20);
            this.lblPageInfo.TabIndex = 12;
            this.lblPageInfo.Text = "Halaman 1 dari 2";
            // 
            // FormPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
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
            this.Name = "FormPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanin Laundry";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
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
    }
}

