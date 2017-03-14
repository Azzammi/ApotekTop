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
    public partial class FrmStock_List : Form
    {
        CRUD crud = new CRUD();
        string valueFromDG, idObat;

        
        public FrmStock_List()
        {
            InitializeComponent();
            RunBgWorker();
        }

        public void recordLoad()
        {
            crud.Dt = crud.Select("tbl_obat_stock", "no, id_obat, stock_utama, satuan_utama, stock_turunan, satuan_turunan, tgl_expired");
        }

        public void RunBgWorker()
        {
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
            loadingTS.Visible = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FrmStock frmStick = new FrmStock();
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                frmStick.PrimaryKey = row.Cells[0].Value.ToString();
                frmStick.kdObatTxt.Text = row.Cells[1].Value.ToString();                           
                frmStick.satuanUtamaTxt.Text = row.Cells[3].Value.ToString();
                frmStick.stockUtamaTxt.Text = row.Cells[2].Value.ToString();
                frmStick.satuanTurunanTxT.Text = row.Cells[5].Value.ToString();
                frmStick.stockTurunanTxt.Text = row.Cells[4].Value.ToString();
                DateTime dateValue;
                if (DateTime.TryParse(row.Cells[6].Value.ToString(), out dateValue))
                {
                    frmStick.expiredDT.Value = dateValue;
                    frmStick.IsKosong = false;
                }
                else
                {
                    frmStick.IsKosong = true;
                }                
            }
            frmStick.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus  ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    valueFromDG += row.Cells[0].Value + ",";
                    idObat += row.Cells[1].Value + ",";
                }
                string[] valuesDG = valueFromDG.Split(',');
                string[] idObats = idObat.Split(',');
                //int counter;   
                for (byte i = 0; i < valuesDG.Count(); i++)
                {
                    crud.Dt = crud.ExecuteQuery("SELECT id_obat FROM tbl_obat_stock WHERE id_obat = '" + idObats[i] + "'");
                    if (crud.Dt.Rows.Count == 1)
                    {
                        crud.Update("tbl_obat_stock", "stock_utama = '0', stock_turunan = '0'", "id_obat = '" + idObats[i] + "'");
                    }
                    else
                    {
                        crud.Delete("tbl_obat_stock", "no = '" + valuesDG[i] + "'");
                    }
                }
                MessageBox.Show(valueFromDG);
                valueFromDG = null;
                recordLoad();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RunBgWorker();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
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
                //Memperbarui reportProgress
                bgWorker.ReportProgress(i, status);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBars.Value = e.ProgressPercentage;
            this.percentageLbl.Text = e.ProgressPercentage.ToString();
            this.processLbl.Text = e.UserState.ToString();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingTS.Visible = false;
            dataGridView1.DataSource = crud.Dt;
            SetDataGrid setGrid = new SetDataGrid();
            setGrid.CreateHeader(dataGridView1, 6, "No, Kode Obat, Stock, Satuan, Stock Turunan, Satuan, EXPIRED", "10, 150, 75, 60, 75, 60, 100");
        }        
    }
}
