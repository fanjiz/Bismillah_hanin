﻿namespace Bismillah_Hanin
{
    partial class FormBayarPesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBayarPesanan));
            this.tbUangDiterima = new System.Windows.Forms.TextBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUangDiterima
            // 
            this.tbUangDiterima.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUangDiterima.Location = new System.Drawing.Point(83, 641);
            this.tbUangDiterima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUangDiterima.Name = "tbUangDiterima";
            this.tbUangDiterima.Size = new System.Drawing.Size(265, 35);
            this.tbUangDiterima.TabIndex = 1;
            this.tbUangDiterima.Tag = "Rp";
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.Lime;
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Location = new System.Drawing.Point(356, 641);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(113, 38);
            this.btnBayar.TabIndex = 9;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.AllowUserToAddRows = false;
            this.dgvPesanan.AllowUserToDeleteRows = false;
            this.dgvPesanan.AllowUserToOrderColumns = true;
            this.dgvPesanan.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(84, 145);
            this.dgvPesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.ReadOnly = true;
            this.dgvPesanan.RowHeadersWidth = 62;
            this.dgvPesanan.Size = new System.Drawing.Size(548, 452);
            this.dgvPesanan.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 610);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Uang Diterima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 51);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hanin Laundry";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Bismillah_Hanin.Properties.Resources.laundry;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(173, 57);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 53);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 681);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Masukkan nominal uang yang diterima";
            // 
            // FormBayarPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::Bismillah_Hanin.Properties.Resources._6874268;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.tbUangDiterima);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBayarPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bayar Pesanan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUangDiterima;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
    }
}