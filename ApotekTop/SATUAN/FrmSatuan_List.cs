using System;
using System.Linq;
using System.Windows.Forms;

namespace ApotekTop
{
    public partial class FrmSatuan_List : Form
    {       
        CRUD crud = new CRUD();
        string valueFromDG;
        public FrmSatuan_List()
        {
            InitializeComponent();
            recordLoad();
        }

        public void recordLoad()
        {
            SetDataGrid dgSet = new SetDataGrid();
            dataGridView1.DataSource =  crud.Select("tbl_satuan", "id_satuan, satuan");
           // dgSet.CreateHeader(dataGridView1, 0, "Satuan","200");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (FrmSatuan satuan = new FrmSatuan())
            {
                satuan.IsEdit = false;
                satuan.ShowDialog();
            }
            recordLoad();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (FrmSatuan satuan = new FrmSatuan())
            {
                satuan.IsEdit = true;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    satuan.PrimaryKey = row.Cells[0].Value.ToString();
                    satuan.NmSatuan = row.Cells[1].Value.ToString();
                }
                satuan.ShowDialog();
            }
            recordLoad();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            recordLoad();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {            
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus  ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(pesan == DialogResult.Yes)
            {                
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    valueFromDG += row.Cells[0].Value + ",";
                }
                string[] valuesDG = valueFromDG.Split(',');
                for(byte i = 0; i < valuesDG.Count(); i++)
                {
                     crud.Delete("tbl_satuan", "id_satuan = '" + valuesDG[i] + "'");
                }
               
                MessageBox.Show(valueFromDG);
                valueFromDG = null;                
                recordLoad();
            }
        }
    }
}
