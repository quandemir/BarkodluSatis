namespace BarkodluSatis
{
    partial class fUrunGrubuEkle
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
            this.tUrunGrupAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.bSil = new System.Windows.Forms.Button();
            this.bUrunGrubuEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tUrunGrupAdi
            // 
            this.tUrunGrupAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunGrupAdi.Location = new System.Drawing.Point(12, 46);
            this.tUrunGrupAdi.Name = "tUrunGrupAdi";
            this.tUrunGrupAdi.Size = new System.Drawing.Size(249, 26);
            this.tUrunGrupAdi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ürün Grubu Adı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.Location = new System.Drawing.Point(12, 78);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(249, 160);
            this.listUrunGrup.TabIndex = 14;
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.Coral;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSil.Image = global::BarkodluSatis.Properties.Resources.cancel241;
            this.bSil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bSil.Location = new System.Drawing.Point(12, 244);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(123, 78);
            this.bSil.TabIndex = 22;
            this.bSil.Text = "Sil";
            this.bSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bUrunGrubuEkle
            // 
            this.bUrunGrubuEkle.BackColor = System.Drawing.Color.IndianRed;
            this.bUrunGrubuEkle.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.bUrunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGrubuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGrubuEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bUrunGrubuEkle.Image = global::BarkodluSatis.Properties.Resources.Ekle20;
            this.bUrunGrubuEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bUrunGrubuEkle.Location = new System.Drawing.Point(141, 244);
            this.bUrunGrubuEkle.Name = "bUrunGrubuEkle";
            this.bUrunGrubuEkle.Size = new System.Drawing.Size(120, 78);
            this.bUrunGrubuEkle.TabIndex = 21;
            this.bUrunGrubuEkle.Text = "Ekle";
            this.bUrunGrubuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bUrunGrubuEkle.UseVisualStyleBackColor = false;
            this.bUrunGrubuEkle.Click += new System.EventHandler(this.bUrunGrubuEkle_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 336);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bUrunGrubuEkle);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.tUrunGrupAdi);
            this.Controls.Add(this.label6);
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUrunGrupAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listUrunGrup;
        private System.Windows.Forms.Button bUrunGrubuEkle;
        private System.Windows.Forms.Button bSil;
    }
}