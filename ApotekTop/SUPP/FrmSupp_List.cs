using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekTop.SUPP
{
    public partial class FrmSupp_List : Form
    {
        CRUD crud = new CRUD();
        public FrmSupp_List()
        {
            InitializeComponent();
            refreshBtn.PerformClick();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using(FrmSupp supp = new FrmSupp())
            {
                supp.IsEdit = false;
                supp.ShowDialog();
            }
            refreshBtn.PerformClick();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (FrmSupp supp = new FrmSupp())
            {
                supp.IsEdit = true;
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    supp.PrimaryKey = row.Cells[0].Value.ToString();
                    supp.nmSuppTXT.Text = row.Cells[1].Value.ToString();
                    supp.alamatTXT.Text = row.Cells[2].Value.ToString();
                    supp.kotaTXT.Text = row.Cells[3].Value.ToString();
                    supp.teleponTXT.Text = row.Cells[4].Value.ToString();
                    supp.emailTXT.Text = row.Cells[5].Value.ToString();
                    supp.nmKontakTXT.Text = row.Cells[6].Value.ToString();                    
                }
                supp.ShowDialog();
            }
            refreshBtn.PerformClick();
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
                    crud.Dt = crud.Select("tbl_supplier", "kd_supp, nm_supp, alamat_supp, kota_supp, telp_supp, email_supp, nm_kontak_supp");
                }

                bgWorker.ReportProgress(i, status);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
            this.loadingTS.Visible = true;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBars.Value = e.ProgressPercentage;
            this.processLbl.Text = e.UserState.ToString();
            this.percentageLbl.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = crud.Dt;
            SetDataGrid setGrid = new SetDataGrid();
            setGrid.CreateHeader(dataGridView1, 6, "Kode Supp, Nama Supp, Alamat, Kota, Telepon, Email, Contact Person", "100,150,150,150,170,100,100");
            this.loadingTS.Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus  ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(pesan == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    crud.Delete("tbl_supplier", "kode_supp = '" + row.Cells[0].Value.ToString() + "'");
                }
            }
            refreshBtn.PerformClick();
        }
    }
}
