namespace Bismillah_Hanin
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUangDiterima
            // 
            this.tbUangDiterima.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUangDiterima.Location = new System.Drawing.Point(42, 620);
            this.tbUangDiterima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUangDiterima.Name = "tbUangDiterima";
            this.tbUangDiterima.Size = new System.Drawing.Size(265, 35);
            this.tbUangDiterima.TabIndex = 1;
            // 
            // btnBayar
            // 
            this.btnBayar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Location = new System.Drawing.Point(377, 596);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(213, 64);
            this.btnBayar.TabIndex = 9;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.AllowUserToAddRows = false;
            this.dgvPesanan.AllowUserToDeleteRows = false;
            this.dgvPesanan.AllowUserToOrderColumns = true;
            this.dgvPesanan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(42, 85);
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 586);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Uang Diterima";
            // 
            // FormBayarPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(638, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.tbUangDiterima);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBayarPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBayarPesanan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUangDiterima;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label label1;
    }
}