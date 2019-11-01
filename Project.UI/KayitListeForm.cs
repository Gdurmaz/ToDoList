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
    public partial class KayitListeForm : Form
    {
        Core.BusinessServices.ToDoServices toDoServices;
        public KayitListeForm()
        {
            InitializeComponent();
            toDoServices = new Core.BusinessServices.ToDoServices();
        }

        private void KayitListeForm_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = GetToDos();
            dgvData.Columns["ID"].Visible = false;
        }
        private List<Core.Entities.ToDo> GetToDos()
        {
            return toDoServices.Select();
        }

        private void btnTamamlandı_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = GetToDos().Where(I => I.Status == "Tamamlandı").ToList();
            dgvData.Columns["ID"].Visible = false;
        }

        private void btnTamamlanmadı_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = GetToDos().Where(I => I.Status == "Tamamlanmadı").ToList();
            dgvData.Columns["ID"].Visible = false;
        }

        private void btnIptalEdildi_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = GetToDos().Where(I => I.Status == "Iptal Edildi").ToList();
            dgvData.Columns["ID"].Visible = false;
        }
    }
}
