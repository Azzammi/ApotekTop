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
    public partial class FrmStock : Form
    {
        CRUD crud = new CRUD();
        ClsControl setControl = new ClsControl();
        bool isKosong;
        string primaryKey;
        public FrmStock()
        {
            InitializeComponent();
        }
        public string PrimaryKey
        {
            get { return this.primaryKey; }
            set { this.primaryKey = value; }
        }
        public void Pengaturan()
        {
            setControl.EmptyText(this);                      
            kdObatTxt.Focus();
            this.Close();
        }
        public bool IsKosong
        {
            get { return this.isKosong; }
            set { this.isKosong = value; }
        }
        private void FrmStock_Load(object sender, EventArgs e)
        {
            crud.Dt = crud.ExecuteQuery("SELECT merek,nama_obat FROM tbl_obat WHERE id_obat = '" + kdObatTxt.Text + "' ");
            merekTxt.Text = crud.Dt.Rows[0]["merek"].ToString();
            nmObatTxt.Text = crud.Dt.Rows[0]["nama_obat"].ToString();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            crud.Dt = crud.ExecuteQuery("SELECT tgl_expired FROM tbl_obat_stock WHERE id_obat = '" + kdObatTxt.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
            if (crud.Dt.Rows.Count == 0)
            {
                if (isKosong)
                {
                    crud.Delete("tbl_obat_stock", "id_obat ='" + kdObatTxt.Text + "'");
                }
                crud.Insert("tbl_obat_stock", "No = '" + setControl.GenerateNumber("tbl_obat_stock","No") + "',"+
                                                "id_obat = '" + kdObatTxt.Text + "'," +
                                                "satuan_utama = '" + satuanUtamaTxt.Text + "'," +
                                                "satuan_turunan = '" + satuanTurunanTxT.Text + "'," +
                                                "stock_utama = '" + stockUtamaTxt.Text + "'," +
                                                "stock_turunan = '" + stockTurunanTxt.Text + "'," +
                                                "tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
            }
            else
            {
                crud.ExecuteNonQuery("UPDATE tbl_obat_stock SET stock_utama = '" + stockUtamaTxt.Text + "'," +
                                          "stock_turunan = '" + stockTurunanTxt.Text + "' WHERE id_obat = '" + kdObatTxt.Text + "' AND tgl_expired = '" + expiredDT.Value.Date.ToString("yyyy-MM-dd") + "'");
            }
            Pengaturan();
        }
    }
}
