using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class GirisForm : Form
    {
        Core.BusinessServices.UserServices userServices;
        public GirisForm()
        {
            InitializeComponent();
            userServices = new Core.BusinessServices.UserServices();
        }

        private void tbKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.Yellow;
        }

        private void tbKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKullaniciAdi.Text) && !string.IsNullOrEmpty(tbSifre.Text))
            {
                var result = userServices.Control(tbKullaniciAdi.Text, tbSifre.Text);
                if (result!=null)
                {
                    Form anaform = Application.OpenForms["AnaForm"];
                    Panel solPanel = (Panel)anaform.Controls["pnlSolEkran"];
                    Panel butonPanel = (Panel)solPanel.Controls["panelButon"];
                    foreach (var item in butonPanel.Controls)
                    {
                        if (item is Button)
                        {
                            ((Button)item).Enabled = true;
                        }
                    }
                    MessageBox.Show($"Hoşgeldiniz {result.Username},");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Sifre", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
