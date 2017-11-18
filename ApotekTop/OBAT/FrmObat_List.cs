using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ApotekTop
{
    public partial class FrmObat_List : Form
    {
        CRUD crud = new CRUD();      
        public FrmObat_List()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
            BgWorkerDoWork();
        }
        public void BgWorkerDoWork()
        {
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
            loadingTS.Visible = true;
        }
        public void recordLoad()
        {
            crud.Dt = crud.Select("tbl_obat", "*");           
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (FrmObat obat = new FrmObat())
            {
                obat.IsEdit = false;
                obat.ShowDialog();
            }
            BgWorkerDoWork();     
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus  ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {              
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    crud.Dt = crud.ExecuteQuery("SELECT distinct stock_utama, stock_turunan FROM tbl_obat_stock WHERE id_obat = '" + row.Cells[0].Value.ToString() + "' ORDER BY tgl_expired ASC");
                    if (crud.Dt.Rows.Count > 0)
                    {
                        decimal stockUtama =Convert.ToDecimal(crud.Dt.Rows[0]["stock_utama"]);
                        decimal stockTurunan = Convert.ToDecimal(crud.Dt.Rows[0]["stock_turunan"]);
                        if (stockUtama == 0 && stockTurunan == 0)
                        {
                            crud.Delete("tbl_obat", "id_obat ='" + row.Cells[0].Value.ToString() + "'");
                            crud.Delete("tbl_konversi", "id_item ='" + row.Cells[0].Value.ToString() + "'");
                            crud.Delete("tbl_obat_stock", "id_obat ='" + row.Cells[0].Value.ToString() + "'");
                            // MessageBox.Show(crud.Dt.Rows[0]["stock_utama"].ToString() + crud.Dt.Rows[0]["stock_turunan"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Terdapat Stock Dalam Tabel, Pastikan Stock sudah kosong !", "Error Penghapusan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                                                                                                                         
                }                
                BgWorkerDoWork();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            BgWorkerDoWork();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (FrmObat obat = new FrmObat())
            {
                obat.IsEdit = true;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    obat.PrimaryKey = row.Cells[0].Value.ToString();
                    obat.merekTxt.Text = row.Cells[1].Value.ToString();
                    obat.nmObatTxt.Text = row.Cells[2].Value.ToString();
                    obat.kategoriCBX.Text = row.Cells[3].Value.ToString();
                    obat.tipeCBX.Text = row.Cells[4].Value.ToString();
                    obat.satuanStockCBX.Text = row.Cells[5].Value.ToString();
                    obat.satuanJualCBX.Text = row.Cells[6].Value.ToString();
                    obat.hargaPokokTxt.Value = Convert.ToDecimal(row.Cells[7].Value);
                    obat.hargaJualTxt.Value = Convert.ToDecimal(row.Cells[8].Value);
                    obat.marginTxt.Value = Convert.ToDecimal(row.Cells[9].Value);
                    if (row.Cells[10].Value.ToString() == "1")
                    {
                        obat.statusResepCBX.Text = "Ya";
                    }
                    else
                    {
                        obat.statusResepCBX.Text = "Tidak";
                    }
                    obat.keteranganTXT.Text = row.Cells[11].Value.ToString();
                    obat.selisihTXT.Text = "";
                }
                obat.ShowDialog();
            }
            BgWorkerDoWork();
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            for (int i = 0; i <= 100; i++)
            {
                string status = "";
                System.Threading.Thread.Sleep(10);
                if (i >= 1 && i < 50)
                {
                    status = "Initializing";
                }
                else if (i == 50)
                {
                    System.Threading.Thread.Sleep(0);
                }
                else if (i >= 50 && i < 100)
                {
                    status = "Membaca data dari database";
                    recordLoad();                    
                }
                
                bgWorker.ReportProgress(i, status);                
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = crud.Dt;
            SetDataGrid setGrid = new SetDataGrid();
            setGrid.CreateHeader(dataGridView1, 11, "ID Obat, Merek, Nama, Kategori, Tipe, Satuan Stock, Satuan Jual, Harga Pokok , Harga Jual, Margin Jual, Resep, Keterangan", "100,150,150,150,170,96,96,100,100,100,100,200");
            this.loadingTS.Visible = false;

            dataGridView1.Columns[7].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "c";
        }

        private void bgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.progressBars.Value = e.ProgressPercentage;
            this.processLbl.Text = e.UserState.ToString();
            this.percentageLbl.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void FrmObat_List_Load(object sender, EventArgs e)
        {

        }
    }
}
