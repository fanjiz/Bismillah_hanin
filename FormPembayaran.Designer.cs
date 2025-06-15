namespace Bismillah_Hanin
{
    partial class FormPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembayaran));
            this.dgvPembayaran = new System.Windows.Forms.DataGridView();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.btnCetak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembayaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPembayaran
            // 
            this.dgvPembayaran.AllowUserToAddRows = false;
            this.dgvPembayaran.AllowUserToDeleteRows = false;
            this.dgvPembayaran.AllowUserToOrderColumns = true;
            this.dgvPembayaran.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembayaran.Location = new System.Drawing.Point(25, 114);
            this.dgvPembayaran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPembayaran.Name = "dgvPembayaran";
            this.dgvPembayaran.ReadOnly = true;
            this.dgvPembayaran.RowHeadersWidth = 62;
            this.dgvPembayaran.Size = new System.Drawing.Size(804, 452);
            this.dgvPembayaran.TabIndex = 2;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPageInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.Location = new System.Drawing.Point(638, 585);
            this.lblPageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(191, 26);
            this.lblPageInfo.TabIndex = 15;
            this.lblPageInfo.Text = "Halaman 1 dari 2";
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(25, 580);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(88, 37);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(130, 580);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 37);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCari
            // 
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(766, 69);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(63, 35);
            this.btnCari.TabIndex = 17;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(472, 69);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(258, 35);
            this.tbCari.TabIndex = 16;
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(85, 650);
            this.btnCetak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(175, 47);
            this.btnCetak.TabIndex = 18;
            this.btnCetak.Text = "Cetak Laporan";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 51);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hanin Laundry";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.laundry;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(25, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 53);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Bismillah_Hanin.Properties.Resources._2849806_copy_interface_multimedia_print_printer_107972;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(25, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 47);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.search__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(737, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::Bismillah_Hanin.Properties.Resources._6874268;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 750);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvPembayaran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembayaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPembayaran;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}