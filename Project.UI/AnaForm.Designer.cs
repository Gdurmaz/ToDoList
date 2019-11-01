namespace Project.UI
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.pnlSolEkran = new System.Windows.Forms.Panel();
            this.panelButon = new System.Windows.Forms.Panel();
            this.btnUygulamaKapat = new System.Windows.Forms.Button();
            this.btnKayitListele = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelZaman = new System.Windows.Forms.Panel();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tmrZamanAyarla = new System.Windows.Forms.Timer(this.components);
            this.pnlSolEkran.SuspendLayout();
            this.panelButon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelZaman.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSolEkran
            // 
            this.pnlSolEkran.Controls.Add(this.panelButon);
            this.pnlSolEkran.Controls.Add(this.pictureBox1);
            this.pnlSolEkran.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolEkran.Location = new System.Drawing.Point(0, 0);
            this.pnlSolEkran.Name = "pnlSolEkran";
            this.pnlSolEkran.Size = new System.Drawing.Size(161, 450);
            this.pnlSolEkran.TabIndex = 1;
            // 
            // panelButon
            // 
            this.panelButon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButon.Controls.Add(this.btnUygulamaKapat);
            this.panelButon.Controls.Add(this.btnKayitListele);
            this.panelButon.Controls.Add(this.btnYeniKayit);
            this.panelButon.Location = new System.Drawing.Point(14, 155);
            this.panelButon.Name = "panelButon";
            this.panelButon.Size = new System.Drawing.Size(128, 145);
            this.panelButon.TabIndex = 1;
            // 
            // btnUygulamaKapat
            // 
            this.btnUygulamaKapat.Location = new System.Drawing.Point(12, 93);
            this.btnUygulamaKapat.Name = "btnUygulamaKapat";
            this.btnUygulamaKapat.Size = new System.Drawing.Size(103, 33);
            this.btnUygulamaKapat.TabIndex = 0;
            this.btnUygulamaKapat.Text = "Uygulama Kapat";
            this.btnUygulamaKapat.UseVisualStyleBackColor = true;
            this.btnUygulamaKapat.Click += new System.EventHandler(this.btnUygulamaKapat_Click);
            // 
            // btnKayitListele
            // 
            this.btnKayitListele.Location = new System.Drawing.Point(12, 54);
            this.btnKayitListele.Name = "btnKayitListele";
            this.btnKayitListele.Size = new System.Drawing.Size(103, 33);
            this.btnKayitListele.TabIndex = 0;
            this.btnKayitListele.Text = "Kayıt Listele";
            this.btnKayitListele.UseVisualStyleBackColor = true;
            this.btnKayitListele.Click += new System.EventHandler(this.btnKayitListele_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(12, 15);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(103, 33);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelZaman
            // 
            this.panelZaman.Controls.Add(this.lblZaman);
            this.panelZaman.Location = new System.Drawing.Point(833, 376);
            this.panelZaman.Name = "panelZaman";
            this.panelZaman.Size = new System.Drawing.Size(260, 72);
            this.panelZaman.TabIndex = 2;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(13, 23);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(66, 24);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "label1";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.panelZaman);
            this.Controls.Add(this.pnlSolEkran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSolEkran.ResumeLayout(false);
            this.pnlSolEkran.PerformLayout();
            this.panelButon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelZaman.ResumeLayout(false);
            this.panelZaman.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSolEkran;
        private System.Windows.Forms.Panel panelButon;
        private System.Windows.Forms.Button btnUygulamaKapat;
        private System.Windows.Forms.Button btnKayitListele;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelZaman;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tmrZamanAyarla;
    }
}

