namespace Project.UI
{
    partial class KayitListeForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnIptalEdildi = new System.Windows.Forms.Button();
            this.btnTamamlanmadı = new System.Windows.Forms.Button();
            this.btnTamamlandı = new System.Windows.Forms.Button();
            this.btnTablo = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlLeft.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnIptalEdildi);
            this.pnlLeft.Controls.Add(this.btnTamamlanmadı);
            this.pnlLeft.Controls.Add(this.btnTamamlandı);
            this.pnlLeft.Controls.Add(this.btnTablo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 389);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnIptalEdildi
            // 
            this.btnIptalEdildi.Location = new System.Drawing.Point(12, 188);
            this.btnIptalEdildi.Name = "btnIptalEdildi";
            this.btnIptalEdildi.Size = new System.Drawing.Size(171, 33);
            this.btnIptalEdildi.TabIndex = 0;
            this.btnIptalEdildi.Text = "Iptal Edildi";
            this.btnIptalEdildi.UseVisualStyleBackColor = true;
            this.btnIptalEdildi.Click += new System.EventHandler(this.btnIptalEdildi_Click);
            // 
            // btnTamamlanmadı
            // 
            this.btnTamamlanmadı.Location = new System.Drawing.Point(12, 135);
            this.btnTamamlanmadı.Name = "btnTamamlanmadı";
            this.btnTamamlanmadı.Size = new System.Drawing.Size(171, 33);
            this.btnTamamlanmadı.TabIndex = 0;
            this.btnTamamlanmadı.Text = "Tamamlanmadı";
            this.btnTamamlanmadı.UseVisualStyleBackColor = true;
            this.btnTamamlanmadı.Click += new System.EventHandler(this.btnTamamlanmadı_Click);
            // 
            // btnTamamlandı
            // 
            this.btnTamamlandı.Location = new System.Drawing.Point(12, 87);
            this.btnTamamlandı.Name = "btnTamamlandı";
            this.btnTamamlandı.Size = new System.Drawing.Size(171, 33);
            this.btnTamamlandı.TabIndex = 0;
            this.btnTamamlandı.Text = "Tamamlandı";
            this.btnTamamlandı.UseVisualStyleBackColor = true;
            this.btnTamamlandı.Click += new System.EventHandler(this.btnTamamlandı_Click);
            // 
            // btnTablo
            // 
            this.btnTablo.Location = new System.Drawing.Point(12, 39);
            this.btnTablo.Name = "btnTablo";
            this.btnTablo.Size = new System.Drawing.Size(171, 33);
            this.btnTablo.TabIndex = 0;
            this.btnTablo.Text = "Tüm Tablo";
            this.btnTablo.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvData);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(200, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(770, 389);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(770, 389);
            this.dgvData.TabIndex = 0;
            // 
            // KayitListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 389);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayitListeForm";
            this.ShowIcon = false;
            this.Text = "KayitListeForm";
            this.Load += new System.EventHandler(this.KayitListeForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnIptalEdildi;
        private System.Windows.Forms.Button btnTamamlanmadı;
        private System.Windows.Forms.Button btnTamamlandı;
        private System.Windows.Forms.Button btnTablo;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvData;
    }
}