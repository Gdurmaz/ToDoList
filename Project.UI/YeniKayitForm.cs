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
    public partial class YeniKayitForm : Form
    {
        private Core.BusinessServices.ToDoServices toDoServices;
        private Form form;
        public YeniKayitForm()
        {
            InitializeComponent();
            toDoServices = new Core.BusinessServices.ToDoServices();
        }
        private void tbBaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }
        private void tbBaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBaslik.Text) && !string.IsNullOrEmpty(tbOzet.Text) 
                &&!string.IsNullOrEmpty(tbAciklama.Text)&&!string.IsNullOrEmpty(tbOnemDerecesi.Text)) {

                int result =toDoServices.Insert(new Core.Entities.ToDo()
                {
                    ID = Guid.NewGuid(),
                    Title = tbBaslik.Text,
                    Summary = tbOzet.Text,
                    Description = tbAciklama.Text,
                    ImportanceLevel = Convert.ToInt32(tbOnemDerecesi.Text),
                    Status = cmbDurum.SelectedItem.ToString(),
                    CreationDate = DateTime.Now,
                });
                if (result>0)
                {
                    MessageBox.Show("Kayıt eklendi");
                    DialogResult dialog = MessageBox.Show("Yeni Kayıt eklemek ister misiniz ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        foreach (var item in this.Controls)
                        {
                            if (item is TextBox )
                            {
                                (item as TextBox).Text =string.Empty;
                            }
                        }
                    }
                    else
                    {
                        if (form == Application.OpenForms["KayitListeForm"])
                        {
                            form = new KayitListeForm();
                            form.MdiParent = Application.OpenForms["AnaForm"];
                            form.StartPosition = FormStartPosition.CenterScreen;
                            form.Show();
                            this.Close();
                        }
                        else
                        {
                            Panel pnlbody = (Panel)form.Controls["pnlBody"];
                            DataGridView dgvData=(DataGridView)pnlbody.Controls["dgvData"];
                            dgvData.DataSource = null;
                            dgvData.DataSource = toDoServices.Select();
                            this.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Kayıt eklenmedi");
                }
            }
        }
    }
}
