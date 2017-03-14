using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekTop.POPUP
{
    public partial class FrmPOPUPSupp : Form
    {
        CRUD crud = new CRUD();
        public string kdSupp, nama, kota, telepon;
        public FrmPOPUPSupp()
        {
            InitializeComponent();
            refreshBtn.PerformClick();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = crud.Select("tbl_supplier", "kd_supp, nm_supp, alamat_supp, kota_supp, telp_supp, email_supp, nm_kontak_supp");
            SetDataGrid setGrid = new SetDataGrid();
            setGrid.CreateHeader(dataGridView1,6,"Kode Supp, Nama Supp, Alamat, Kota, Telp, Email, CP","75,75,80,70,70,80,100");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                kdSupp = row.Cells[0].Value.ToString();
                nama = row.Cells[1].Value.ToString();
                kota = row.Cells[3].Value.ToString();
                telepon = row.Cells[4].Value.ToString();
            }
            this.Close();
        }
    }
}
