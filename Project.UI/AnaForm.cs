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
    public partial class AnaForm : Form
    {
        private Form form;
        private Core.BusinessServices.ToDoServices toDoServices;
        public AnaForm()
        {
            InitializeComponent();
            toDoServices = new Core.BusinessServices.ToDoServices();
        }
        public void ButtonOnOrOff(bool kontrol)
        {
            foreach (var item in panelButon.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrZamanAyarla.Interval=5000;
            tmrZamanAyarla.Tick += TmrZamanAyarla_Tick;
            tmrZamanAyarla.Start();
            ButtonOnOrOff(false);
            GirisForm form = new GirisForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
        }

        private void TmrZamanAyarla_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd:MM:yyyy hh:mm");
        }

        private void btnUygulamaKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["YeniKayitForm"] != null)
            {
                form = Application.OpenForms["YeniKayitForm"];
                form.Focus();
            }
            else
            {
                YeniKayitForm yeniKayit = new YeniKayitForm();
                yeniKayit.MdiParent = this;
                yeniKayit.Show();
            }
        }

        private void btnKayitListele_Click(object sender, EventArgs e)
        {
            if (toDoServices.Control()>0)
            {
                KayitListeForm form = new KayitListeForm();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Listenilecek kayıt yok");
            }
        }
    }
}
