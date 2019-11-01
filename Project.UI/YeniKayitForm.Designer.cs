namespace Project.UI
{
    partial class YeniKayitForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.tbOnemDerecesi = new System.Windows.Forms.TextBox();
            this.tbOzet = new System.Windows.Forms.TextBox();
            this.tbBaslik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.cmbDurum);
            this.panel1.Controls.Add(this.tbAciklama);
            this.panel1.Controls.Add(this.tbOnemDerecesi);
            this.panel1.Controls.Add(this.tbOzet);
            this.panel1.Controls.Add(this.tbBaslik);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 374);
            this.panel1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(20, 325);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(166, 28);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Tamamlandı",
            "Tamamlanmadı",
            "Beklemede",
            "İptal Edildi",
            "Ertelendi"});
            this.cmbDurum.Location = new System.Drawing.Point(122, 278);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(203, 21);
            this.cmbDurum.TabIndex = 2;
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(122, 127);
            this.tbAciklama.Multiline = true;
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(203, 100);
            this.tbAciklama.TabIndex = 1;
            this.tbAciklama.Enter += new System.EventHandler(this.tbBaslik_Enter);
            this.tbAciklama.Leave += new System.EventHandler(this.tbBaslik_Leave);
            // 
            // tbOnemDerecesi
            // 
            this.tbOnemDerecesi.Location = new System.Drawing.Point(122, 243);
            this.tbOnemDerecesi.Name = "tbOnemDerecesi";
            this.tbOnemDerecesi.Size = new System.Drawing.Size(64, 20);
            this.tbOnemDerecesi.TabIndex = 1;
            this.tbOnemDerecesi.Enter += new System.EventHandler(this.tbBaslik_Enter);
            this.tbOnemDerecesi.Leave += new System.EventHandler(this.tbBaslik_Leave);
            // 
            // tbOzet
            // 
            this.tbOzet.Location = new System.Drawing.Point(122, 64);
            this.tbOzet.Multiline = true;
            this.tbOzet.Name = "tbOzet";
            this.tbOzet.Size = new System.Drawing.Size(181, 39);
            this.tbOzet.TabIndex = 1;
            this.tbOzet.Enter += new System.EventHandler(this.tbBaslik_Enter);
            this.tbOzet.Leave += new System.EventHandler(this.tbBaslik_Leave);
            // 
            // tbBaslik
            // 
            this.tbBaslik.Location = new System.Drawing.Point(122, 32);
            this.tbBaslik.Name = "tbBaslik";
            this.tbBaslik.Size = new System.Drawing.Size(181, 20);
            this.tbBaslik.TabIndex = 1;
            this.tbBaslik.Enter += new System.EventHandler(this.tbBaslik_Enter);
            this.tbBaslik.Leave += new System.EventHandler(this.tbBaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Özet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // YeniKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 374);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YeniKayitForm";
            this.Text = "ToDo - YeniKayitForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.TextBox tbOnemDerecesi;
        private System.Windows.Forms.TextBox tbOzet;
        private System.Windows.Forms.TextBox tbBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbDurum;
    }
}