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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPembayaran
            // 
            this.dgvPembayaran.AllowUserToAddRows = false;
            this.dgvPembayaran.AllowUserToDeleteRows = false;
            this.dgvPembayaran.AllowUserToOrderColumns = true;
            this.dgvPembayaran.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembayaran.Location = new System.Drawing.Point(50, 129);
            this.dgvPembayaran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPembayaran.Name = "dgvPembayaran";
            this.dgvPembayaran.ReadOnly = true;
            this.dgvPembayaran.RowHeadersWidth = 62;
            this.dgvPembayaran.Size = new System.Drawing.Size(780, 452);
            this.dgvPembayaran.TabIndex = 2;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.Location = new System.Drawing.Point(636, 625);
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
            this.btnPrev.Location = new System.Drawing.Point(48, 608);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(105, 66);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(162, 608);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 66);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCari
            // 
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(724, 54);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(105, 66);
            this.btnCari.TabIndex = 17;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(456, 66);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(258, 35);
            this.tbCari.TabIndex = 16;
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(50, 717);
            this.btnCetak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(280, 68);
            this.btnCetak.TabIndex = 18;
            this.btnCetak.Text = "Cetak Laporan";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click_1);
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(890, 826);
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
            this.Text = "FormPembayaran";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembayaran)).EndInit();
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
    }
}