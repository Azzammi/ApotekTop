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
    public partial class FrmObat : Form
    {
        bool isEdit;
        byte isResep;
        string primaryKey;
        string idSatuanUtama, idSatuanTurunan;
        decimal selisih;
        decimal hrgPokok, hrgJual, perPiece, margin;
        
        ClsControl Kontrol = new ClsControl();
        CRUD crud = new CRUD();

        public FrmObat()
        {
            InitializeComponent();
            Pengaturan();

            statusResepCBX.Items.Add("Ya");
            statusResepCBX.Items.Add("Tidak");
            // Kontrol.EmptyText(this, tipeCBX);
        }
        public bool IsEdit
        {
            get { return this.isEdit; }
            set { this.isEdit = value;  }
        }
        public string PrimaryKey
        {
            get { return this.primaryKey;  }
            set { this.primaryKey = value;  }
        }
        public void Pengaturan()
        {
            if (isEdit == false)
            {
                Kontrol.EmptyText(this, tipeCBX);
                kdObatTxt.Text = Kontrol.GenerateNumber("tbl_obat", "id_obat");
                kdObatTxt.Enabled = true;
                hargaJualTxt.Value = 0;
                hargaPokokTxt.Value = 0;
                selisihTXT.Value = 1;
                marginTxt.Value = 1;      
            }
            else
            {
                //Kontrol.EmptyText(this, tipeCBX);
                kdObatTxt.Text = primaryKey;
                kdObatTxt.Enabled = false;
                crud.ExecuteQuery("SELECT Qty FROM tbl_konversi WHERE id_Item = '" + kdObatTxt.Text + "' AND isDefault = 0");
                selisihTXT.Value = Convert.ToDecimal(crud.Dt.Rows[0]["Qty"]);                
            }

            kdObatTxt.Focus();

            crud.Dt = crud.Select("tbl_kategori", "kategori");
            kategoriCBX.DataSource = crud.Dt;
            kategoriCBX.DisplayMember = "kategori";

            crud.Dt = crud.Select("tbl_tipe", "tipe");
            tipeCBX.DataSource = crud.Dt;
            tipeCBX.DisplayMember = "tipe";

            crud.Dt = crud.Select("tbl_satuan","satuan");
            satuanStockCBX.DataSource = crud.Dt;
            satuanStockCBX.DisplayMember = "satuan";

            crud.Dt = crud.Select("tbl_satuan","satuan");
            satuanJualCBX.DataSource = crud.Dt;
            satuanJualCBX.DisplayMember = "satuan";

        }
        private void FrmObat_Load(object sender, EventArgs e)
        {
            Pengaturan();
        }
       
        private void marginTxt_TextChanged(object sender, EventArgs e)
        {
            hrgPokok = hargaPokokTxt.Value;
            selisih = selisihTXT.Value;
            perPiece = hrgPokok / selisih;

            margin = marginTxt.Value;
            margin = perPiece * margin / 100;
            hrgJual = perPiece + margin;
            hargaJualTxt.Value = hrgJual;
        }
        
        private void selisihTXT_TextChanged(object sender, EventArgs e)
        {
            if (selisihTXT.Value == 0) selisihTXT.Value = 1;
            selisih = selisihTXT.Value;
            perPiece = hrgPokok / selisih;
            hargaJualTxt.Value = perPiece;                              
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            hrgPokok = hargaPokokTxt.Value;
            hargaJualTxt.Value = hrgPokok;          
        }
       
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(statusResepCBX.Text == "Ya")
            {
                isResep = 1;
            }
            else 
            {
                isResep = 0;
            }
           // MessageBox.Show(isResep.ToString());
            crud.Dt = crud.ExecuteQuery("SELECT id_satuan FROM tbl_satuan WHERE satuan = '" + satuanJualCBX.Text + "'");
            idSatuanUtama = crud.Dt.Rows[0]["id_satuan"].ToString();

            crud.Dt = crud.ExecuteQuery("SELECT id_satuan FROM tbl_satuan WHERE satuan = '" + satuanStockCBX.Text + "'");
            idSatuanTurunan = crud.Dt.Rows[0]["id_satuan"].ToString();
            if (IsEdit)
            {
                crud.Update("tbl_obat", "merek = '" + merekTxt.Text + "', " +
                                     "nama_obat = '" + nmObatTxt.Text + "', " +
                                     "tipe = '" + tipeCBX.Text + "',"+
                                     "kategori = '" + kategoriCBX.Text + "', " +
                                     "status_resep = " + isResep + " , " +
                                     "satuan_stock = '" + satuanStockCBX.Text + "', " +
                                     "harga_pokok = '" + hargaPokokTxt.Value + "'," +
                                     "satuan_jual = '" + satuanJualCBX.Text + "'," +
                                     "harga_jual = '" + hargaJualTxt.Value + "', " +
                                     "margin_jual = '" + marginTxt.Value + "'," +
                                     "keterangan = '" + keteranganTXT.Text + "'", "id_obat = '" + kdObatTxt.Text + "'");
                crud.Update("tbl_obat_stock", "satuan_utama = '" + satuanStockCBX.Text + "'," +
                                                "satuan_turunan = '" + satuanJualCBX.Text + "'", "id_obat = '" + kdObatTxt.Text + "'");
                if (idSatuanTurunan != idSatuanUtama)
                {
                    crud.ExecuteNonQuery("UPDATE tbl_konversi SET id_satuan = '" + idSatuanUtama + "', " +
                                                "Qty = '" + selisihTXT.Value + "', " +
                                                "isDefault = 0 WHERE id_item = '" + kdObatTxt.Text + "' AND id_satuan = '" + idSatuanTurunan + "'");
                }               
                crud.ExecuteNonQuery("UPDATE tbl_konversi SET id_satuan = '" + idSatuanTurunan + "', " +
                                                 "Qty = '" + selisihTXT.Value + "', " +
                                                 "isDefault = 1 WHERE id_item = '" + kdObatTxt.Text + "' AND id_satuan = '" + idSatuanTurunan + "'");
                this.Close();
            }
            else
            {
                crud.Insert("tbl_obat", "id_obat = '" + kdObatTxt.Text + "', " +
                                    "merek = '" + merekTxt.Text + "', " +
                                    "nama_obat = '" + nmObatTxt.Text + "', " +
                                    "tipe = '" + tipeCBX.Text + "',"+
                                    "kategori = '" + kategoriCBX.Text + "', " +
                                    "status_resep = " + isResep + " , " +
                                    "satuan_stock = '" + satuanStockCBX.Text + "', " +
                                    "harga_pokok = '" + hrgPokok + "'," +
                                    "satuan_jual = '" + satuanJualCBX.Text + "'," +
                                    "harga_jual = '" + hrgJual + "', " +
                                    "margin_jual = '" + marginTxt.Value + "'," +
                                    "keterangan = '" + keteranganTXT.Text + "'");
                crud.Insert("tbl_obat_stock", "id_obat = '" + kdObatTxt.Text + "',"+ 
                                                "satuan_utama = '" + satuanStockCBX.Text + "'," +
                                               "satuan_turunan = '" + satuanJualCBX.Text + "'");
                if (idSatuanTurunan != idSatuanUtama)
                    if (idSatuanTurunan != idSatuanUtama)
                {
                    crud.Insert("tbl_konversi", "id_Item = '" + kdObatTxt.Text + "'," +
                                                "id_satuan = '" + idSatuanTurunan + "', " +
                                                "Qty = '" + selisihTXT.Value + "', " +
                                                "isDefault = 0");
                }
                crud.Insert("tbl_konversi", "id_Item = '" + kdObatTxt.Text + "'," +
                                                "id_satuan = '" + idSatuanUtama + "', " +
                                                "Qty = '1', " +
                                                "isDefault = 1");
                //MessageBox.Show(idSatuanTurunan + " / " + idSatuanUtama);
            }         
                       
            IsEdit = false;
            Pengaturan();
        }
        //private void Margins()
        //{
        //    //hrgPokok = decimal.Parse(hargaPokokTxt.Text.Replace(".", ""));
        //    perPiece = hrgPokok / selisih;            
        //    margin = perPiece * margin / 100;
        //    hrgJual = perPiece + margin;
        //    hargaJualTxt.Text   = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0}", double.Parse(hrgJual.ToString()));
        //}

        //private bool IsNumeric(int Val)
        //{
        //    return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        //}
        
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
