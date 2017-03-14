using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ApotekTop.TRANSAKSI
{
    public partial class FrmPenjualan : Form
    {
        CRUD crud = new CRUD();
        ClsControl setControl = new ClsControl();
        Random rnd = new Random();
        bool isEdit = false, isResep;
        double diskon, diskon2;
        int qty, qty2, stockUtama, stockTurunan, qtyKonversi;
        decimal subTotal, hrgJual, subTotal2, total;

        public FrmPenjualan()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
            Pengaturan();
       }
     
        private void statusEditBtn()
        {
            if (isEdit)
            {
                this.editBtn.Image = Properties.Resources.Save_50px_1;
                this.editBtn.Text = "Simpan";                
            }
            else
            {                
                this.editBtn.Image = Properties.Resources.Pencil_Tip_50px;
                this.editBtn.Text = "Edit";
            }
        }
        private void RecordLoad()
        {                    
            hargaSatuanTXT.Text = "0";
            qtyTXT.Text = "0";
            diskonTXT.Text = "0";
            subTotalTXT.Text = "0";   
        }
        private void setObat()
        {
            crud.Dt = crud.ExecuteQuery("SELECT merek, nama_obat, tgl_expired, harga_jual, status_resep FROM tbl_obat INNER JOIN tbl_obat_stock ON tbl_obat.id_obat = tbl_obat_stock.id_obat WHERE tbl_obat.id_obat = '" + kdObatTXT.Text + "' ORDER by tgl_expired ASC");
            
            if(crud.Dt.Rows.Count > 0)
            {                              
                merekTXT.Text = crud.Dt.Rows[0]["merek"].ToString();
                nmObatTXT.Text = crud.Dt.Rows[0]["nama_obat"].ToString();
                hargaSatuanTXT.Text = crud.Dt.Rows[0]["harga_jual"].ToString();
                isResep = Convert.ToBoolean(crud.Dt.Rows[0]["status_resep"]);
               // MessageBox.Show(crud.Dt.Rows[0]["status_resep"].ToString());
                if (isResep)
                {
                    panel1.BackColor = Color.Red;
                }
                else
                {
                    panel1.BackColor = Color.Green;
                }

                DateTime dateValue;
                if (DateTime.TryParse(crud.Dt.Rows[0]["tgl_Expired"].ToString(), out dateValue))
                {
                    expiredDT.Value = dateValue;
                }
                else
                {
                    MessageBox.Show("gagal Maning " + dateValue.ToString());
                    expiredDT.Value = DateTime.Now;

                }
            }            
        }
        private void Hitung()
        {
            //var count = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[6].Value.ToString() == "x");
            //MessageBox.Show(count.ToString());
            decimal totalBelanja = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                totalBelanja += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
            }
            totalLbl.Text = string.Format(Cultures.Indonesia, "{0:#,##0}", double.Parse(totalBelanja.ToString()));
        }
        private void SaveTransaksi()
        {
            crud.Dt = crud.ExecuteQuery("SELECT stock_utama, stock_turunan FROM tbl_obat_Stock WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
            stockUtama = int.Parse(crud.Dt.Rows[0]["stock_utama"].ToString());
            stockTurunan = int.Parse(crud.Dt.Rows[0]["stock_turunan"].ToString());
            qty = (int)qtyTXT.Value;
            
            if(stockTurunan < qty)
            {
                if(stockUtama <= 0)
                {
                    MessageBox.Show("Stok Tidak mencukupi , Silahkan perbaharui stok terlebih dahulu !", "Transaksi Error");
                    Pengaturan();
                }
                else
                {
                    crud.Dt = crud.ExecuteQuery("SELECT qty FROM tbl_konversi WHERE id_item = '" + kdObatTXT.Text + "' AND isDefault = 0");
                    if(crud.Dt.Rows.Count > 0)
                    {
                        qtyKonversi = int.Parse(crud.Dt.Rows[0]["qty"].ToString());
                    }
                    else
                    {
                        qtyKonversi = 1;
                    }                    
                     
                    stockTurunan = stockTurunan + (stockUtama * qtyKonversi);
                    if (stockTurunan < qty)
                    {
                        MessageBox.Show("Stok Habis, Silahkan perbaharui stok terlebih dahulu !", "Transaksi Error");
                        
                    }
                    else 
                    {
                        MessageBox.Show(stockTurunan.ToString());
                        crud.Dt = crud.ExecuteQuery("SELECT no_faktur, qty, sub_total, diskon FROM tbl_penjualan WHERE no_faktur = '" + noFakturTXT.Text + "' AND id_obat = '" + kdObatTXT.Text + "'");
                        if (crud.Dt.Rows.Count > 0)
                        {
                            qty2 = int.Parse(crud.Dt.Rows[0]["qty"].ToString());
                            //if (isEdit){
                            //    if (qty2 > qtyTXT.Value)
                            //    {
                            //        qty2 -= qty;
                            //        stockTurunan += qty2;

                            //    }
                            //    else if (qty2 < qtyTXT.Value)
                            //    {
                            //        qty = qty2 - qty;
                            //        qty2 += qty;
                            //        stockTurunan -= qty2;
                            //    }
                            //    else
                            //    {
                            //        stockTurunan = qty2;
                            //    }
                            //    qty2 = (int)qtyTXT.Value;
                            //}
                            //else
                            //{
                                stockTurunan -= qty;                                
                                qty2 += qty;

                                subTotal2 = decimal.Parse(crud.Dt.Rows[0]["sub_total"].ToString());
                                subTotal2 += subTotal;

                                diskon2 = double.Parse(crud.Dt.Rows[0]["diskon"].ToString());
                                diskon2 += diskon;
                            //}                            
                            crud.ExecuteNonQuery("UPDATE tbl_penjualan SET "+
                                                    "tgl_jual = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                    "customer = '" + nmKonsumenTXT.Text + "'," +
                                                    "qty = '" + qty2 + "'," +
                                                    "sub_total = '" + subTotal2 + "'," +
                                                    "diskon = '" + diskon2 + "'," +
                                                    "keterangan = '" + ketTXT.Text + "',"+
                                                    "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "' WHERE no_faktur = '" + noFakturTXT.Text + "' AND id_obat = '" + kdObatTXT.Text + "'");
                            crud.ExecuteNonQuery("UPDATE tbl_obat_keluar SET " +
                                                            "tgl_transaksi = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                            "jam_keluar = '" + DateTime.Now.ToString("hh:mm:ss") + "'," +
                                                            "stock_keluar = '" + qty2 + "'," +                                                            
                                                            "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "' WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                            crud.ExecuteNonQuery("UPDATE tbl_obat_stock SET stock_utama = '0', stock_turunan = '" + stockTurunan + "' WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                        }
                        else if(crud.Dt.Rows.Count == 0)
                        {
                            stockTurunan -= qty;
                            crud.Insert("tbl_penjualan", "id_penjualan = '" + setControl.GenerateNumber("tbl_penjualan", "id_penjualan") + "',"+
                                                    "no_faktur = '" + noFakturTXT.Text + "'," +
                                                    "id_obat = '" + kdObatTXT.Text + "'," +
                                                    "tgl_jual = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                    "customer = '" + nmKonsumenTXT.Text + "'," +
                                                    "qty = '" + qty + "'," +
                                                    "sub_total = '" + subTotal + "'," +
                                                    "diskon = '" + diskon + "'," +
                                                    "keterangan = '" + ketTXT.Text + "',"+
                                                    "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                            crud.Insert("tbl_obat_keluar", "id_keluar = '" + setControl.GenerateNumber("tbl_obat_keluar","id_keluar") + "',"+
                                                            "id_obat = '" + kdObatTXT.Text + "'," +
                                                           "tgl_transaksi = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                           "jam_keluar = '" + DateTime.Now.ToString("hh:mm:ss") + "'," +
                                                           "stock_keluar = '" + qty + "'," +
                                                           "no_faktur = '" + noFakturTXT.Text + "',"+
                                                           "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                            crud.ExecuteNonQuery("UPDATE tbl_obat_stock SET stock_utama = '0', stock_turunan = '" + stockTurunan + "' WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                        }                        
                    }
                   
                }
            }
            else
            {                                 
                crud.Dt = crud.ExecuteQuery("SELECT no_faktur, qty, sub_total, diskon FROM tbl_penjualan WHERE no_faktur = '" + noFakturTXT.Text + "' AND id_obat = '" + kdObatTXT.Text + "'");
                if (crud.Dt.Rows.Count > 0)
                {                    
                    qty2 = int.Parse(crud.Dt.Rows[0]["qty"].ToString());
                    //if (isEdit)
                    //{                        
                    //    diskon2 = double.Parse(diskonTXT.Text);
                    //    subTotal2 = subTotalTXT.Value;
                    //    if (qty2 > qtyTXT.Value)
                    //    {
                    //        qty2 -= qty;                    
                    //        stockTurunan -= qty2;

                    //    }
                    //    else if (qty2 < qtyTXT.Value)
                    //    {
                    //        qty -= qty2;                            
                    //        stockTurunan += qty;
                    //    }
                    //    else
                    //    {
                    //        stockTurunan = qty2;
                    //    }
                    //    qty2 = (int)qtyTXT.Value;
                    //}
                    //else
                    //{         
                    stockTurunan -= qty;
                    qty2 += qty;

                        subTotal2 = decimal.Parse(crud.Dt.Rows[0]["sub_total"].ToString());
                        subTotal2 += subTotal;

                        diskon2 = double.Parse(crud.Dt.Rows[0]["diskon"].ToString());
                        diskon2 += diskon;
                   // }               

                    crud.ExecuteNonQuery("UPDATE tbl_penjualan SET " +
                                            "tgl_jual = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                            "customer = '" + nmKonsumenTXT.Text + "'," +
                                            "qty = '" + qty2 + "'," +
                                            "sub_total = '" + subTotal2 + "'," +
                                            "diskon = '" + diskon2 + "'," +
                                            "keterangan = '" + ketTXT.Text + "',"+
                                            "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "' WHERE no_faktur = '" + noFakturTXT.Text + "' AND id_obat = '" + kdObatTXT.Text + "'");
                    crud.ExecuteNonQuery("UPDATE tbl_obat_keluar SET " +
                                                            "tgl_transaksi = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                            "jam_keluar = '" + DateTime.Now.ToString("hh:mm:ss") + "'," +
                                                            "stock_keluar = '" + qty2 + "'," +
                                                            "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "' WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                    crud.ExecuteNonQuery("UPDATE tbl_obat_stock SET stock_turunan = '" + stockTurunan + "' WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                }
                else if (crud.Dt.Rows.Count == 0)
                {
                    stockTurunan -= qty;
                    crud.Insert("tbl_penjualan", "id_penjualan = '" + setControl.GenerateNumber("tbl_penjualan", "id_penjualan") + "',"+
                                                    "no_faktur = '" + noFakturTXT.Text + "'," +
                                                    "id_obat = '" + kdObatTXT.Text + "'," +
                                                    "tgl_jual = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                    "customer = '" + nmKonsumenTXT.Text + "',"+
                                                    "qty = '" + qty + "'," +
                                                    "sub_total = '" + subTotalTXT.Value + "'," +
                                                    "diskon = '" + diskonTXT.Text + "'," +
                                                    "keterangan = '" + ketTXT.Text + "',"+
                                                    "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                    crud.Insert("tbl_obat_keluar", "id_keluar = '" + setControl.GenerateNumber("tbl_obat_keluar", "id_keluar") + "'," +
                                                    "id_obat = '" + kdObatTXT.Text + "'," +
                                                    "tgl_transaksi = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                                                    "jam_keluar = '" + DateTime.Now.ToString("hh:mm:ss") + "'," +
                                                    "stock_keluar = '" + qty + "'," +
                                                    "no_faktur = '" + noFakturTXT.Text + "'," +
                                                    "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                    crud.ExecuteNonQuery("UPDATE tbl_obat_stock SET stock_turunan = '" + stockTurunan + "' WHERE id_obat = '" + kdObatTXT.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
                }                              
            }                        
            Pengaturan();
        }
        private void Pengaturan()
        {
            //int random = rnd.Next(1500);
            string date = DateTime.Now.ToShortDateString();

            setControl.EmptyText(this);
            noFakturTXT.Focus();
            noFakturTXT.Text = "S"+date.Replace("/","") + setControl.GenerateNumber("tbl_detail_penjualan","no_faktur");
            RecordLoad();
            setObat();

            //crud.Dt = crud.ExecuteQuery("SELECT no_faktur FROM tbl_detail_penjualan WHERE no_faktur = '" + noFakturTXT.Text + "'");
            //if(crud.Dt.Rows.Count < 0)
            //{
            //    isExist = false;
            //}
            //else
            //{
            //    isExist = true;
            //}
                                        
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }
        private void CountTotal()
        {
            total = 0;
            //for (int i = 0; i < ) ;
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            using(POPUP.FrmPOPUPObat popupobat = new POPUP.FrmPOPUPObat())
            {
                popupobat.NamaForm = this.Name;
                popupobat.ShowDialog();          
                kdObatTXT.Text = popupobat.kdObat;
                nmObatTXT.Text = popupobat.nmObat;
                merekTXT.Text = popupobat.merek;
                if(popupobat.hrgObat == null)
                {
                    hargaSatuanTXT.Value = 0;
                }
                else
                {
                    hargaSatuanTXT.Value = decimal.Parse(popupobat.hrgObat);
                }                         
            }            
        }

        private void FrmPenjualan_Load(object sender, EventArgs e)
        {            
            Pengaturan();
        }

        private void kdObatCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            setObat();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                string status = "";
                System.Threading.Thread.Sleep(10);
                if(i >= 1 && i < 50)
                {
                    status = "Initializing";
                }
                else if(i == 50)
                {
                    System.Threading.Thread.Sleep(0);
                }
                else if (i >= 50 && i < 100)
                {
                    status = "Membaca data dari database";
                    crud.Dt = crud.ExecuteQuery("SELECT tbl_penjualan.id_obat, merek, nama_obat, tbl_penjualan.tgl_expired, harga_jual, qty, diskon, sub_total, customer, tbl_penjualan.keterangan FROM tbl_penjualan INNER JOIN tbl_obat ON tbl_penjualan.id_obat = tbl_obat.id_obat WHERE no_faktur = '" + noFakturTXT.Text + "'");
                }
                //Memperbarui reportProgress
                bgWorker.ReportProgress(i, status);
                
                //Jika backgroundworker dibatak=lkan
                //if (bgWorker.CancellationPending)
                //{
                //    e.Cancel = true;
                //    return;
                //}
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 0;
            labelTS.Text = "Ready";
            dataGridView1.DataSource = crud.Dt;
            SetDataGrid setDataGrid = new SetDataGrid();
            setDataGrid.CreateHeader(dataGridView1, 9, "Kd Obat, Merek, Nama Obat, EXPIRED, Harga Jual, QTY, Diskon(%), Sub Total, Customer, KET", "100,75,150,150,200,100,75,200,100,200");
            Hitung();
            dataGridView1.Columns[4].DefaultCellStyle.Format = string.Format("c",Cultures.Indonesia);
            dataGridView1.Columns[7].DefaultCellStyle.Format = string.Format("c", Cultures.Indonesia);            
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            labelTS.Text = e.ProgressPercentage.ToString() + " % " + e.UserState.ToString();                       
        }

        private void hargaSatuanTXT_TextChanged(object sender, EventArgs e)
        {
            if (hargaSatuanTXT.Text == "") hargaSatuanTXT.Text = "0";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                kdObatTXT.Text = row.Cells[0].Value.ToString();
                qtyTXT.Value = Convert.ToDecimal( row.Cells[5].Value);
                diskonTXT.Text = row.Cells[6].Value.ToString();
                subTotalTXT.Value = Convert.ToDecimal(row.Cells[7].Value);
                nmKonsumenTXT.Text = row.Cells[8].Value.ToString();
                ketTXT.Text = row.Cells[9].Value.ToString();
            }
            if(dataGridView1.SelectedRows != null)
            {
                isEdit = true;
            }
            else
            {
                isEdit = false;
            }
            statusEditBtn();
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            if (qtyTXT.Text == "0" || subTotalTXT.Text == "0")
            {
                qtyTXT.Focus();
                MessageBox.Show("Silahkan Masukkan Qty Obat !");
            }
            else
            {
                if (isResep)
                {
                    if (nmKonsumenTXT.Text == "" || ketTXT.Text == "")
                    {
                        MessageBox.Show("Untuk Obat Resep harus mencantumkan Nama Konsumen dan Dokter di keterangan");
                        nmKonsumenTXT.Focus();
                    }
                    else
                    {
                        SaveTransaksi();
                    }
                }
                else
                {
                    SaveTransaksi();
                }
            }
        }

        private void kdObatTXT_TextChanged(object sender, EventArgs e)
        {
            setObat();
        }

        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                if (qtyTXT.Text == "0" || subTotalTXT.Text == "0")
                {
                    qtyTXT.Focus();
                    MessageBox.Show("Silahkan Masukkan Qty Obat !");
                }
                else
                {
                    if (isResep)
                    {
                        if (nmKonsumenTXT.Text == "" || ketTXT.Text == "")
                        {
                            MessageBox.Show("Untuk Obat Resep harus mencantumkan Nama Konsumen dan Dokter di keterangan");
                            nmKonsumenTXT.Focus();
                        }
                        else
                        {
                            SaveTransaksi();
                        }
                    }
                    else
                    {
                        SaveTransaksi();
                    }
                }
                isEdit = false;
                statusEditBtn();
            }
            
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah Anda yakin ingin membatalkan transaksi ? ", "Pembatalan Transaksi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(pesan == DialogResult.Yes)
            {
                //crud.Delete("tbl_penjualan", "no_faktur = '" + noFakturTXT.Text + "'");
                //crud.Delete("tbl_obat_keluar", "no_faktur = '" + noFakturTXT.Text + "'");
                crud.ExecuteNonQuery("DELETE FROM tbl_penjualan WHERE no_faktur = '" + noFakturTXT.Text + "'");
                crud.ExecuteNonQuery("DELETE FROM tbl_obat_keluar WHERE no_faktur = '" + noFakturTXT.Text + "'");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DateTime dateValue;
                    if (DateTime.TryParse(row.Cells[3].Value.ToString(), out dateValue))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    crud.ExecuteNonQuery("UPDATE tbl_obat_stock SET stock_turunan = stock_turunan + '" + row.Cells[5].Value.ToString() + "' WHERE id_obat = '" + row.Cells[0].Value.ToString() + "' AND tgl_expired = '" + dateValue.ToString("yyyy-MM-dd") + "'");                                                       

                }               
                
            }
            Pengaturan();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {           
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //valuesDG += row.Cells[0].Value.ToString() + ",";
                //stockValues += row.Cells[5].Value.ToString() + ",";
                //tglExpired += row.Cells[3].Value.ToString() + ",";
                DateTime dateValue;
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out dateValue))
                {
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
                crud.ExecuteNonQuery("UPDATE tbl_obat_stock SET stock_turunan = stock_turunan + '" + row.Cells[5].Value.ToString() + "' WHERE id_obat = '" + row.Cells[0].Value.ToString() + "' AND tgl_expired = '" + dateValue.ToString("yyyy-MM-dd") + "'");
                crud.ExecuteNonQuery("DELETE FROM tbl_penjualan WHERE no_faktur = '" + noFakturTXT.Text + "'" +
                                                                       " AND id_obat = '" + row.Cells[0].Value.ToString() + "'");
                crud.ExecuteNonQuery("DELETE FROM tbl_obat_keluar WHERE id_obat = '" + row.Cells[0].Value.ToString() + "' AND no_faktur = '" + noFakturTXT.Text + "'");
                MessageBox.Show(row.Cells[5].Value.ToString());
            }                      
            Pengaturan();
        }

        private void subTotalTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tambahBtn.PerformClick();                           
            }
        }

        private void qtyTXT_TextChanged(object sender, EventArgs e)
        {
            if (qtyTXT.Text == "") qtyTXT.Text = "0";
            hrgJual = hargaSatuanTXT.Value;
            qty = (int)qtyTXT.Value;
            subTotalTXT.Value = hrgJual * qty;            
        }

        private void bayarBtn_Click(object sender, EventArgs e)
        {
            using (FrmBayar bayar = new FrmBayar())
            {
                bayar.NoFaktur = noFakturTXT.Text;
                bayar.totalTXT.Value = decimal.Parse(totalLbl.Text.Replace(".", ""));
                bayar.ShowDialog();
            }
            Pengaturan();
        }

        private void diskonTXT_TextChanged(object sender, EventArgs e)
        {                     
            double diskon = Convert.ToDouble(diskonTXT.Value);
            diskon = Convert.ToDouble(hargaSatuanTXT.Value) * diskon / 100;
            subTotal = hrgJual - (decimal)diskon;
            subTotal = subTotal * qty;
            subTotalTXT.Value = subTotal;            
        }

        public static class Cultures
        {
            public static readonly CultureInfo Indonesia = new CultureInfo("id-ID");

        }
    }
}
