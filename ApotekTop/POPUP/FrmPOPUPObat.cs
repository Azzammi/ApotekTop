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
    public partial class FrmPOPUPObat : Form
    {
        CRUD crud = new CRUD();
        string namaForm;
        public string kdObat, merek, nmObat, hrgObat;
        DateTime dateTime;  
        public FrmPOPUPObat()
        {
            InitializeComponent();
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }
        public string NamaForm
        {
            get { return this.namaForm; }
            set { this.namaForm = value; }
        }
        
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            crud.Dt = crud.Select("tbl_obat", "*");
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = crud.Dt;
            SetDataGrid setGrid = new SetDataGrid();
            setGrid.CreateHeader(dataGridView1, 11, "ID Obat, Merek, Nama, Kategori, Tipe, Satuan Stock, Satuan Jual, Harga Pokok , Harga Jual, Margin Jual, Resep, Keterangan", "100,150,150,150,170,150,150,100,50,100,100,200");
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {                
                if (namaForm == "FrmStock")
                {
                    FrmStock stock = new FrmStock();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        stock.kdObatTxt.Text = row.Cells[0].Value.ToString();
                        stock.merekTxt.Text = row.Cells[1].Value.ToString();
                        stock.nmObatTxt.Text = row.Cells[2].Value.ToString();
                    }
                    stock.Dispose();
                    this.Close();
                }
                
                else if (namaForm == "FrmPembelian")
                {
                   
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (namaForm == "FrmStock")
            {
                FrmStock stock = new FrmStock();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    kdObat = row.Cells[0].Value.ToString();
                    merek = row.Cells[1].Value.ToString();
                    nmObat = row.Cells[2].Value.ToString();
                }
                stock.Dispose();
                this.Close();
            }
            else if (namaForm == "FrmPenjualan" || namaForm == "FrmPembelian")
            {                
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    kdObat = row.Cells[0].Value.ToString();
                    merek = row.Cells[1].Value.ToString();
                    nmObat = row.Cells[2].Value.ToString();
                    hrgObat = row.Cells[8].Value.ToString();                   
                }
                
                this.Close();
            }            
        }
    }
}
