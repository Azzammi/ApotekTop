using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekTop
{
    public partial class FrmKategori_List : Form
    {
        string valueFromDG;
        CRUD crud = new CRUD();
        public FrmKategori_List()
        {
            InitializeComponent();
            recordLoad();
        }

        private void recordLoad()
        {            
            dataGridView1.DataSource = crud.Select("tbl_kategori", "*");
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            using (FrmKategori kategoriForm = new FrmKategori())
            {
                kategoriForm.IsEdit = false;
                kategoriForm.ShowDialog();
            }
            recordLoad();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            recordLoad();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (FrmKategori kategoriForm = new FrmKategori())
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    kategoriForm.PrimaryKey = row.Cells[0].Value.ToString();
                    kategoriForm.kategoriTxt.Text = row.Cells[1].Value.ToString();
                    kategoriForm.IsEdit = true;
                }
                kategoriForm.ShowDialog();
            }
            recordLoad();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus  ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    valueFromDG += row.Cells[0].Value + ",";
                }
                string[] valuesDG = valueFromDG.Split(',');
                for (byte i = 0; i < valuesDG.Count(); i++)
                {
                    crud.Delete("tbl_kategori", "id = '" + valuesDG[i] + "'");
                }

                MessageBox.Show(valueFromDG);
                valueFromDG = null;
                recordLoad();
            }
        }
    }
}
