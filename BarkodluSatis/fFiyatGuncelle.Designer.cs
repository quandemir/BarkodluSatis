namespace BarkodluSatis
{
    partial class fFiyatGuncelle
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
            this.tBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bExcelKaydet = new System.Windows.Forms.Button();
            this.lBarkod = new System.Windows.Forms.Label();
            this.lUrunAd = new System.Windows.Forms.Label();
            this.lFiyat = new System.Windows.Forms.Label();
            this.tYeniFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBarkod
            // 
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBarkod.Location = new System.Drawing.Point(21, 41);
            this.tBarkod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(216, 26);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.TextChanged += new System.EventHandler(this.tBarkod_TextChanged);
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Barkod Okutunuz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(26, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fiyatı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürün Adı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(25, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Barkod";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.bKaydet.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.bKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.Color.White;
            this.bKaydet.Location = new System.Drawing.Point(146, 256);
            this.bKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(91, 61);
            this.bKaydet.TabIndex = 46;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bExcelKaydet
            // 
            this.bExcelKaydet.BackColor = System.Drawing.Color.DarkCyan;
            this.bExcelKaydet.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.bExcelKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExcelKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bExcelKaydet.ForeColor = System.Drawing.Color.White;
            this.bExcelKaydet.Location = new System.Drawing.Point(21, 256);
            this.bExcelKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bExcelKaydet.Name = "bExcelKaydet";
            this.bExcelKaydet.Size = new System.Drawing.Size(91, 61);
            this.bExcelKaydet.TabIndex = 47;
            this.bExcelKaydet.Text = "Excel ile Güncelle";
            this.bExcelKaydet.UseVisualStyleBackColor = false;
            // 
            // lBarkod
            // 
            this.lBarkod.AutoSize = true;
            this.lBarkod.BackColor = System.Drawing.Color.Transparent;
            this.lBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBarkod.ForeColor = System.Drawing.Color.SteelBlue;
            this.lBarkod.Location = new System.Drawing.Point(114, 89);
            this.lBarkod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBarkod.Name = "lBarkod";
            this.lBarkod.Size = new System.Drawing.Size(0, 20);
            this.lBarkod.TabIndex = 50;
            this.lBarkod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lUrunAd
            // 
            this.lUrunAd.AutoSize = true;
            this.lUrunAd.BackColor = System.Drawing.Color.Transparent;
            this.lUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lUrunAd.ForeColor = System.Drawing.Color.SteelBlue;
            this.lUrunAd.Location = new System.Drawing.Point(114, 119);
            this.lUrunAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUrunAd.Name = "lUrunAd";
            this.lUrunAd.Size = new System.Drawing.Size(0, 20);
            this.lUrunAd.TabIndex = 49;
            this.lUrunAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFiyat
            // 
            this.lFiyat.AutoSize = true;
            this.lFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lFiyat.ForeColor = System.Drawing.Color.SteelBlue;
            this.lFiyat.Location = new System.Drawing.Point(115, 147);
            this.lFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFiyat.Name = "lFiyat";
            this.lFiyat.Size = new System.Drawing.Size(0, 20);
            this.lFiyat.TabIndex = 48;
            this.lFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tYeniFiyat
            // 
            this.tYeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tYeniFiyat.Location = new System.Drawing.Point(21, 211);
            this.tYeniFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tYeniFiyat.Name = "tYeniFiyat";
            this.tYeniFiyat.Size = new System.Drawing.Size(216, 26);
            this.tYeniFiyat.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(22, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Yeni Fiyat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fFiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(263, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tYeniFiyat);
            this.Controls.Add(this.lBarkod);
            this.Controls.Add(this.lUrunAd);
            this.Controls.Add(this.lFiyat);
            this.Controls.Add(this.bExcelKaydet);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBarkod);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(279, 385);
            this.MinimumSize = new System.Drawing.Size(279, 385);
            this.Name = "fFiyatGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Fiyat İncele";
            this.Load += new System.EventHandler(this.fFiyatGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bExcelKaydet;
        private System.Windows.Forms.Label lBarkod;
        private System.Windows.Forms.Label lUrunAd;
        private System.Windows.Forms.Label lFiyat;
        public System.Windows.Forms.TextBox tYeniFiyat;
        private System.Windows.Forms.Label label5;
    }
}