using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekTop.TRANSAKSI
{
    public partial class FrmPembelian : Form
    {
        CRUD crud = new CRUD();
        ClsControl setControl = new ClsControl();
        ClsUser user = new ClsUser();

        string id_pembelian, idMasuk, idStock, sql, satuan_utama, satuan_turunan;
        int stock_akhir;
        bool isKosong;

        public FrmPembelian()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
            noFakturTXT.Clear();
            Pengaturan();

            this.tipeCBX.Items.Add("CASH");
            this.tipeCBX.Items.Add("CREDIT");                             
        }

        private void setComponent()
        {            
            setControl.EmptyText(this);     
            kdSuppTXT.Focus();

            hargaBeliTXT.Value = 0;
            qtyTXT.Value = 0;
            diskonTXT.Value = 0;
            totalHargaTXT.Value = 0;

            satuanCMB.DataSource = crud.ExecuteQuery("SELECT satuan FROM tbl_satuan");
            satuanCMB.DisplayMember = "satuan";
        }

        private void Pengaturan()
        {
            //string date = DateTime.Now.ToShortDateString();

            setComponent();
            noFakturTXT.Focus();
            //noFakturTXT.Text = "B" + date.Replace("/", "") + setControl.GenerateNumber("tbl_detail_pembelian", "no_faktur");

            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }
        private void Hitung()
        {
            decimal totalBelanja = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                totalBelanja += Convert.ToDecimal(row.Cells[6].Value);
            }
            totalLbl.Text = string.Format(Cultures.Indonesia, "{0:#,##0}", double.Parse(totalBelanja.ToString()));
        }
        
        private void browseBtn_Click(object sender, EventArgs e)
        {
            using(POPUP.FrmPOPUPObat obat = new POPUP.FrmPOPUPObat())
            {
                obat.NamaForm = this.Name;
                obat.ShowDialog();
                kdObatTXT.Text = obat.kdObat;
                merekTXT.Text = obat.merek;
                nmObatTXT.Text = obat.nmObat;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(POPUP.FrmPOPUPSupp supp = new POPUP.FrmPOPUPSupp())
            {
                supp.ShowDialog();
                kdSuppTXT.Text = supp.kdSupp;
                nmSuppTXT.Text = supp.nama;                
            }
        }

        private void hargaBeliTXT_ValueChanged(object sender, EventArgs e)
        {
            totalHargaTXT.Value = hargaBeliTXT.Value;
            //sisaTXT.Value = 0 - totalHargaTXT.Value;
        }

        private void qtyTXT_ValueChanged(object sender, EventArgs e)
        {
            totalHargaTXT.Value = hargaBeliTXT.Value * qtyTXT.Value;
        }

        private void diskonTXT_ValueChanged(object sender, EventArgs e)
        {
            decimal diskon;
            diskon = (hargaBeliTXT.Value * qtyTXT.Value * diskonTXT.Value) / 100;
            totalHargaTXT.Value = hargaBeliTXT.Value * qtyTXT.Value + diskon;
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            if (kdSuppTXT.Text == "" || kdObatTXT.Text == "" || noFakturTXT.Text == "" || hargaBeliTXT.Value == 0 || qtyTXT.Value == 0 || totalHargaTXT.Value == 0)
            {
                MessageBox.Show("Isian Harus dilengkapi !");
            }
            else
            {
                crud.Dt = crud.ExecuteQuery("SELECT * FROM tbl_pembelian WHERE no_faktur = '" + noFakturTXT.Text + "'  AND kd_obat = '"  + kdObatTXT.Text + "'");
                //ssageBox.Show(crud.Dt.Rows.Count.ToString());
                if (crud.Dt.Rows.Count == 0)
                {
                    //tbl_pembelian
                    using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO tbl_pembelian (id_pembelian, no_faktur, tgl_pembelian, kd_supplier, kd_obat, satuan_stock, qty, harga_satuan, diskon, ppn, sub_total, tgl_expired, kasir, keterangan) VALUES " +
                                                                                    "(@id_pembelian,@noFaktur,@tgl_pembelian,@kd_supplier,@kd_obat,@satuan,@qty,@harga_satuan,@diskon,@ppn,@sub_total,@tgl_expired,@kasir,@keterangan)", crud.Koneksi))
                    {
                        crud.con_open();
                        crud.Perintah.Parameters.Clear();
                        crud.Perintah.Parameters.AddWithValue("@id_pembelian", "PB" + setControl.GenerateNumber("tbl_pembelian", "id_pembelian"));
                        crud.Perintah.Parameters.AddWithValue("@noFaktur", noFakturTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@tgl_pembelian", pembelianDt.Value.Date.ToString("yyyy-MM-dd"));
                        crud.Perintah.Parameters.AddWithValue("@kd_supplier", kdSuppTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@kd_obat", kdObatTXT.Text);
                        crud.Perintah.Parameters.AddWithValue("@satuan", satuanCMB.Text);
                        crud.Perintah.Parameters.AddWithValue("@qty", qtyTXT.Value);
                        crud.Perintah.Parameters.AddWithValue("@harga_satuan", hargaBeliTXT.Value);
                        crud.Perintah.Parameters.AddWithValue("@diskon", diskonTXT.Value);
                        crud.Perintah.Parameters.AddWithValue("@ppn", 0);
                        crud.Perintah.Parameters.AddWithValue("@sub_total", totalHargaTXT.Value);
                        crud.Perintah.Parameters.AddWithValue("@tgl_expired", expiredDT.Value.Date.ToString("yyyy-MM-dd"));
                        crud.Perintah.Parameters.AddWithValue("@kasir", user.UserName);
                        crud.Perintah.Parameters.AddWithValue("@keterangan", ketTXT.Text);
                        crud.Perintah.ExecuteNonQuery();

                        crud.con_close();
                    }
                    
                    if (crud.con_open()) //tbl_obat_masuk
                    {
                        using(crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO tbl_obat_masuk (id_masuk,id_obat,tgl_expired,tgl_transaksi,jam_masuk,stock_masuk,no_faktur) VALUES "+
                                                                                      "(@id_masuk,@id_obat,@tgl_expired,@tgl_transaksi,@jam_masuk,@stock_masuk,@no_faktur)", crud.Koneksi))
                        {
                            crud.Perintah.Parameters.Clear();
                            crud.Perintah.Parameters.AddWithValue("@id_masuk", "PO" + setControl.GenerateNumber("tbl_obat_masuk", "id_masuk"));
                            crud.Perintah.Parameters.AddWithValue("@id_obat", kdObatTXT.Text);
                            crud.Perintah.Parameters.AddWithValue("@tgl_expired", expiredDT.Value.Date.ToString("yyyy-MM-dd"));
                            crud.Perintah.Parameters.AddWithValue("@tgl_transaksi", pembelianDt.Value.Date.ToString("yyyy-MM-dd"));
                            crud.Perintah.Parameters.AddWithValue("@jam_masuk", DateTime.Now.ToString("H:mm:ss"));
                            crud.Perintah.Parameters.AddWithValue("@stock_masuk", qtyTXT.Value);
                            crud.Perintah.Parameters.AddWithValue("@no_faktur", noFakturTXT.Text);
                            crud.Perintah.ExecuteNonQuery();

                            crud.con_close();
                        }
                    }
                    //tbl_obat_stock
                    crud.Dt = crud.ExecuteQuery("SELECT No, satuan_utama, satuan_turunan, tgl_expired FROM tbl_obat_stock WHERE id_obat = '" + kdObatTXT.Text + "'");
                    if(crud.Dt.Rows.Count > 0)
                    {
                        idStock = crud.Dt.Rows[0]["No"].ToString();
                        satuan_utama = crud.Dt.Rows[0]["satuan_utama"].ToString();
                        satuan_turunan = crud.Dt.Rows[0]["satuan_turunan"].ToString();
                    }
                    
                    DateTime tglExpired;
                    if(DateTime.TryParse(crud.Dt.Rows[0]["tgl_expired"].ToString(),out tglExpired)){
                        isKosong = false;
                    }
                    else
                    {
                        isKosong = true;
                    }

                    if(isKosong)
                    {                       
                        crud.Delete("tbl_obat_stock", "id_obat ='" + kdObatTXT.Text + "'");                       

                        if (satuan_utama == satuanCMB.Text)
                        {
                            sql = "INSERT INTO tbl_obat_stock(No, id_obat, satuan_utama, satuan_turunan, stock_utama, tgl_expired) VALUES " +
                                   "(@no, @id_obat, @satuan_utama, @satuan_turunan, @stock, @tgl_expired)";                            
                        }
                        else if (satuan_turunan == satuanCMB.Text)
                        {
                            sql = "INSERT INTO tbl_obat_stock(No, id_obat, satuan_utama, satuan_turunan, stock_turunan, tgl_expired) VALUES " +
                                     "(@no, @id_obat,@satuan_utama, @satuan_turunan, @stock, @tgl_expired)";                            
                        }
                        if (crud.con_open())
                        {
                            using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand(sql, crud.Koneksi))
                            {

                                crud.Perintah.Parameters.Clear();
                                crud.Perintah.Parameters.AddWithValue("@no", idStock);
                                crud.Perintah.Parameters.AddWithValue("@id_obat", kdObatTXT.Text);
                                crud.Perintah.Parameters.AddWithValue("@satuan_utama", satuan_utama);
                                crud.Perintah.Parameters.AddWithValue("@satuan_turunan", satuan_turunan);
                                crud.Perintah.Parameters.AddWithValue("@stock", qtyTXT.Value);
                                crud.Perintah.Parameters.AddWithValue("@tgl_expired", expiredDT.Value.Date.ToString("yyyy-MM-dd"));
                                crud.Perintah.ExecuteNonQuery();

                                crud.con_close();
                                sql = null;
                            }
                        }                        
                    }
                    else
                    {                        
                        if (satuanCMB.Text == crud.Dt.Rows[0]["satuan_utama"].ToString())
                        {
                            sql = "UPDATE tbl_obat_stock SET stock_utama = stock_utama + @stock WHERE No = @no";
                        }
                        else if (satuanCMB.Text == crud.Dt.Rows[0]["satuan_turunan"].ToString())
                        {
                            sql = "UPDATE tbl_obat_stock SET stock_turunan = stock_turunan + @stock WHERE No = @no";
                        }

                        using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand(sql, crud.Koneksi))
                        {
                            crud.con_open();
                            //crud.Perintah.CommandText = sql;
                            crud.Perintah.Parameters.Clear();
                            crud.Perintah.Parameters.AddWithValue("@stock", qtyTXT.Value);
                            crud.Perintah.Parameters.AddWithValue("@no", idStock);
                            //crud.Perintah.Parameters.AddWithValue("@id_obat", kdObatTXT.Text);
                            //crud.Perintah.Parameters.AddWithValue("@expired", tglExpired.ToString("yyyy-MM-dd"));
                            crud.Perintah.ExecuteNonQuery();

                            crud.con_close();
                        }
                    }                                                                   
                }
                else // Jika data sudah ada
                {
                    crud.Dt = crud.ExecuteQuery("SELECT id_pembelian FROM tbl_pembelian WHERE kd_obat = '" + kdObatTXT.Text + "' AND kd_supplier = '" + kdSuppTXT.Text + "' AND no_faktur = '" + noFakturTXT.Text + "'");
                    if (crud.Dt.Rows.Count > 0)
                    {
                        id_pembelian = crud.Dt.Rows[0]["id_pembelian"].ToString();
                    }
                    
                    if (crud.con_open())
                    {
                        using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand("UPDATE tbl_pembelian SET tgl_pembelian = @tgl_pembelian, kd_supplier=@kd_supplier," +
                                                                                     "kd_obat = @kd_obat, satuan_stock = @stock, qty = qty + @qty, harga_satuan = harga_satuan + @harga_satuan," +
                                                                                       "diskon = diskon + @diskon, sub_total = sub_total + @sub_total, tgl_expired = @tgl_expired, kasir = @kasir," +
                                                                                       "keterangan = @keterangan WHERE no_faktur = @noFaktur AND id_pembelian = @id_pembelian"
                                                                                       , crud.Koneksi))
                        {
                            crud.Perintah.Parameters.Clear();
                            crud.Perintah.Parameters.AddWithValue("@id_pembelian", id_pembelian);
                            crud.Perintah.Parameters.AddWithValue("@noFaktur", noFakturTXT.Text);
                            crud.Perintah.Parameters.AddWithValue("@tgl_pembelian", pembelianDt.Value.Date.ToString("yyyy-MM-dd"));
                            crud.Perintah.Parameters.AddWithValue("@kd_supplier", kdSuppTXT.Text);
                            crud.Perintah.Parameters.AddWithValue("@kd_obat", kdObatTXT.Text);
                            crud.Perintah.Parameters.AddWithValue("@satuan", satuanCMB.Text);
                            crud.Perintah.Parameters.AddWithValue("@qty", qtyTXT.Value);
                            crud.Perintah.Parameters.AddWithValue("@harga_satuan", hargaBeliTXT.Value);
                            crud.Perintah.Parameters.AddWithValue("@diskon", diskonTXT.Value);
                            crud.Perintah.Parameters.AddWithValue("@ppn", 0);
                            crud.Perintah.Parameters.AddWithValue("@sub_total", totalHargaTXT.Value);
                            crud.Perintah.Parameters.AddWithValue("@tgl_expired", expiredDT.Value.Date.ToString("yyyy-MM-dd"));
                            crud.Perintah.Parameters.AddWithValue("@kasir", user.UserName);
                            crud.Perintah.Parameters.AddWithValue("@keterangan", ketTXT.Text);
                            crud.Perintah.ExecuteNonQuery();

                            crud.con_close();
                        }
                    }

                    crud.Dt = crud.ExecuteQuery("SELECT * FROM tbl_obat_masuk WHERE no_faktur = '" + noFakturTXT.Text + "' AND id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                    stock_akhir = int.Parse(crud.Dt.Rows[0]["stock_masuk"].ToString());
                    if(crud.Dt.Rows.Count > 0)
                    {
                        idMasuk = crud.Dt.Rows[0]["id_masuk"].ToString();
                        if (crud.con_open())
                        {
                            using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand("UPDATE tbl_obat_masuk SET tgl_transaksi = @tgl_transaksi, jam_masuk = @jam_masuk, "+
                                                                                           ",stock_masuk = @stock_masuk WHERE no_faktur = @no_faktur AND id_obat = @id_obat ", crud.Koneksi))
                            {
                                crud.Perintah.Parameters.Clear();
                                crud.Perintah.Parameters.AddWithValue("@id_masuk", idMasuk);
                                crud.Perintah.Parameters.AddWithValue("@id_obat", kdObatTXT.Text);                                
                                crud.Perintah.Parameters.AddWithValue("@tgl_transaksi", pembelianDt.Value.Date.ToString("yyyy-MM-dd"));
                                crud.Perintah.Parameters.AddWithValue("@jam_masuk", DateTime.Now.ToString("hh:mm:ss"));
                                crud.Perintah.Parameters.AddWithValue("@stock_masuk", qtyTXT.Value);
                                crud.Perintah.Parameters.AddWithValue("@no_faktur", noFakturTXT.Text);
                                crud.Perintah.ExecuteNonQuery();

                                crud.con_close();
                            }
                        }
                    }
                    else
                    {
                        if (crud.con_open())
                        {
                            using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO tbl_obat_masuk (id_masuk,id_obat,tgl_expired,tgl_transaksi,jam_masuk,stock_masuk,no_faktur) VALUES" +
                                                                                          "(@id_masuk,@id_obat,@tgl_expired,@tgl_transaksi,@jam_masuk,@stock_masuk,@no_faktur)", crud.Koneksi))
                            {
                                crud.Perintah.Parameters.Clear();
                                crud.Perintah.Parameters.AddWithValue("@id_masuk", "PO" + setControl.GenerateNumber("tbl_obat_masuk", "id_masuk"));
                                crud.Perintah.Parameters.AddWithValue("@id_obat", kdObatTXT.Text);
                                crud.Perintah.Parameters.AddWithValue("@tgl_expired", expiredDT.Value.Date.ToString("yyyy-MM-dd"));
                                crud.Perintah.Parameters.AddWithValue("@tgl_transaksi", pembelianDt.Value.Date.ToString("yyyy-MM-dd"));
                                crud.Perintah.Parameters.AddWithValue("@jam_masuk", DateTime.Now.ToString("hh:mm:ss"));
                                crud.Perintah.Parameters.AddWithValue("@stock_masuk", qtyTXT.Value);
                                crud.Perintah.Parameters.AddWithValue("@no_faktur", noFakturTXT.Text);
                                crud.Perintah.ExecuteNonQuery();

                                crud.con_close();
                            }
                        }
                    }
                    //tbl_obat_stock                    
                    crud.Dt = crud.ExecuteQuery("SELECT satuan_utama, satuan_turunan, FROM tbl_obat_stock WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                    if (satuanCMB.Text == crud.Dt.Rows[0]["satuan_utama"].ToString())
                    {                       
                        if(stock_akhir < qtyTXT.Value)
                        {
                            stock_akhir = (int)qtyTXT.Value - stock_akhir;
                            sql = "UPDATE SET stock_utama = stock_utama + @stock_utama WHERE id_obat = @id_obat AND tgl_expired = @tgl_expired";
                        }
                        else
                        {
                            stock_akhir -= (int)qtyTXT.Value;
                            sql = "UPDATE SET stock_utama = stock_utama - @stock_utama WHERE id_obat = @id_obat AND tgl_expired = @tgl_expired";
                        }

                        if (crud.con_open())
                        {
                            using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand())
                            {
                                crud.Perintah.Parameters.Clear();
                                crud.Perintah.Parameters.AddWithValue("@stock_utama", stock_akhir);
                                crud.Perintah.Parameters.AddWithValue("@id_obat", kdObatTXT.Text);
                                crud.Perintah.Parameters.AddWithValue("@tgl_expired", expiredDT.Value.Date.ToString("yyyy-MM-dd"));
                                crud.Perintah.ExecuteNonQuery();

                                crud.con_close();
                            }
                        }                                               
                    }
                    else if (crud.Dt.Rows[0]["satuan_turunan"].ToString() == satuanCMB.Text)
                    {
                        if (stock_akhir < qtyTXT.Value)
                        {
                            stock_akhir = (int)qtyTXT.Value - stock_akhir;
                            sql = "UPDATE SET stock_turunan = stock_turunan + @stock_turunan WHERE id_obat = @id_obat";
                        }
                        else
                        {
                            stock_akhir -= (int)qtyTXT.Value;
                            sql = "UPDATE SET stock_turunan = stock_turunan - @stock_turunan WHERE id_obat = @id_obat";
                        }

                        if (crud.con_open())
                        {
                            using (crud.Perintah = new MySql.Data.MySqlClient.MySqlCommand("UPDATE SET stock_turunan = stock_turunan + @stock_turunan WHERE id_obat = @id_obat"))
                            {
                                crud.Perintah.Parameters.Clear();
                                crud.Perintah.Parameters.AddWithValue("@stock_turunan", stock_akhir);
                                crud.Perintah.Parameters.AddWithValue("@id_obat", kdObatTXT.Text);
                                crud.Perintah.ExecuteNonQuery();

                                crud.con_close();
                            }
                        }                                               
                    }
                }
                Pengaturan();
            }            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
                    crud.Dt = crud.ExecuteQuery("SELECT tbl_pembelian.kd_obat, merek, nama_obat, tbl_pembelian.tgl_expired, harga_satuan, qty, sub_total, tbl_pembelian.keterangan FROM tbl_pembelian INNER JOIN tbl_obat ON tbl_pembelian.kd_obat = tbl_obat.id_obat WHERE no_faktur = '" + noFakturTXT.Text + "'");
                }                
                bgWorker.ReportProgress(i, status);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            labelTS.Text = e.ProgressPercentage.ToString() + " % " + e.UserState.ToString();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 0;
            labelTS.Text = "Ready";
            dataGridView1.DataSource = crud.Dt;
            Hitung();

            SetDataGrid setDataGrid = new SetDataGrid();
            setDataGrid.CreateHeader(dataGridView1, 7, "Kd Obat, Merek, Nama Obat, EXPIRED, Harga Satuan, QTY, Sub Total,KET", "100,75,150,150,200,200,100,200");            
            dataGridView1.Columns[4].DefaultCellStyle.Format = string.Format("c");
            dataGridView1.Columns[6].DefaultCellStyle.Format = string.Format("c");
        }

        private void FrmPembelian_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Pesan = MessageBox.Show("Transaksi masih terjadi, apakah anda ingin membatalkan transaksi ?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(Pesan != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                crud.ExecuteNonQuery("DELETE FROM tbl_pembelian WHERE no_faktur = '" + noFakturTXT.Text + "'");
                crud.ExecuteNonQuery("DELETE FROM tbl_obat_masuk WHERE no_faktur = '" + noFakturTXT.Text + "'");
            }
            Pengaturan();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                crud.ExecuteNonQuery("DELETE FROM tbl_pembelian WHERE kd_obat = '" + row.Cells[0].Value.ToString() + "' AND kd_supplier = '" +kdSuppTXT.Text + "' AND no_faktur = '" + noFakturTXT.Text + "'");
                crud.ExecuteNonQuery("DELETE FROM tbl_obat_masuk WHERE id_obat = '" + row.Cells[0].Value.ToString() + "' AND no_faktur = '" + noFakturTXT.Text + "'");
            }
            Pengaturan();
        }

        private void noFakturTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Pengaturan();
            }
        }
               
        private void tambahKeyPress(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                tambahBtn.PerformClick();
            }
        }

        private void bayarBtn_Click(object sender, EventArgs e)
        {
            var Pesan = MessageBox.Show("Akhri transaksi, dan memulai transaksi baru ?", "Mengakhiri Transaksi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (Pesan == DialogResult.Yes)
            {
                noFakturTXT.Clear();
                noFakturTXT.Focus();
                Pengaturan();
            }
        }

        private void tipeCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tipeCBX.Text == "CREDIT")
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
               dateTimePicker1.Enabled = false;                
            }
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        public static class Cultures
        {
            public static readonly CultureInfo Indonesia = new CultureInfo("id-ID");

        }
    }
}
