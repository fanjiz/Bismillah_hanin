namespace Bismillah_Hanin
{
    partial class FormTambahPesanan
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
            this.tbNohp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamaplg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLayanan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnSimpanPesanan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNohp
            // 
            this.tbNohp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNohp.Location = new System.Drawing.Point(175, 77);
            this.tbNohp.Name = "tbNohp";
            this.tbNohp.Size = new System.Drawing.Size(178, 26);
            this.tbNohp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomor Hp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Pelanggan";
            // 
            // tbNamaplg
            // 
            this.tbNamaplg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaplg.Location = new System.Drawing.Point(175, 118);
            this.tbNamaplg.Name = "tbNamaplg";
            this.tbNamaplg.Size = new System.Drawing.Size(178, 26);
            this.tbNamaplg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pilih Layanan";
            // 
            // cbLayanan
            // 
            this.cbLayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLayanan.FormattingEnabled = true;
            this.cbLayanan.Location = new System.Drawing.Point(175, 180);
            this.cbLayanan.Name = "cbLayanan";
            this.cbLayanan.Size = new System.Drawing.Size(178, 28);
            this.cbLayanan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jumlah";
            // 
            // tbJumlah
            // 
            this.tbJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlah.Location = new System.Drawing.Point(175, 219);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(178, 26);
            this.tbJumlah.TabIndex = 7;
            // 
            // btnBayar
            // 
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Location = new System.Drawing.Point(200, 295);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(153, 48);
            this.btnBayar.TabIndex = 8;
            this.btnBayar.Text = "Bayar Sekarang";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnSimpanPesanan
            // 
            this.btnSimpanPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanPesanan.Location = new System.Drawing.Point(25, 295);
            this.btnSimpanPesanan.Name = "btnSimpanPesanan";
            this.btnSimpanPesanan.Size = new System.Drawing.Size(153, 48);
            this.btnSimpanPesanan.TabIndex = 9;
            this.btnSimpanPesanan.Text = "Simpan Pesanan";
            this.btnSimpanPesanan.UseVisualStyleBackColor = true;
            this.btnSimpanPesanan.Click += new System.EventHandler(this.btnSimpanPesanan_Click);
            // 
            // FormTambahPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 385);
            this.Controls.Add(this.btnSimpanPesanan);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLayanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNamaplg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNohp);
            this.Name = "FormTambahPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahPesanan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNohp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamaplg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLayanan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnSimpanPesanan;
    }
}